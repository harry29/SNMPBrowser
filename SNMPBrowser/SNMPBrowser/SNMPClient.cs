using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnmpSharpNet;
using SNMPBrowser.Properties;

namespace SNMPBrowser
{
    public class SnmpClient
    {
        public delegate void TrapHandler(object sender, SnmpPacket snmpPacket);
        public string CurrentOid { get; private set; }
        public event TrapHandler OnTrapRecieved;

        private readonly SimpleSnmp _simpleSnmp;
        private readonly SnmpVersion _snmpVersion;

        public SnmpClient() {
            _simpleSnmp = new SimpleSnmp(Settings.Default.Host, Settings.Default.Community);
            _snmpVersion = Settings.Default.SnmpVersion;
        }

        public Dictionary<Oid, AsnType> GetRequest(string oid) {
            CurrentOid = oid;
            return _simpleSnmp.Get(_snmpVersion, new[] { oid });
        }

        public Dictionary<Oid, AsnType> GetNextRequest(string oid) {
            var result = _simpleSnmp.GetNext(_snmpVersion, new[] { oid });

            CurrentOid = result.FirstOrDefault().Key.ToString();

            return result;
        }

        public Dictionary<Oid, AsnType> GetTable(string oid) {
            var result = new Dictionary<Oid, AsnType>();
            var tableRootOid = oid.TrimStart('.');

            CurrentOid = tableRootOid;
            do {
                result = result.Concat(GetNextRequest(CurrentOid)).ToDictionary(pair => pair.Key, pair => pair.Value);
            } while (CurrentOid.Contains(tableRootOid));

            Oid lastOid = new Oid();
            lastOid.Set(CurrentOid);
            result.Remove(lastOid); 
            return result;
        }

        private Dictionary<Oid, AsnType> GetBulk(string oid, int maxRepetitions, int nonRepeaters)
        {
            var bulkPdu = new Pdu { Type = PduType.GetBulk };
            bulkPdu.VbList.Add(oid);
            bulkPdu.MaxRepetitions = maxRepetitions;
            bulkPdu.NonRepeaters = nonRepeaters;
            return _simpleSnmp.GetBulk(bulkPdu);
        }


        public void Listen() {
            var ipEndPoint = new IPEndPoint(IPAddress.Any, 162);

            Task.Run(async () => {
                var run = true;
                while (run) {
                    try {
                        using (var udpListener = new UdpClient(ipEndPoint)) {
                            var udpRecieveResult = await udpListener.ReceiveAsync();
                            var recievedData = udpRecieveResult.Buffer;

                            int protocolVersion = SnmpPacket.GetProtocolVersion(recievedData, recievedData.Length);

                            switch (protocolVersion) {
                                case (int) SnmpVersion.Ver1:
                                    var snmpV1TrapPacket = new SnmpV1TrapPacket();
                                    snmpV1TrapPacket.decode(recievedData, recievedData.Length);
                                    RecieveTrap(snmpV1TrapPacket);
                                    break;

                                case (int) SnmpVersion.Ver2:
                                    var snmpV2Packet = new SnmpV2Packet();
                                    snmpV2Packet.decode(recievedData, recievedData.Length);
                                    RecieveTrap(snmpV2Packet);
                                    break;

                                case (int) SnmpVersion.Ver3:
                                    var snmpV3Packet = new SnmpV3Packet();
                                    snmpV3Packet.decode(recievedData, recievedData.Length);
                                    RecieveTrap(snmpV3Packet);
                                    break;
                            }
                        }
                    }
                    catch (SocketException) {
                        ErrorMessageBox.Show($"Port {ipEndPoint.Port} is already used.");
                        run = false;
                    }
                    catch (Exception e) {
                        ErrorMessageBox.Show($"{e.Message}");
                    }
                }
            });
        }

        protected void RecieveTrap(SnmpPacket snmpPacket) {
            OnTrapRecieved?.Invoke(this, snmpPacket);
        }
    }
}

