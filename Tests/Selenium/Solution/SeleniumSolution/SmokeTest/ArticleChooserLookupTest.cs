using NUnit.Framework;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Terminal;

namespace Six.Scs.QA.Selenium.SmokeTest
{
    [TestFixture]
    public class ArticleChooserLookupTest
    {
        [TestFixtureSetUp]
        public void TestInit()
        {
            TestDirector.Navigate("Customer/?CustomerId=1");
            CustomerMenu.TerminalCreate.Click();
        }

        [Test]
        public void DirectArticleSelect()
        {
            const string termType = "xentissimo";
            const string article = "xentissimo MOBILE WLAN, TCP/IP";

            ArticleChooser.Filter = " ";
            ArticleChooser.Filter = "";
            ArticleChooser.Select = article;

            Assert.IsTrue(ConfigCreate.TerminalType.Equals(termType));
            Assert.IsTrue(Common.Lobby.Headline.Text.Contains(article));

            // get to initial point
            CustomerMenu.TerminalCreate.Click();
        }

        [Test]
        public void LookupByArticleNumber()
        {
            ArticleChooser.Filter = "10773";

            CollectionAssert.Contains(ArticleChooser.FilteredArtikelList,
                "davinci2 AUTONOM, TCP/IP (Internet)");
            Assert.IsTrue(ArticleChooser.FilteredArtikelList.Count == 1);
        }

        [Test]
        public void LookupByNetType()
        {
            ArticleChooser.Filter = "TCP/IP (Internet)";
            const string pattern = @".*TCP/IP \(Internet\).*";

            foreach (string articleEntry in ArticleChooser.FilteredArtikelList)
            {
                StringAssert.IsMatch(pattern, articleEntry);
            }
            Assert.IsTrue(ArticleChooser.FilteredArtikelList.Count > 1);
        }

        [Test]
        public void LookupByPartialArticleNumber()
        {
            ArticleChooser.Filter = "1546";
            const string pattern = "xenta AUTONOM.*";

            foreach (string articleEntry in ArticleChooser.FilteredArtikelList)
            {
                StringAssert.IsMatch(pattern, articleEntry);
            }

            Assert.IsTrue(ArticleChooser.FilteredArtikelList.Count > 2);
        }

        [Test]
        public void LookupByTerminalSubType()
        {
            ArticleChooser.Filter = "AUTONOM";
            const string pattern = ".*AUTONOM.*";

            foreach (string articleEntry in ArticleChooser.FilteredArtikelList)
            {
                StringAssert.IsMatch(pattern, articleEntry);
            }

            Assert.IsTrue(ArticleChooser.FilteredArtikelList.Count > 0);
        }

        [Test]
        public void LookupByTerminalType()
        {
            ArticleChooser.Filter = "yoximo Mobile";
            const string pattern = "yoximo MOBILE .*";

            foreach (string articleEntry in ArticleChooser.FilteredArtikelList)
            {
                StringAssert.IsMatch(pattern, articleEntry);
            }

            Assert.IsTrue(ArticleChooser.FilteredArtikelList.Count > 2);
        }

        [Test]
        public void LookupIsCaseInsensitive()
        {
            ArticleChooser.Filter = "DaViNcI2 auTONoM, tCp/IP";
            const string pattern = "davinci2.*AUTONOM, TCP/IP";

            foreach (string articleEntry in ArticleChooser.FilteredArtikelList)
            {
                StringAssert.IsMatch(pattern, articleEntry);
            }
            Assert.IsTrue(ArticleChooser.FilteredArtikelList.Count > 2);
        }
    }
}