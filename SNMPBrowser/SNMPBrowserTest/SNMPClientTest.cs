using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var table = snmpClient.GetTable(".1.3.6.1.2.1.6.13");
        }

        [TestMethod]
        public void ListenTest() {
            SnmpClient snmpClient = new SnmpClient();
            snmpClient.Listen();
        }
    }
}
