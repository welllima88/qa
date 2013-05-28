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
    public class MetaNavigationBarTest
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
        public void User()
        {
            Assert.IsTrue(_lobby.MetaNavBar.User.Displayed);
        }

        [TestMethod]
        public void Logout()
        {
            Assert.IsTrue(_lobby.MetaNavBar.Logout.Displayed);
        }

        [TestMethod]
        public void Languages()
        {
            Assert.IsTrue(_lobby.MetaNavBar.Languages.Displayed);
        }

        [TestMethod]
        public void LanguageGerman()
        {
            _lobby.MetaNavBar.Languages.Click();
            Assert.IsTrue(_lobby.MetaNavBar.Language("Deutsch").Displayed);
            Assert.IsTrue(_lobby.MetaNavBar.Language("English").Enabled);
            _lobby.MetaNavBar.Languages.Click();
        }

        [TestMethod]
        public void LanguageEnglish()
        {
            _lobby.MetaNavBar.Languages.Click();
            Assert.IsTrue(_lobby.MetaNavBar.Language("English").Displayed); //Enabled, if displayed is making problems
            _lobby.MetaNavBar.Languages.Click();
        }
    }
}