using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.Tests.Selenium.Extension.Selenium;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Terminal;

namespace SIX.SCS.Tests.Selenium.Tests.Terminal.ArticleChooser
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

            TerminalChooser.Article = article;

            Assert.IsTrue(TerminalConfigCreate.TerminalType.Equals(termType));
            Assert.IsTrue(LobbyView.Headline.Text.Contains(article));
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupIsCaseInsensitive()
        {
            TerminalChooser.ArticleFilter = "DaViNcI2 auTONoM, tCp/IP";
            var pattern = new Regex(" davinci2 .*AUTONOM, TCP/IP.*");

            foreach (string articleEntry in TerminalChooser.FilteredArtikelList)
            {
                StringAssert.Matches(articleEntry, pattern);
            }
            Assert.IsTrue(TerminalChooser.FilteredArtikelList.Count > 2);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByUniqueNumber()
        {
            TerminalChooser.ArticleFilter = "10773";

            CollectionAssert.Contains(TerminalChooser.FilteredArtikelList,
                "  davinci2 AUTONOM, TCP/IP (Internet) TCPIPEP2  10773");
            Assert.IsTrue(TerminalChooser.FilteredArtikelList.Count == 1);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByTerminalType()
        {
            TerminalChooser.ArticleFilter = "davinci1";
            var pattern = new Regex(" davinci1 .*");

            foreach (string articleEntry in TerminalChooser.FilteredArtikelList)
            {
                StringAssert.Matches(articleEntry, pattern);
            }

            Assert.IsTrue(TerminalChooser.FilteredArtikelList.Count > 2);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByNetType()
        {
            TerminalChooser.ArticleFilter = "TCP/IP (Internet)";
            var pattern = new Regex(@".*TCP/IP \(Internet\).*");

            foreach (string articleEntry in TerminalChooser.FilteredArtikelList)
            {
                StringAssert.Matches(articleEntry, pattern);
            }
            Assert.IsTrue(TerminalChooser.FilteredArtikelList.Count > 1);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByTerminalSubType()
        {
            TerminalChooser.ArticleFilter = "AUTONOM";
            var pattern = new Regex(".*AUTONOM.*");

            foreach (string articleEntry in TerminalChooser.FilteredArtikelList)
            {
                StringAssert.Matches(articleEntry, pattern);
            }

            Assert.IsTrue(TerminalChooser.FilteredArtikelList.Count > 0);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByPartialUniqueNumber()
        {
            TerminalChooser.ArticleFilter = "1546";
            var pattern = new Regex(" xenta AUTONOM.*1546.*");

            foreach (string articleEntry in TerminalChooser.FilteredArtikelList)
            {
                StringAssert.Matches(articleEntry, pattern);
            }

            Assert.IsTrue(TerminalChooser.FilteredArtikelList.Count > 2);
        }
    }
}