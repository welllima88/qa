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
        public void HelpLinkIsAvialable()
        {
            Assert.AreEqual("SCS2 Hilfe", HelpNavigation.ScsHelp.Text);
        }

        [Test]
        [Category("Help")]
        public void ReleaseNotesLinkIsAvailable()
        {
            Assert.AreEqual("Releasenotes", HelpNavigation.ReleaseNotes.Text);
        }

        [Test]
        [Category("Help")]
        public void Scs2LinkIsAvailable()
        {
            Assert.AreEqual("SCS2 Hilfe", HelpNavigation.Scs2.Text);
        }
    }
}