using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Terminal;

namespace Six.Scs.QA.Selenium.SmokeTest.Article
{
    [TestFixture]
    public class ChooserLookupTest
    {
        [TestFixtureSetUp]
        public void TestInit()
        {
            TestDirector.Navigate("Customer/?CustomerId=1");
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