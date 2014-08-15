using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Terminal;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Terminal.ArticleChooser
{
    [TestClass]
    public class ArticleChooserLookupTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate(
                "TerminalArticleSelector/LocationTerminalNew/?LOCATIONID=e7fc5338-dff2-4556-866d-27b96d225a97");
        }

        [TestMethod]
        public void CreateTerminalByDirectArticleSelect()
        {
            const string termType = "xentissimo";
            const string article = "xentissimo MOBILE WLAN, TCP/IP";

            Selenium.Terminal.ArticleChooser.Article = article;

            Assert.IsTrue(ConfigCreate.TerminalType.Equals(termType));
            Assert.IsTrue(Lobby.Headline.Text.Contains(article));
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupIsCaseInsensitive()
        {
            Selenium.Terminal.ArticleChooser.ArticleFilter = "DaViNcI2 auTONoM, tCp/IP";
            var pattern = new Regex(" davinci2 .*AUTONOM, TCP/IP.*");

            foreach (string articleEntry in Selenium.Terminal.ArticleChooser.FilteredArtikelList)
            {
                StringAssert.Matches(articleEntry, pattern);
            }
            Assert.IsTrue(Selenium.Terminal.ArticleChooser.FilteredArtikelList.Count > 2);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByUniqueNumber()
        {
            Selenium.Terminal.ArticleChooser.ArticleFilter = "10773";

            CollectionAssert.Contains(Selenium.Terminal.ArticleChooser.FilteredArtikelList,
                "  davinci2 AUTONOM, TCP/IP (Internet) TCPIPEP2  10773");
            Assert.IsTrue(Selenium.Terminal.ArticleChooser.FilteredArtikelList.Count == 1);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByTerminalType()
        {
            Selenium.Terminal.ArticleChooser.ArticleFilter = "davinci1";
            var pattern = new Regex(" davinci1 .*");

            foreach (string articleEntry in Selenium.Terminal.ArticleChooser.FilteredArtikelList)
            {
                StringAssert.Matches(articleEntry, pattern);
            }

            Assert.IsTrue(Selenium.Terminal.ArticleChooser.FilteredArtikelList.Count > 2);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByNetType()
        {
            Selenium.Terminal.ArticleChooser.ArticleFilter = "TCP/IP (Internet)";
            var pattern = new Regex(@".*TCP/IP \(Internet\).*");

            foreach (string articleEntry in Selenium.Terminal.ArticleChooser.FilteredArtikelList)
            {
                StringAssert.Matches(articleEntry, pattern);
            }
            Assert.IsTrue(Selenium.Terminal.ArticleChooser.FilteredArtikelList.Count > 1);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByTerminalSubType()
        {
            Selenium.Terminal.ArticleChooser.ArticleFilter = "AUTONOM";
            var pattern = new Regex(".*AUTONOM.*");

            foreach (string articleEntry in Selenium.Terminal.ArticleChooser.FilteredArtikelList)
            {
                StringAssert.Matches(articleEntry, pattern);
            }

            Assert.IsTrue(Selenium.Terminal.ArticleChooser.FilteredArtikelList.Count > 0);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByPartialUniqueNumber()
        {
            Selenium.Terminal.ArticleChooser.ArticleFilter = "1546";
            var pattern = new Regex(" xenta AUTONOM.*1546.*");

            foreach (string articleEntry in Selenium.Terminal.ArticleChooser.FilteredArtikelList)
            {
                StringAssert.Matches(articleEntry, pattern);
            }

            Assert.IsTrue(Selenium.Terminal.ArticleChooser.FilteredArtikelList.Count > 2);
        }
    }
}