using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Help;

namespace Six.Scs.QA.Selenium.SmokeTest.Help
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class HelpTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();

            NavigationBar.Help.Click();
        }

        [Test]
        [Category("Help")]
        public void HelpIsAvialable()
        {
            Assert.AreEqual("Startseite", HelpNavigation.Help.Text);
        }

        [Test]
        [Category("Help")]
        public void Scs2HelpLinkIsAvailable()
        {
            Assert.AreEqual("SCS2", HelpNavigation.Scs2.Text);
        }

        [Test]
        [Category("Help")]
        public void ScsHelpLinkIsAvailable()
        {
            Assert.AreEqual("SCS", HelpNavigation.Scs.Text);
        }
    }
}