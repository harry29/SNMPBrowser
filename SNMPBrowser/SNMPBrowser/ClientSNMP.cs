using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnmpSharpNet;

namespace SNMPBrowser
{
    class ClientSNMP
    {
        public static string host = "localhost";
        public static string community = "public";

        SimpleSnmp snmp = new SimpleSnmp(host, community);

        Dictionary<Oid, AsnType> result = snmp.GetNext(SnmpVersion.Ver2,
                                                    new string[] {
                                                        ".1.3.6.1.2.1.1.1",
                                                        ".1.3.6.1.2.1.1.2"
                                                    });




    }
}

