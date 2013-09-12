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
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class RecentElementsTest
    {
        private static RecentElements _recentElements;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _recentElements = new RecentElements();
            TestLauncher.Navigate("");
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MostRecentContainer()
        {
            Assert.IsTrue(_recentElements.MostRecent.Displayed);
        }
    }
}