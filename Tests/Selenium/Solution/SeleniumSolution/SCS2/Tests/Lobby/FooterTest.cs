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
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Lobby
{
    /// <summary>
    /// be careful with menu expander because they prevent some actions and need special handling 
    /// </summary>
    [TestClass]
    public class FooterTest
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
        public void Copyright()
        {
            Assert.IsTrue(_lobbyView.Footer.Copyright.Displayed);
        }

        [TestMethod]
        public void Disclaimer()
        {
            Assert.IsTrue(_lobbyView.Footer.Disclaimer.Displayed);
        }

        [TestMethod]
        public void Feedback()
        {
            Assert.IsTrue(_lobbyView.Footer.Feedback.Displayed);
        }

        [TestMethod]
        public void PrintPage()
        {
            Assert.IsTrue(_lobbyView.Footer.PrintPage.Displayed);
        }

        [TestMethod]
        public void ScrollUp()
        {
            Assert.IsTrue(_lobbyView.Footer.ScrollUp.Displayed);
        }
    }
}