using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Help;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Help
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class HelpTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate();

            NavigationBar.Help.Click();
        }

        [TestMethod]
        [TestCategory("Help")]
        public void HelpIsAvialable()
        {
            Assert.AreEqual("Startseite", Navigation.ScsHelp.Text);
        }

        [TestMethod]
        [TestCategory("Help")]
        public void ScsHelpLinkIsAvailable()
        {
            Assert.AreEqual("SCS", Navigation.ReleaseNotes.Text);
        }

        [TestMethod]
        [TestCategory("Help")]
        public void Scs2HelpLinkIsAvailable()
        {
            Assert.AreEqual("SCS2", Navigation.Scs2.Text);
        }
    }
}