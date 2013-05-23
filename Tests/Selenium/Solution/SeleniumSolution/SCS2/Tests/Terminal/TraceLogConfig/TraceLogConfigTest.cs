﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.TraceLogConfig;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Terminal.TraceLogConfig
{
    [TestClass]
    public class TraceLogConfigActivateTest
    {
        private static TerminalTraceLogConfigView _terminalTraceLogConfigView;
        private static TerminalTraceLogConfigEdit _terminalTraceLogConfigEdit;
        private static IWebDriverAdapter _driver;
        private static ScsPlatinTestDirector _tb;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login
            _terminalTraceLogConfigEdit = new TerminalTraceLogConfigEdit(_driver);
            _terminalTraceLogConfigView = new TerminalTraceLogConfigView(_driver);

            _driver.Url = _tb.BaseUrl + "/TracelogConfig/Edit/?TerminalId=21011402";

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
        }

        [TestInitialize]
        public void TestInit()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            //after last test-method finished
            _tb.ShutDownTest();
        }

        [TestMethod]
        public void ActivatedUntil()
        {
            Assert.AreEqual(_terminalTraceLogConfigView.ActivatedUntil, "Date");
            // Assert.IsTrue(_terminalTraceLogConfig.Equals(this));
            // CollectionAssert.Contains(_terminalEventLog.EventList, "at least List with");
        }

        [TestMethod]
        public void Parameter()
        {
            Assert.AreEqual(_terminalTraceLogConfigView.Parameter, "Parameter");
        }

        [TestMethod]
        public void Medium()
        {
            Assert.AreEqual(_terminalTraceLogConfigView.Medium, "1 Remote");
        }

        [TestMethod]
        public void DestinationAddress()
        {
            Assert.AreEqual(_terminalTraceLogConfigView.DestinationAddress, "111.111.111.111");
        }

        [TestMethod]
        public void DestinationPort()
        {
            Assert.AreEqual(_terminalTraceLogConfigView.DestinationPort, "11111");
        }

        [TestMethod]
        public void TelephoneIsdn()
        {
            Assert.AreEqual(_terminalTraceLogConfigView.TelephoneIsdn, "004412345677890");
        }

        [TestMethod]
        public void TelephonePstn()
        {
            Assert.AreEqual(_terminalTraceLogConfigView.TelephonePstn, "003312345677890");
        }

        [TestMethod]
        public void DestinationUrl()
        {
            Assert.AreEqual(_terminalTraceLogConfigView.DestinationUrl, "www.six-group.com");
        }

        [TestMethod]
        public void DestinationUrlPort()
        {
            Assert.AreEqual(_terminalTraceLogConfigView.DestinationUrlPort, "22222");
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