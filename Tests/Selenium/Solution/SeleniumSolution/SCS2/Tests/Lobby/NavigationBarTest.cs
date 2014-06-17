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
using Six.Scs.Tests.Selenium.Extension.TestObjects.Common;
using Six.Scs.Tests.Selenium.Extension.WebDriver;

namespace Six.Scs.Tests.Selenium.Tests.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class NavigationBarTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate();
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void Lobby()
        {
            Assert.IsTrue(NavigationBar.Lobby.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void Administration()
        {
            Assert.IsTrue(NavigationBar.Administration.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void Reporting()
        {
            Assert.IsTrue(NavigationBar.Reporting.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void Help()
        {
            Assert.IsTrue(NavigationBar.Help.Displayed);            
        }
    }
}