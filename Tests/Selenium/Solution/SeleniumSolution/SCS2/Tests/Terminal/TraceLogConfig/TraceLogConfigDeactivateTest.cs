using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.TraceLogConfig;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Terminal.TraceLogConfig
{
    [TestClass]
    public class TraceLogConfigDeactivateTest
    {
        private static TerminalTraceLogConfigView _terminalTraceLogConfigView;
        private static TerminalTraceLogConfigEdit _terminalTraceLogConfigEdit;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _terminalTraceLogConfigEdit = new TerminalTraceLogConfigEdit();
            _terminalTraceLogConfigView = new TerminalTraceLogConfigView();
        }

        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate("/TracelogConfig/Edit/?TerminalId=21011402");
        }

        [TestMethod]
        public void ChangeTraceLogConfigAndSave()
        {
            _terminalTraceLogConfigEdit.ActivatedUntil.TypeText("Date");
            _terminalTraceLogConfigEdit.Parameter.TypeText("Parameter");
            _terminalTraceLogConfigEdit.Medium.SelectByValue("2 Local");
            _terminalTraceLogConfigEdit.Medium.SelectByValue("1 Remote");
            _terminalTraceLogConfigEdit.DestinationAddress.TypeText("111.111.111.111");
            _terminalTraceLogConfigEdit.DestinationPort.TypeText("11111");
            _terminalTraceLogConfigEdit.TelephoneIsdn.TypeText("004412345677890");
            _terminalTraceLogConfigEdit.TelephonePstn.TypeText("003312345677890");
            _terminalTraceLogConfigEdit.DestinationUrl.TypeText("www.six-group.com");
            _terminalTraceLogConfigEdit.DestinationUrlPort.TypeText("22222");

            _terminalTraceLogConfigEdit.Save.Click();

            Assert.AreEqual(_terminalTraceLogConfigView.ActivatedUntil, "Date");
            Assert.AreEqual(_terminalTraceLogConfigView.Parameter, "Parameter");
            Assert.AreEqual(_terminalTraceLogConfigView.Medium, "1 Remote");
            Assert.AreEqual(_terminalTraceLogConfigView.Medium, "2 Local");
            Assert.AreEqual(_terminalTraceLogConfigView.DestinationAddress, "111.111.111.111");
            Assert.AreEqual(_terminalTraceLogConfigView.DestinationPort, "11111");
            Assert.AreEqual(_terminalTraceLogConfigView.TelephoneIsdn, "004412345677890");
            Assert.AreEqual(_terminalTraceLogConfigView.TelephonePstn, "003312345677890");
            Assert.AreEqual(_terminalTraceLogConfigView.DestinationUrl, "www.six-group.com");
            Assert.AreEqual(_terminalTraceLogConfigView.DestinationUrlPort, "22222");
            // Assert.IsTrue(_terminalTraceLogConfig.Equals(this));
            // CollectionAssert.Contains(_terminalEventLog.EventList, "at least List with");
        }

        [TestMethod]
        public void SetDateInThePastFailed()
        {
            // Assert.IsTrue(_terminalTraceLogConfig.Equals(this));
            // CollectionAssert.Contains(_terminalEventLog.EventList, "at least List with");
        }

        [TestMethod]
        public void WihtEmptyParameterFailed()
        {
            // Assert.IsTrue(_terminalTraceLogConfig.Equals(this));
            // CollectionAssert.Contains(_terminalEventLog.EventList, "at least List with");
        }
    }
}