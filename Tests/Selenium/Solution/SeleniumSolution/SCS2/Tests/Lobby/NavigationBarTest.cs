﻿/* RegExp
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
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class NavigationBarTest
    {
        private static IWebDriverAdapter _driver;
        private static TestDirector _tb;
        private static LobbyView _lobbyView;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup();
            _lobbyView = new LobbyView(_driver);
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
        [TestCategory("LobbyCheck")]
        public void Lobby()
        {
            Assert.IsTrue(_lobbyView.NavigationBar.Lobby.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void Administration()
        {
            Assert.IsTrue(_lobbyView.NavigationBar.Administration.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void Reporting()
        {
            Assert.IsTrue(_lobbyView.NavigationBar.Reporting.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MoreMenu()
        {
            Assert.IsTrue(_lobbyView.NavigationBar.MoreMenu.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void Help()
        {
            // _lobbyView.NavigationBar.MoreMenu.Click(); //open more Menu
            Assert.IsTrue(_lobbyView.NavigationBar.Help.Enabled);
            // _lobbyView.NavigationBar.MoreMenu.Click(); //close more Menu (also necessary for correct logoff)
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void SystemInfo()
        {
            // _lobbyView.NavigationBar.MoreMenu.Click(); //open more Menu
            Assert.IsTrue(_lobbyView.NavigationBar.SystemInfo.Enabled); // workaround: enabled instead of displayed
            // _lobbyView.NavigationBar.MoreMenu.Click(); //close more Menu (also necessary for correct logoff)
        }
    }
}