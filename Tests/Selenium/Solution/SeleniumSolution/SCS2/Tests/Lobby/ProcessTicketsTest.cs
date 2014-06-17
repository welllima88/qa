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
    public class ProcessTicketsTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate();
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void ProcessTicketsContainer()
        {
            Assert.IsTrue(ProcessTickets.Container.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void NewestProcessTickets()
        {
            Assert.IsTrue(ProcessTickets.Newest.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void OldestProcessTickets()
        {
            Assert.IsTrue(ProcessTickets.Oldest.Displayed);
        }
    }
}