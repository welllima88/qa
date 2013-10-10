using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.TraceLogConfig;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Terminal.TraceLogConfig
{
    [TestClass]
    public class TraceLogConfigDeactivateTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate("/TracelogConfig/Edit/?TerminalId=21011402");
        }

        [TestMethod]
        public void ChangeTraceLogConfigAndSave()
        {
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

            Assert.AreEqual(TerminalTraceLogConfigView.ActivatedUntil, "Date");
            Assert.AreEqual(TerminalTraceLogConfigView.Parameter, "Parameter");
            Assert.AreEqual(TerminalTraceLogConfigView.Medium, "1 Remote");
            //Assert.AreEqual(TerminalTraceLogConfigView.Medium, "2 Local");
            Assert.AreEqual(TerminalTraceLogConfigView.DestinationAddress, "111.111.111.111");
            Assert.AreEqual(TerminalTraceLogConfigView.DestinationPort, "11111");
            Assert.AreEqual(TerminalTraceLogConfigView.TelephoneIsdn, "004412345677890");
            Assert.AreEqual(TerminalTraceLogConfigView.TelephonePstn, "003312345677890");
            Assert.AreEqual(TerminalTraceLogConfigView.DestinationUrl, "www.six-group.com");
            Assert.AreEqual(TerminalTraceLogConfigView.DestinationUrlPort, "22222");
            // Assert.IsTrue(_terminalTraceLogConfig.Equals(this));
            // CollectionAssert.Contains(TerminalEventLog.EventList, "at least List with");
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