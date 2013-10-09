using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Terminal
{
    [TestClass]
    public class TerminalCreateChooseArticleTest
    {
        private static TerminalCreate _terminalCreate;
        private static LobbyView _lobby;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _terminalCreate = new TerminalCreate();

            _lobby = new LobbyView();
        }

        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate("/Pages/Terminal/TerminalNew.aspx?CUSTOMERID=400805");
        }

        [TestMethod]
        public void CreateTerminalByArticleTreeSelect()
        {
            const string termType = "xentissimo";
            const string article = "xentissimo MOBILE WLAN, TCP/IP";

            _terminalCreate.TerminalChooser.Article = article;

            Assert.IsTrue(_terminalCreate.TerminalConfigCreate.TerminalType.Equals(termType));

            Assert.IsTrue(_lobby.Headline.Text.Contains(article));
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupIsCaseInsensitive()
        {
            _terminalCreate.TerminalChooser.ArticleLookup = "DaViNcI2 AuToNoM, tcp/IP";

            Assert.IsTrue(
                _terminalCreate.TerminalChooser.ArtikelList.Contains("davinci2 AUTONOM, TCP/IP (Internet) / 10773"));
            Assert.IsTrue(_terminalCreate.TerminalChooser.ArtikelList.Count > 0);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByUniqueNumber()
        {
            _terminalCreate.TerminalChooser.ArticleLookup = "10773";

            Assert.IsTrue(
                _terminalCreate.TerminalChooser.ArtikelList.Contains("davinci2 AUTONOM, TCP/IP (Internet) / 10773"));
            Assert.IsTrue(_terminalCreate.TerminalChooser.ArtikelList.Count == 1);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByTerminalType()
        {
            _terminalCreate.TerminalChooser.ArticleLookup = "davinci1";

            foreach (string articleEntry in _terminalCreate.TerminalChooser.ArtikelList)
            {
                Assert.IsTrue(articleEntry.StartsWith("davinci1"));
            }

            Assert.IsTrue(_terminalCreate.TerminalChooser.ArtikelList.Count > 0);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByNetType()
        {
            _terminalCreate.TerminalChooser.ArticleLookup = "TCP/IP (Internet)";

            foreach (string articleEntry in _terminalCreate.TerminalChooser.ArtikelList)
            {
                Assert.IsTrue(articleEntry.Contains("TCP/IP (Internet)"));
            }

            Assert.IsTrue(_terminalCreate.TerminalChooser.ArtikelList.Count > 0);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByTerminalSubType()
        {
            _terminalCreate.TerminalChooser.ArticleLookup = "AUTONOM";

            foreach (string articleEntry in _terminalCreate.TerminalChooser.ArtikelList)
            {
                Assert.IsTrue(articleEntry.Contains("AUTONOM"));
            }

            Assert.IsTrue(_terminalCreate.TerminalChooser.ArtikelList.Count > 0);
        }

        [TestMethod]
        public void CreateTerminalByArticleLookupByPartialUniqueNumber()
        {
            _terminalCreate.TerminalChooser.ArticleLookup = "1546";

            foreach (string articleEntry in _terminalCreate.TerminalChooser.ArtikelList)
            {
                Assert.IsTrue(articleEntry.Contains("1546"));
                Assert.IsTrue(articleEntry.StartsWith("xenta"));
                Assert.IsTrue(articleEntry.Contains("AUTONOM"));
            }

            Assert.IsTrue(_terminalCreate.TerminalChooser.ArtikelList.Count > 0);
        }
    }
}