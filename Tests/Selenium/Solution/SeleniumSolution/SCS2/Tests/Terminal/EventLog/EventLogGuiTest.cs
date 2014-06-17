using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Terminal.EventLog;
using Six.Scs.Tests.Selenium.Extension.WebDriver;

namespace Six.Scs.Tests.Selenium.Tests.Terminal.EventLog
{
    [TestClass]
    public class EventLogGuiTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("TerminalLog?TerminalId=30092715");
        }

        [TestMethod]
        public void EventTable()
        {
            Assert.IsTrue(TerminalEventLog.EventTable.Displayed, "at least Table with events displayed");
            // CollectionAssert.Contains(TerminalEventLog.EventList, "at least List with");
        }

        [TestMethod]
        public void EventList()
        {
            Assert.IsNotNull(TerminalEventLog.EventList, "at least Table with events displayed");
            // CollectionAssert.Contains(TerminalEventLog.EventList, "at least List with");
        }

        [TestMethod]
        public void EventTypes()
        {
            Assert.IsTrue(TerminalEventLog.EventTypes.Options.Count > 0, "at least List with");
            // Assert.IsTrue(TerminalEventLog.EventTypes.Options.Contains("1000 - Startup"));
        }

        [TestMethod]
        public void SeverityList()
        {
            Assert.IsTrue(TerminalEventLog.SeverityList.Options.Count == 4, "number of severities options");
        }

        [TestMethod]
        public void TimeSpan()
        {
            Assert.IsTrue(TerminalEventLog.TimeSpan.Options.Count == 4, "number of time span options");
            // CollectionAssert.Contains(TerminalEventLog.TimeSpan.Options.Contains("24h"));
        }

        [TestMethod]
        public void Export()
        {
            Assert.IsTrue(TerminalEventLog.Export.Displayed, "number of time span options");
            // CollectionAssert.Contains(TerminalEventLog.TimeSpan.Options.Contains("24h"));
        }
    }
}