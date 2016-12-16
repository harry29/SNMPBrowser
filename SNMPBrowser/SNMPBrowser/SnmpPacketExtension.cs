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
