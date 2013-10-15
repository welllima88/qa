using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.TraceLogConfig;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Terminal.TraceLogConfig
{
    [TestClass]
    public class TraceLogConfigActivateTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("/TracelogConfig/Edit/?TerminalId=21011402");

            TerminalTraceLogConfigEdit.ActivatedUntil.TypeText("Date");
            TerminalTraceLogConfigEdit.Parameter.TypeText("Parameter");
            TerminalTraceLogConfigEdit.Medium.SelectByValue("2 Local");
            TerminalTraceLogConfigEdit.Medium.SelectByValue("1 Remote");
            TerminalTraceLogConfigEdit.DestinationAddress.TypeText("111.111.111.111");
            TerminalTraceLogConfigEdit.DestinationPort.TypeText("11111");
            TerminalTraceLogConfigEdit.TelephoneIsdn.TypeText("004412345677890");
            TerminalTraceLogConfigEdit.TelephonePstn.TypeText("003312345677890");
            TerminalTraceLogConfigEdit.DestinationUrl.TypeText("www.six-group.com");
            TerminalTraceLogConfigEdit.DestinationUrlPort.TypeText("22222");

            TerminalTraceLogConfigEdit.Save.Click();
        }

        [TestMethod]
        public void ActivatedUntil()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.ActivatedUntil, "Date");
            // Assert.IsTrue(_terminalTraceLogConfig.Equals(this));
            // CollectionAssert.Contains(TerminalEventLog.EventList, "at least List with");
        }

        [TestMethod]
        public void Parameter()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.Parameter, "Parameter");
        }

        [TestMethod]
        public void Medium()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.Medium, "1 Remote");
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

        [TestMethod]
        public void SetDateInThePastFailed()
        {
            // Assert.IsTrue(_terminalTraceLogConfig.Equals(this));
            // CollectionAssert.Contains(TerminalEventLog.EventList, "at least List with");
        }

        [TestMethod]
        public void WihtEmptyParameterFailed()
        {
            // Assert.IsTrue(_terminalTraceLogConfig.Equals(this));
            // CollectionAssert.Contains(TerminalEventLog.EventList, "at least List with");
        }
    }
}