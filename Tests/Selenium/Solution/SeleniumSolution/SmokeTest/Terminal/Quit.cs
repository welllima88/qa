using NUnit.Framework;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Terminal
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
            Assert.That(Test.View.Terminal.Quit.Quit.InstallationOnSiteRequested, Is.False);
        }

        [Test]
        [Category("Terminal Quit")]
        public void Reason()
        {
            Assert.That(Test.View.Terminal.Quit.Quit.Reason, Is.Not.Null);
            Assert.That(Test.View.Terminal.Quit.Quit.Reason, Is.Empty);
        }

        [Test]
        [Category("Terminal Quit")]
        public void State()
        {
            Assert.That(Test.View.Terminal.Quit.Quit.State, Is.Not.Empty);
        }
    }
}