using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.TestObjects.Terminal.TraceLogConfig;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.Tests.Terminal.TraceLogConfig
{
    [TestClass]
    public class TraceLogConfigActivateTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("TracelogConfig/Edit/?TerminalId=21011402");

            TerminalTraceLogConfigEdit.ActivatedUntil = "24.10.2020";
            TerminalTraceLogConfigEdit.Parameter = "Parameter";
            TerminalTraceLogConfigEdit.Medium = "2";
            TerminalTraceLogConfigEdit.Medium = "1";
            TerminalTraceLogConfigEdit.DestinationAddress = "111.111.111.111";
            TerminalTraceLogConfigEdit.DestinationPort = "11111";
            TerminalTraceLogConfigEdit.TelephoneIsdn = "004412345677890";
            TerminalTraceLogConfigEdit.TelephonePstn = "003312345677890";
            TerminalTraceLogConfigEdit.DestinationUrl = "www.six-group.com";
            TerminalTraceLogConfigEdit.DestinationUrlPort = "22222";

            TerminalTraceLogConfigEdit.Save.Click();
        }

        [TestMethod]
        public void ActivatedUntil()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.ActivatedUntil, "24.10.2020");
        }

        [TestMethod]
        public void Parameter()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.Parameter, "Parameter");
        }

        [TestMethod]
        public void Medium()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.Medium, "Remote");
        }

        [TestMethod]
        public void DestinationAddress()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.DestinationAddress, "111.111.111.111");
        }

        [TestMethod]
        public void DestinationPort()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.DestinationPort, "11111");
        }

        [TestMethod]
        public void TelephoneIsdn()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.TelephoneIsdn, "004412345677890");
        }

        [TestMethod]
        public void TelephonePstn()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.TelephonePstn, "003312345677890");
        }

        [TestMethod]
        public void DestinationUrl()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.DestinationUrl, "www.six-group.com");
        }

        [TestMethod]
        public void DestinationUrlPort()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.DestinationUrlPort, "22222");
        }
    }
}