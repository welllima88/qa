using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Help;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Help
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

            NavigationBar.MoreMenu.Click();
            NavigationBar.Help.Click();
        }

        [TestMethod]
        [TestCategory("LobbyCheck"), TestCategory("Help")]
        public void HelpIsAvialable()
        {
            Assert.IsTrue(HelpNavigation.Help.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck"), TestCategory("Help")]
        public void ScsHelpLinkIsAvailable()
        {
            Assert.IsTrue(HelpNavigation.Scs.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck"), TestCategory("Help")]
        public void Scs2HelpLinkIsAvailable()
        {
            Assert.IsTrue(HelpNavigation.Scs2.Displayed);
        }
    }
}