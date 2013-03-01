/* RegExp
 * http://openbook.galileocomputing.de/csharp/kap17.htm
 * 
 * Strings als Parameter:
 * http://openbook.galileocomputing.de/csharp/kap19.htm
 * "Kundenname" statt k.Name Feld-Bezeichnung ist viel flexibler für zukünftige Struktur
 *  
 * http://openbook.galileocomputing.de/csharp/kap31.htm#t25
 * 
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SeleniumTests
{
    /// <summary>
    /// be careful with menu expander because they prevent some actions and need special handling 
    /// </summary>
    [TestClass]
    public class LobbyTest
    {
        private static IWebDriver _driver;
        private static TestDirector _tb;
        private static Lobby _lobby;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup();
            _lobby = new Lobby(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _tb.ShutDownTest();
        }

        [TestMethod]
        public void CheckLobbyMenu()
        {
        }

        [TestMethod]
        public void CheckFooter()
        {
            Assert.IsTrue(_lobby.Footer.Copyright.Displayed);
            Assert.IsTrue(_lobby.Footer.Disclaimer.Displayed);
            Assert.IsTrue(_lobby.Footer.Feedback.Displayed);
            Assert.IsTrue(_lobby.Footer.PrintPage.Displayed);
            Assert.IsTrue(_lobby.Footer.ScrollUp.Displayed);
        }

        [TestMethod]
        public void CheckNavBar()
        {
            Assert.IsTrue(_lobby.NavigationBar.Lobby.Displayed);
            Assert.IsTrue(_lobby.NavigationBar.Administration.Displayed);
            Assert.IsTrue(_lobby.NavigationBar.Reporting.Displayed);

            Assert.IsTrue(_lobby.NavigationBar.MoreMenu.Displayed);
            _lobby.NavigationBar.MoreMenu.Click(); //open more Menu
            Assert.IsTrue(_lobby.NavigationBar.Help.Displayed);
            Assert.IsTrue(_lobby.NavigationBar.SystemInfo.Displayed);
            _lobby.NavigationBar.MoreMenu.Click(); //close more Menu (also necessary for correct logoff)
        }

        [TestMethod]
        public void CheckMetaNavBar()
        {
            Assert.IsTrue(_lobby.MetaNavBar.User.Displayed);
            Assert.IsTrue(_lobby.MetaNavBar.Logout.Displayed);
            Assert.IsTrue(_lobby.MetaNavBar.Languages.Displayed);

            _lobby.MetaNavBar.Languages.Click();
            Assert.IsTrue(_lobby.MetaNavBar.Language("Deutsch").Displayed);
            Assert.IsTrue(_lobby.MetaNavBar.Language("English").Displayed);
            _lobby.MetaNavBar.Languages.Click();
        }

        [TestMethod]
        public void CheckApplicationInfo()
        {
            Assert.IsTrue(_lobby.ApplicationInfo.ApplicationName.Displayed);
            Assert.IsTrue(_lobby.ApplicationInfo.Environment.Displayed);
        }

        [TestMethod]
        public void CheckRecentElements()
        {
            Assert.IsTrue(_lobby.RecentElements.MostRecent.Displayed);
            Assert.IsTrue(_lobby.RecentElements.Elements.Count > 0);
        }

        [TestMethod]
        public void CheckRecentMassJobs()
        {
            Assert.IsTrue(_lobby.RecentMassmutations.MostRecent.Displayed);
            Assert.IsTrue(_lobby.RecentMassmutations.Elements.Count > 0);
        }
    }
}