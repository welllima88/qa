using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Terminal.TraceLogConfig;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Terminal.TraceLogConfig
{
    [TestClass]
    public class TraceLogConfigDeactivateTest
    {
        [ClassInitialize]
        public static void TestInit(TestContext testContext)
        {
            TestDirector.Navigate("TracelogConfig/Edit/?TerminalId=21011402");

            TerminalTraceLogConfigEdit.ActivatedUntil = "24.12.2022";
            TerminalTraceLogConfigEdit.Parameter = "Parameter";
            TerminalTraceLogConfigEdit.Medium = "2";
            TerminalTraceLogConfigEdit.DestinationAddress = "111.111.111.555";
            TerminalTraceLogConfigEdit.DestinationPort = "11115";
            TerminalTraceLogConfigEdit.TelephoneIsdn = "004412345677890";
            TerminalTraceLogConfigEdit.TelephonePstn = "003312345677890";
            TerminalTraceLogConfigEdit.DestinationUrl = "www.six-group.com";
            TerminalTraceLogConfigEdit.DestinationUrlPort = "22225";

            TerminalTraceLogConfigEdit.Save.Click();
        }

        [TestMethod]
        public void ActivatedUntil()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.ActivatedUntil, "24.12.2022");
        }

        [TestMethod]
        public void Parameter()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.Parameter, "Parameter");
        }

        [TestMethod]
        public void Medium()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.Medium, "Local");
        }

        [TestMethod]
        public void DestinationAddress()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.DestinationAddress, "111.111.111.555");
        }

        [TestMethod]
        public void DestinationPort()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.DestinationPort, "11115");
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
            Assert.AreEqual(TerminalTraceLogConfigView.DestinationUrlPort, "22225");
            // Assert.IsTrue(_terminalTraceLogConfig.Equals(this));
            // CollectionAssert.Contains(TerminalEventLog.EventList, "at least List with");
        }
    }
}