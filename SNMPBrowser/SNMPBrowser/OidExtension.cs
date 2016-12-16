using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnmpSharpNet;

namespace SNMPBrowser {
    public static class OidExtension {
        public static Oid FindRoot(this Oid thisOid, Oid otherOid) {
            var thisOidString = thisOid.ToString();
            var otherOidString = otherOid.ToString();
            var sb = new StringBuilder();

            for (int i = 0; i < thisOidString.Length; i++) {
                if (thisOidString[i].Equals(otherOidString[i])) {
                    sb.Append(thisOidString[i]);
                }
                else break;
            }

            var rootOidString = sb.ToString().TrimEnd('.');
            return new Oid(rootOidString);
        }
    }
}
