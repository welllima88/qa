using NUnit.Framework;
using Six.Scs.Test.UI.Terminal.Dashboard;
using Six.Scs.Test.UI.Terminal.Dashboard.Portlets;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Terminal
{
    [TestFixture]
    public class FoMessage
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("TerminalDashboard/?TerminalId=30092755");

            PortletViewBase.AllHasBeenLoaded();
            Activity.FoMessages.Click();
        }

        [Test]
        public void Date()
        {
            Assert.That(UI.Terminal.FoMessages.FoMessage.Date, Is.Not.Empty);
        }

        [Test]
        public void Id()
        {
            Assert.That(UI.Terminal.FoMessages.FoMessage.Id, Is.Not.Empty);
        }

        [Test]
        public void JobId()
        {
            Assert.That(UI.Terminal.FoMessages.FoMessage.JobId, Is.Not.Empty);
            Assert.That(UI.Terminal.FoMessages.FoMessage.JobId, Is.Not.EqualTo("0"));
        }

        [Test]
        public void ResponseCode()
        {
            Assert.That(UI.Terminal.FoMessages.FoMessage.ResponseCode, Is.Not.Empty);
        }

        [Test]
        public void TerminalId()
        {
            Assert.That(UI.Terminal.FoMessages.FoMessage.TerminalId, Is.Not.Empty);
        }

        [Test]
        public void UserName()
        {
            Assert.That(UI.Terminal.FoMessages.FoMessage.UserName, Is.Not.Empty);
        }
    }
}