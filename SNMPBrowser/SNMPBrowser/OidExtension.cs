using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SnmpSharpNet;

namespace SNMPBrowser {
    public static class OidExtension {
        public static Oid FindCommonRoot(this Oid thisOid, Oid otherOid) {
            var thisOidString = thisOid.ToString();
            var otherOidString = otherOid.ToString();
            var numberOfCharsInShorterOidString = thisOidString.Length <= otherOidString.Length ? thisOidString.Length : otherOidString.Length;
            var sb = new StringBuilder();



            for (int i = 0; i < numberOfCharsInShorterOidString; i++) {
                if (thisOidString[i].Equals(otherOidString[i])) {
                    sb.Append(thisOidString[i]);
                }
                else break;
            }

            var rootOidString = sb.ToString().TrimEnd('.');
            return new Oid(rootOidString);
        }

        public static Oid CutCommonRoot(this Oid thisOid, Oid otherOid) {
            var rootOid = FindCommonRoot(thisOid, otherOid);
            return new Oid(DeleteRootSubstring(thisOid.ToString(), rootOid.ToString()));
        }

        private static string DeleteRootSubstring(string from, string rootOid) {
            return from.Remove(0, rootOid.Length);
        }

        public static int LevelValue(this Oid thisOid, int levelNumber) {
            var thisOidString = thisOid.ToString();
            var splitted = thisOidString.Split('.');
            return int.Parse(splitted[levelNumber]);
        }

        public static string CutAfterLevel(this Oid thisOid, int levelNumber) {
            var thisOidString = thisOid.ToString();
            var splitted = thisOidString.Split('.');
            return string.Join(".", splitted.Take(levelNumber));
        }

        public static int Levels(this Oid thisOid) {
            var thisOidString = thisOid.ToString();
            var splitted = thisOidString.Split('.');
            return splitted.Length;
        }
    }
}
