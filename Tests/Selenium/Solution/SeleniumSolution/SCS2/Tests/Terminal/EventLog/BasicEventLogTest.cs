using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.EventLog;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Terminal.EventLog
{
    [TestClass]
    public class BasicEventLogTest
    {
        private static TerminalEventLog _terminalEventLog;
        private static ScsPlatinTestDirector _tb;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _terminalEventLog = new TerminalEventLog();
        }

        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate("/EP2TerminalLog?TerminalId=30093271");
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            //after last test-method finished
            _tb.ShutDownBrowser();
        }

        [TestMethod]
        public void CheckEventTable()
        {
            Assert.IsTrue(_terminalEventLog.EventTable.Displayed, "at least Table with events displayed");
            // CollectionAssert.Contains(_terminalEventLog.EventList, "at least List with");
        }

        [TestMethod]
        public void CheckEventList()
        {
            Assert.IsNotNull(_terminalEventLog.EventList, "at least Table with events displayed");
            // CollectionAssert.Contains(_terminalEventLog.EventList, "at least List with");
        }

        [TestMethod]
        public void CheckEventTypes()
        {
            Assert.IsTrue(_terminalEventLog.EventTypes.Options.Count > 0, "at least List with");
            // Assert.IsTrue(_terminalEventLog.EventTypes.Options.Contains("1000 - Startup"));
        }

        [TestMethod]
        public void CheckSeverityList()
        {
            Assert.IsTrue(_terminalEventLog.SeverityList.Options.Count == 4, "number of severities options");
        }

        [TestMethod]
        public void CheckTimeSpan()
        {
            Assert.IsTrue(_terminalEventLog.TimeSpan.Options.Count == 4, "number of time span options");
            // CollectionAssert.Contains(_terminalEventLog.TimeSpan.Options.Contains("24h"));
        }
    }
}