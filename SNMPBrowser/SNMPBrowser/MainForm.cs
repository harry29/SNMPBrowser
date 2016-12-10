using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnmpSharpNet;
using System.Net.Sockets;
using System.Net;

namespace SNMPBrowser {
    public partial class MainForm : Form {
        private DataGridView dataGridView;
        private DataGridView trapGridView;
        private TextBox textbox;
        TabPage trapTabPage = new TabPage("Trap Receiver");

        private SNMPClient clientSNMP = new SNMPClient();
        private string selectedOperation;

        private const string GET_REQUEST = "GetRequest";
        private const string GET_NEXT_REQUEST = "GetNextRequest";
        private const string OBSERVE = "Observe";
        private const string RECEIVE_TRAP = "ReceiveTrap";

        public MainForm() {
            InitializeComponent();
            createDataGrid();
            createTrapGridView();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.WorkerReportsProgress = true;
        }

        private void createDataGrid() {
            dataGridView = new DataGridView();
            dataGridView.Columns.Add("oidColumn", "OID");
            dataGridView.Columns.Add("valueColumn", "Value");
            dataGridView.Columns.Add("typeColumn", "Type");
            dataGridView.Size = tabControl.SelectedTab.Size;
            tableTabPage.Controls.Add(dataGridView);
        }

        private void createTrapGridView() {
            trapGridView = new DataGridView();
            //trapGridView.Columns.Add("communityColumn", "Community");
            //trapGridView.Columns.Add("vbColumn", "VarBind Count");
            trapGridView.Columns.Add("oidColumn", "OID");
            trapGridView.Columns.Add("valueColumn", "Value");
            trapGridView.Columns.Add("typeColumn", "Type");
            
        }

        private void MainForm_Load(object sender, EventArgs e) {
            operationComboBox_Initialize();
        }

        private void operationComboBox_Initialize() {
            operationComboBox.Items.Add(GET_REQUEST);
            operationComboBox.Items.Add(GET_NEXT_REQUEST);
            operationComboBox.Items.Add(RECEIVE_TRAP);
            operationComboBox.Items.Add(OBSERVE);
            
            operationComboBox.SelectedItem = GET_REQUEST;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e) {
            selectedOperation = operationComboBox.SelectedItem.ToString();
        }

