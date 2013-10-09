using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.EventLog;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Terminal.EventLog
{
    [TestClass]
    public class EventLogGuiTest
    {
        private static TerminalEventLog _terminalEventLog;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _terminalEventLog = new TerminalEventLog();
            TestLauncher.Navigate("/TerminalLog?TerminalId=30092715");
        }

        [TestMethod]
        public void EventTable()
        {
            Assert.IsTrue(_terminalEventLog.EventTable.Displayed, "at least Table with events displayed");
            // CollectionAssert.Contains(_terminalEventLog.EventList, "at least List with");
        }

        [TestMethod]
        public void EventList()
        {
            Assert.IsNotNull(_terminalEventLog.EventList, "at least Table with events displayed");
            // CollectionAssert.Contains(_terminalEventLog.EventList, "at least List with");
        }

        [TestMethod]
        public void EventTypes()
        {
            Assert.IsTrue(_terminalEventLog.EventTypes.Options.Count > 0, "at least List with");
            // Assert.IsTrue(_terminalEventLog.EventTypes.Options.Contains("1000 - Startup"));
        }

        [TestMethod]
        public void SeverityList()
        {
            Assert.IsTrue(_terminalEventLog.SeverityList.Options.Count == 4, "number of severities options");
        }

        [TestMethod]
        public void TimeSpan()
        {
            Assert.IsTrue(_terminalEventLog.TimeSpan.Options.Count == 4, "number of time span options");
            // CollectionAssert.Contains(_terminalEventLog.TimeSpan.Options.Contains("24h"));
        }

        [TestMethod]
        public void Export()
        {
            Assert.IsTrue(_terminalEventLog.Export.Displayed, "number of time span options");
            // CollectionAssert.Contains(_terminalEventLog.TimeSpan.Options.Contains("24h"));
        }
    }
}