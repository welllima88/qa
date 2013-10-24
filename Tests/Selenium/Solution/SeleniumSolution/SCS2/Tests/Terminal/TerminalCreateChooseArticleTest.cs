using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Terminal
{
    [TestClass]
    public class TerminalCreateChooseArticleTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Pages/Terminal/TerminalNew.aspx?CUSTOMERID=400805");
        }

        [TestMethod]
        public void CreateTerminalByArticleTreeSelect()
        {
            const string termType = "xentissimo";
            const string article = "xentissimo MOBILE WLAN, TCP/IP";

            TerminalCreate.TerminalChooser.Article = article;

            Assert.IsTrue(TerminalCreate.TerminalConfigCreate.TerminalType.Equals(termType));

            Assert.IsTrue(LobbyView.Headline.Text.Contains(article));
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupIsCaseInsensitive()
        {
            TerminalCreate.TerminalChooser.ArticleLookup = "DaViNcI2 AuToNoM, tcp/IP";

            Assert.IsTrue(
                TerminalCreate.TerminalChooser.ArtikelList.Contains("davinci2 AUTONOM, TCP/IP (Internet) / 10773"));
            Assert.IsTrue(TerminalCreate.TerminalChooser.ArtikelList.Count > 0);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByUniqueNumber()
        {
            TerminalCreate.TerminalChooser.ArticleLookup = "10773";

            Assert.IsTrue(
                TerminalCreate.TerminalChooser.ArtikelList.Contains("davinci2 AUTONOM, TCP/IP (Internet) / 10773"));
            Assert.IsTrue(TerminalCreate.TerminalChooser.ArtikelList.Count == 1);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByTerminalType()
        {
            TerminalCreate.TerminalChooser.ArticleLookup = "davinci1";

            foreach (string articleEntry in TerminalCreate.TerminalChooser.ArtikelList)
            {
                Assert.IsTrue(articleEntry.StartsWith("davinci1"));
            }

            Assert.IsTrue(TerminalCreate.TerminalChooser.ArtikelList.Count > 0);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByNetType()
        {
            TerminalCreate.TerminalChooser.ArticleLookup = "TCP/IP (Internet)";

            foreach (string articleEntry in TerminalCreate.TerminalChooser.ArtikelList)
            {
                Assert.IsTrue(articleEntry.Contains("TCP/IP (Internet)"));
            }

            Assert.IsTrue(TerminalCreate.TerminalChooser.ArtikelList.Count > 0);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByTerminalSubType()
        {
            TerminalCreate.TerminalChooser.ArticleLookup = "AUTONOM";

            foreach (string articleEntry in TerminalCreate.TerminalChooser.ArtikelList)
            {
                Assert.IsTrue(articleEntry.Contains("AUTONOM"));
            }

            Assert.IsTrue(TerminalCreate.TerminalChooser.ArtikelList.Count > 0);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByPartialUniqueNumber()
        {
            TerminalCreate.TerminalChooser.ArticleLookup = "1546";

            foreach (string articleEntry in TerminalCreate.TerminalChooser.ArtikelList)
            {
                Assert.IsTrue(articleEntry.Contains("1546"));
                Assert.IsTrue(articleEntry.StartsWith("xenta"));
                Assert.IsTrue(articleEntry.Contains("AUTONOM"));
            }

            Assert.IsTrue(TerminalCreate.TerminalChooser.ArtikelList.Count > 0);
        }
    }
}