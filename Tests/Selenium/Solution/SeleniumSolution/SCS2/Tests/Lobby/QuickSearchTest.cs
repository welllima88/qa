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
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class QuickSearchTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestLauncher.Navigate();
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void SearchField()
        {
            Assert.IsTrue(QuickSearch.SearchField.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void SearchButton()
        {
            Assert.IsTrue(QuickSearch.SearchButton.Displayed);
        }
    }
}