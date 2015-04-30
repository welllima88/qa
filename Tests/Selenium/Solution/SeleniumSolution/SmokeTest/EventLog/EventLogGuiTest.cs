using System.Linq;
using NUnit.Framework;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.EventLog
{
    [TestFixture]
    public class EventLogGuiTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("TerminalLog?TerminalId=30092715");
        }

        [Test]
        public void EventList()
        {
            Assert.IsNotNull(View.Terminal.EventLog.View.EventList, "at least Table with events displayed");
            // CollectionAssert.Contains(View.EventList, "at least List with");
        }

        [Test]
        public void EventTable()
        {
            Assert.IsTrue(View.Terminal.EventLog.View.EventTable.Displayed, "at least Table with events displayed");
            // CollectionAssert.Contains(View.EventList, "at least List with");
        }

        [Test]
        public void EventTypes()
        {
            Assert.IsNotNull(View.Terminal.EventLog.View.EventTypes);
            // Assert.IsTrue(View.EventTypes.Options.Contains("1000 - Startup"));
        }

        [Test]
        public void Export()
        {
            Assert.IsTrue(View.Terminal.EventLog.View.Export.Displayed, "number of time span options");
            // CollectionAssert.Contains(View.TimeSpan.Options.Contains("24h"));
        }

        [Test]
        public void SeverityList()
        {
            Assert.IsTrue(View.Terminal.EventLog.View.SeverityList.Options.Count() == 4, "number of severities options");
        }

        [Test]
        public void TimeSpan()
        {
            Assert.IsTrue(View.Terminal.EventLog.View.TimeSpan.Options.Count() == 5, "number of time span options");
            // CollectionAssert.Contains(View.TimeSpan.Options.Contains("24h"));
        }
    }
}