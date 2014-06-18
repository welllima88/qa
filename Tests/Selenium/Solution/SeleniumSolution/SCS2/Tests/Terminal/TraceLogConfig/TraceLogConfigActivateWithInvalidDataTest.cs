using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.TestObjects.Terminal.TraceLogConfig;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.Tests.Terminal.TraceLogConfig
{
    [TestClass]
    public class TraceLogConfigActivateWithInvalidDataTest
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
        }

        [TestMethod]
        public void SetDateInThePastFailed()
        {
            TerminalTraceLogConfigEdit.ActivatedUntil = "24.10.1920";

            TerminalTraceLogConfigEdit.Save.Click();

            Assert.AreEqual(TerminalTraceLogConfigView.ActivatedUntil, "24.10.1920");
        }

        [TestMethod]
        [Ignore]
        public void WihtEmptyParameterFailed()
        {
            // Assert.IsTrue(_terminalTraceLogConfig.Equals(this));
            // CollectionAssert.Contains(TerminalEventLog.EventList, "at least List with");
        }
    }
}