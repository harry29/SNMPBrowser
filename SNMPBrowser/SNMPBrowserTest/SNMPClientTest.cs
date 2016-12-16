using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnmpSharpNet;
using SNMPBrowser;

namespace SNMPBrowserTest {
    [TestClass]
    public class SnmpClientTest {
        [TestMethod]
        public void GetRequestTest() {
            SnmpClient snmpClient = new SnmpClient();
            Assert.IsNotNull(snmpClient.GetRequest("1.3.6.1.2.1.1.3.0"));
        }

        [TestMethod]
        public void GetTableTest() {
            SnmpClient snmpClient = new SnmpClient();
            ShowGetTableResult(snmpClient.GetTable(".1.3.6.1.2.1.6.13"));
        }

        [TestMethod]
        public void ListenTest() {
            SnmpClient snmpClient = new SnmpClient();
            snmpClient.Listen();
        }

        private void ShowGetTableResult(Dictionary<Oid, AsnType> result) {
            List<KeyValuePair<Oid, AsnType>> resultList = new List<KeyValuePair<Oid, AsnType>>(result);
            for (int i = 0; i < resultList.Count - 1; i++) {
                var prev = resultList[i];
                var next = resultList[i + 1];

                Console.WriteLine(prev.Key.FindRoot(next.Key));
            }
        }
    }
}
