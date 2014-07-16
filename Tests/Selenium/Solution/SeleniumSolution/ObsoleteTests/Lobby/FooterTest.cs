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
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class FooterTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate();
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void Copyright()
        {
            Assert.IsTrue(Footer.Copyright.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void Disclaimer()
        {
            Assert.IsTrue(Footer.Disclaimer.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void Feedback()
        {
            Assert.IsTrue(Footer.Feedback.Displayed);
        }
    }
}