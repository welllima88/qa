using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Terminal.TraceLogConfig;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Terminal.TraceLogConfig
{
    [TestFixture]
    public class TraceLogConfigDeactivateTest
    {
        [TestFixtureSetUp]
        public static void TestInit()
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

        [Test]
        public void ActivatedUntil()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.ActivatedUntil, "24.12.2022");
        }

        [Test]
        public void DestinationAddress()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.DestinationAddress, "111.111.111.555");
        }

        [Test]
        public void DestinationPort()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.DestinationPort, "11115");
        }

        [Test]
        public void DestinationUrl()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.DestinationUrl, "www.six-group.com");
        }

        [Test]
        public void DestinationUrlPort()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.DestinationUrlPort, "22225");
            // Assert.IsTrue(_terminalTraceLogConfig.Equals(this));
            // CollectionAssert.Contains(TerminalEventLog.EventList, "at least List with");
        }

        [Test]
        public void Medium()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.Medium, "Local");
        }

        [Test]
        public void Parameter()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.Parameter, "Parameter");
        }

        [Test]
        public void TelephoneIsdn()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.TelephoneIsdn, "004412345677890");
        }

        [Test]
        public void TelephonePstn()
        {
            Assert.AreEqual(TerminalTraceLogConfigView.TelephonePstn, "003312345677890");
        }
    }
}