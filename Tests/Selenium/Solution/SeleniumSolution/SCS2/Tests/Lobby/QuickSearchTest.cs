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
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class QuickSearchTest
    {
        private static LobbyView _lobbyView;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _lobbyView = new LobbyView();
            TestLauncher.Navigate("");
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void SearchField()
        {
            Assert.IsTrue(_lobbyView.QuickSearch.SearchField.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void SearchButton()
        {
            Assert.IsTrue(_lobbyView.QuickSearch.SearchButton.Displayed);
        }
    }
}