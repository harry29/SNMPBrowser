using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SNMPBrowser;

namespace SNMPBrowserTest {
    [TestClass]
    public class SnmpClientTest {
        [TestMethod]
        public void getRequestTest() {
            SnmpClient snmpClient = new SnmpClient();
            Assert.IsNotNull(snmpClient.GetRequest("1.3.6.1.2.1.1.3.0"));
        }

        //[TestMethod]
        //public void observeTest() {
        //    SNMPClient snmpClient = new SNMPClient();
        //    snmpClient.observe("1.3.6.1.2.1.1.1.0");
        //}
    }
}
