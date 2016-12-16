using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnmpSharpNet;

namespace SNMPBrowser {
    public static class SnmpPacketExtension {
        public static VbCollection GetValues(this SnmpPacket snmpPacket) {
            if (snmpPacket is SnmpV1TrapPacket)
                return ((SnmpV1TrapPacket) snmpPacket).Pdu.VbList;
            else
                return snmpPacket.Pdu.VbList;
        }
    }
}
