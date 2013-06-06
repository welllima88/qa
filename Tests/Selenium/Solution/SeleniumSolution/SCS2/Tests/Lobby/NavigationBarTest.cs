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

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Lobby
{
    /// <summary>
    /// be careful with menu expander because they prevent some actions and need special handling 
    /// </summary>
    [TestClass]
    public class NavigationBarTest
    {
        private static IWebDriverAdapter _driver;
        private static TestDirector _tb;
        private static TestObjects.Common.LobbyView _lobbyView;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup();
            _lobbyView = new TestObjects.Common.LobbyView(_driver);
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
            Assert.IsTrue(_lobbyView.NavigationBar.Lobby.Displayed);
        }

        [TestMethod]
        public void Administration()
        {
            Assert.IsTrue(_lobbyView.NavigationBar.Administration.Displayed);
        }

        [TestMethod]
        public void Reporting()
        {
            Assert.IsTrue(_lobbyView.NavigationBar.Reporting.Displayed);
        }

        [TestMethod]
        public void MoreMenu()
        {
            Assert.IsTrue(_lobbyView.NavigationBar.MoreMenu.Displayed);
        }

        [TestMethod]
        public void Help()
        {
            _lobbyView.NavigationBar.MoreMenu.Click(); //open more Menu
            Assert.IsTrue(_lobbyView.NavigationBar.Help.Displayed);
            _lobbyView.NavigationBar.MoreMenu.Click(); //close more Menu (also necessary for correct logoff)
        }

        [TestMethod]
        public void SystemInfo()
        {
            _lobbyView.NavigationBar.MoreMenu.Click(); //open more Menu
            Assert.IsTrue(_lobbyView.NavigationBar.SystemInfo.Enabled);
            _lobbyView.NavigationBar.MoreMenu.Click(); //close more Menu (also necessary for correct logoff)
        }
    }
}