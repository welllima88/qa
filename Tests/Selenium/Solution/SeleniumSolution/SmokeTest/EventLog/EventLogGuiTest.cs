using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.UI.Terminal.EventLog;
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
            Assert.IsNotNull(View.EventList, "at least Table with events displayed");
            // CollectionAssert.Contains(View.EventList, "at least List with");
        }

        [Test]
        public void EventTable()
        {
            Assert.That(View.EventTable.Displayed, "at least Table with events displayed");
            // CollectionAssert.Contains(View.EventList, "at least List with");
        }

        [Test]
        public void EventTypes()
        {
            Assert.IsNotNull(View.EventTypes);
            // Assert.That(View.EventTypes.Options.Contains("1000 - Startup"));
        }

        [Test]
        public void Export()
        {
            Assert.That(View.Export.Displayed, "number of time span options");
            // CollectionAssert.Contains(View.TimeSpan.Options.Contains("24h"));
        }

        [Test]
        public void SeverityList()
        {
            Assert.That(View.SeverityList.Options.Count() == 4, "number of severities options");
        }

        [Test]
        public void TimeSpan()
        {
            Assert.That(View.TimeSpan.Options.Count() == 5, "number of time span options");
            // CollectionAssert.Contains(View.TimeSpan.Options.Contains("24h"));
        }
    }
}