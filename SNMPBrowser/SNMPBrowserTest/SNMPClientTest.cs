using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SNMPBrowser;

namespace SNMPBrowserTest {
    [TestClass]
    public class SNMPClientTest {
        [TestMethod]
        public void getRequestTest() {
            SNMPClient snmpClient = new SNMPClient();
            Assert.IsNotNull(snmpClient.getRequest("1.3.6.1.2.1.1.3.0"));
        }

        [TestMethod]
        public void observeTest() {
            SNMPClient snmpClient = new SNMPClient();
            snmpClient.observe("1.3.6.1.4.1.8072.2.3.2.1");
        }
    }
}
