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
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SeleniumTests
{
    /// <summary>
    /// be careful with menu expander because they prevent some actions and need special handling 
    /// </summary>
    [TestClass]
    public class NavigationBarTest
    {
        private static IWebDriverAdapter _driver;
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
        public void Lobby()
        {
            Assert.IsTrue(_lobby.NavigationBar.Lobby.Displayed);
        }

        [TestMethod]
        public void Administration()
        {
            Assert.IsTrue(_lobby.NavigationBar.Administration.Displayed);
        }

        [TestMethod]
        public void Reporting()
        {
            Assert.IsTrue(_lobby.NavigationBar.Reporting.Displayed);
        }

        [TestMethod]
        public void MoreMenu()
        {
            Assert.IsTrue(_lobby.NavigationBar.MoreMenu.Displayed);
        }

        [TestMethod]
        public void Help()
        {
            _lobby.NavigationBar.MoreMenu.Click(); //open more Menu
            Assert.IsTrue(_lobby.NavigationBar.Help.Displayed);
            _lobby.NavigationBar.MoreMenu.Click(); //close more Menu (also necessary for correct logoff)
        }

        [TestMethod]
        public void SystemInfo()
        {
            _lobby.NavigationBar.MoreMenu.Click(); //open more Menu
            Assert.IsTrue(_lobby.NavigationBar.SystemInfo.Enabled);
            _lobby.NavigationBar.MoreMenu.Click(); //close more Menu (also necessary for correct logoff)
        }
    }
}