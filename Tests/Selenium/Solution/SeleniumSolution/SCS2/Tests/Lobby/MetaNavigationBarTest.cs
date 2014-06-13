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
using SIX.SCS.Tests.Selenium.Extension.Selenium;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common;

namespace SIX.SCS.Tests.Selenium.Tests.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class MetaNavigationBarTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate();
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void User()
        {
            Assert.IsTrue(MetaNavBar.User.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void Logout()
        {
            Assert.IsTrue(MetaNavBar.Logout.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void Languages()
        {
            Assert.IsTrue(MetaNavBar.Languages.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void LanguageGerman()
        {
            MetaNavBar.Languages.Click();
            Assert.IsTrue(MetaNavBar.Language("Deutsch").Enabled);
            MetaNavBar.Languages.Click();
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void LanguageEnglish()
        {
            MetaNavBar.Languages.Click();
            Assert.IsTrue(MetaNavBar.Language("English").Enabled);
            MetaNavBar.Languages.Click();
        }
    }
}