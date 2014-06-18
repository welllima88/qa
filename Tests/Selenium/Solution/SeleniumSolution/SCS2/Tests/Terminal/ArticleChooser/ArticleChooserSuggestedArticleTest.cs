using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.TestObjects.Terminal;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.Tests.Terminal.ArticleChooser
{
    [TestClass]
    public class ArticleChooserSuggestedArticleTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate(
                "TerminalArticleSelector/LocationTerminalNew/?LOCATIONID=e7fc5338-dff2-4556-866d-27b96d225a97");
        }

        [TestMethod]
        public void SuggestedListHasEntries()
        {
            Assert.IsTrue(TerminalChooser.SuggestedArtikelList.Count > 2);
        }

        [TestMethod]
        public void SuggestedListHasConcreteEntry()
        {
            CollectionAssert.Contains(TerminalChooser.SuggestedArtikelList,
                "  xentissimo MOBILE WLAN, TCP/IP TCPIPEP2  15401");
        }
    }
}