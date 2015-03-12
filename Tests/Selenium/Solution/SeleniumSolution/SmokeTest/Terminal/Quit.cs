using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets;

namespace Six.Scs.QA.Selenium.SmokeTest.Terminal
{
    [TestFixture]
    [Category("Terminal Quit")]
    public class Quit
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("TerminalDashboard/?TerminalId=30092755");
            SalesContract.Quit.Click();
        }

        [Test]
        [Category("Terminal Quit")]
        public void Delivery()
        {
            Assert.That(Selenium.Terminal.Quit.Quit.InstallationOnSiteRequested, Is.False);
        }

        [Test]
        [Category("Terminal Quit")]
        public void Reason()
        {
            Assert.That(Selenium.Terminal.Quit.Quit.Reason, Is.Not.Null);
            Assert.That(Selenium.Terminal.Quit.Quit.Reason, Is.Empty);
        }

        [Test]
        [Category("Terminal Quit")]
        public void State()
        {
            Assert.That(Selenium.Terminal.Quit.Quit.State, Is.Not.Empty);
        }
    }
}