        private void showResult(Dictionary<Oid, AsnType> result) {
            if (result == null) {
                MessageBox.Show("Request failed.");
            }
            else {
                foreach (KeyValuePair<Oid, AsnType> entry in result) {
                    if (entry.Value.ToString().Equals("Null")) {
                        MessageBox.Show("Request failed.", "SNMP Browser Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else {
                        dataGridView.Rows.Add(entry.Key.ToString(), entry.Value.ToString(),
                            SnmpConstants.GetTypeName(entry.Value.Type));
                    }
                }
            }
        }

        private void goButton_Click(object sender, EventArgs e) {
            switch (selectedOperation) {
                case GET_REQUEST:
                    showResult(clientSNMP.getRequest(oidTextBox.Text));
                    break;
                case GET_NEXT_REQUEST:
                    showResult(clientSNMP.getNextRequest(oidTextBox.Text));
                    break;
                case OBSERVE:
                    

                    break;
                case RECEIVE_TRAP:
                    tabControl.TabPages.Add(trapTabPage);

                    //trapTabPage.Controls.Add(trapGridView);
                    //trapGridView.Size = trapTabPage.Size;
                    textbox = new TextBox();
                    textbox.Multiline = true;
                    textbox.Size = trapTabPage.Size;
                    
                    trapTabPage.Controls.Add(textbox);

                    tabControl.SelectedTab = trapTabPage;

                    backgroundWorker1.RunWorkerAsync();
                    break;
            }
        }


        public void receiveTrap() {
        
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 162);
            EndPoint ep = (EndPoint)ipep;
            socket.Bind(ep);

            // Disable timeout processing. Just block until packet is received 
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 0);
            bool run = true;
            int inlen = -1;
            while (run) {
                byte[] indata = new byte[16 * 1024];
                // 16KB receive buffer int inlen = 0;
                IPEndPoint peer = new IPEndPoint(IPAddress.Any, 0);
                EndPoint inep = (EndPoint)peer;
                try {
                    inlen = socket.ReceiveFrom(indata, ref inep);
                }
                catch (Exception ex) {
                    textbox.AppendText(string.Format("Exception {0}", ex.Message + "\n"));
                    inlen = -1;
                }
                if (inlen > 0) {
                    // Check protocol version int 
                    int ver = SnmpPacket.GetProtocolVersion(indata, inlen);
                    if (ver == (int)SnmpVersion.Ver1) {
                        // Parse SNMP Version 1 TRAP packet 
                        SnmpV1TrapPacket pkt = new SnmpV1TrapPacket();
                        pkt.decode(indata, inlen);
                        textbox.AppendText(string.Format("** SNMP Version 1 TRAP received from {0}:", inep.ToString() + "\n"));
                        textbox.AppendText(string.Format("*** Trap generic: {0}", pkt.Pdu.Generic + "\n"));
                        textbox.AppendText(string.Format("*** Trap specific: {0}", pkt.Pdu.Specific + "\n"));
                        textbox.AppendText(string.Format("*** Agent address: {0}", pkt.Pdu.AgentAddress.ToString() + "\n"));
                        textbox.AppendText(string.Format("*** Timestamp: {0}", pkt.Pdu.TimeStamp.ToString() + "\n"));
                        textbox.AppendText(string.Format("*** VarBind count: {0}", pkt.Pdu.VbList.Count + "\n"));
                        textbox.AppendText(string.Format("*** VarBind content:" + "\n"));
                        foreach (Vb v in pkt.Pdu.VbList) {
                            textbox.AppendText(string.Format("**** {0} {1}: {2}", v.Oid.ToString(), SnmpConstants.GetTypeName(v.Value.Type), v.Value.ToString() + "\n"));
                        }
                        textbox.AppendText("** End of SNMP Version 1 TRAP data." + "\n");
                    }
                    else {
                        // Parse SNMP Version 2 TRAP packet 
                        SnmpV2Packet pkt = new SnmpV2Packet();
                        pkt.decode(indata, inlen);
                        textbox.AppendText(string.Format("** SNMP Version 2 TRAP received from {0}:", inep.ToString() + "\n"));
                        if ((SnmpSharpNet.PduType)pkt.Pdu.Type != PduType.V2Trap) {
                           textbox.AppendText(string.Format("*** NOT an SNMPv2 trap ****" + "\n"));
                        }
                        else {
                            textbox.AppendText(string.Format("*** Community: {0}", pkt.Community.ToString() + "\n"));
                            textbox.AppendText(string.Format("*** VarBind count: {0}", pkt.Pdu.VbList.Count + "\n"));
                            textbox.AppendText(string.Format("*** VarBind content:" + "\n"));
                            foreach (Vb v in pkt.Pdu.VbList) {
                                textbox.AppendText(string.Format("**** {0} {1}: {2} \n",
                                   v.Oid.ToString(), SnmpConstants.GetTypeName(v.Value.Type), v.Value.ToString() + "\n"));
                                
                            }
                            textbox.AppendText(string.Format("** End of SNMP Version 2 TRAP data. \n"));
                        }
                    }
                }
                else {
                    if (inlen == 0)
                        textbox.AppendText(string.Format("Zero length packet received." + "\n"));
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e) {
            var selectedTab = tabControl.SelectedTab;

            if (selectedTab.Equals(tableTabPage)) {
                selectedTab.Controls.Remove(dataGridView);
                createDataGrid();
            }
            else {
                tabControl.TabPages.Remove(selectedTab);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            receiveTrap();
        }
    }
}