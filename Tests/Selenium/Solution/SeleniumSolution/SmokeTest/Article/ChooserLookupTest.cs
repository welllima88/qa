using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.View.Common.Menu;
using Six.Scs.Test.View.Terminal;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Article
{
    [TestFixture]
    public class ChooserLookupTest
    {
        [TestFixtureSetUp]
        public void TestInit()
        {
            TestDirector.Navigate("Location?LocationId=261a0d6e-8136-4b48-95f4-bfcb986a142c");
            LocationMenu.TerminalCreate.Click();
        }

        [Test]
        public void LookupByArticleNumber()
        {
            ArticleChooser.Filter = "10773";

            CollectionAssert.Contains(ArticleChooser.FilteredArtikelList,
                "davinci2 AUTONOM, TCP/IP (Internet)");
            Assert.That(ArticleChooser.FilteredArtikelList.Count() == 1);
        }

        [Test]
        public void LookupByNetType()
        {
            ArticleChooser.Filter = "TCP/IP (Internet)";
            const string pattern = @".*TCP/IP \(Internet\).*";

            foreach (var articleEntry in ArticleChooser.FilteredArtikelList)
            {
                StringAssert.IsMatch(pattern, articleEntry);
            }
            Assert.That(ArticleChooser.FilteredArtikelList.Count() > 1);
        }

        [Test]
        public void LookupByPartialArticleNumber()
        {
            ArticleChooser.Filter = "1546";
            const string pattern = "xenta AUTONOM.*";

            foreach (var articleEntry in ArticleChooser.FilteredArtikelList)
            {
                StringAssert.IsMatch(pattern, articleEntry);
            }

            Assert.That(ArticleChooser.FilteredArtikelList.Count() > 2);
        }

        [Test]
        public void LookupByTerminalSubType()
        {
            ArticleChooser.Filter = "AUTONOM";
            const string pattern = ".*AUTONOM.*";

            foreach (var articleEntry in ArticleChooser.FilteredArtikelList)
            {
                StringAssert.IsMatch(pattern, articleEntry);
            }

            Assert.That(ArticleChooser.FilteredArtikelList.Any());
        }

        [Test]
        public void LookupByTerminalType()
        {
            ArticleChooser.Filter = "yoximo Mobile";
            const string pattern = "yoximo MOBILE .*";

            foreach (var articleEntry in ArticleChooser.FilteredArtikelList)
            {
                StringAssert.IsMatch(pattern, articleEntry);
            }

            Assert.That(ArticleChooser.FilteredArtikelList.Count() > 2);
        }

        [Test]
        public void LookupIsCaseInsensitive()
        {
            ArticleChooser.Filter = "DaViNcI2 auTONoM, tCp/IP";
            const string pattern = "davinci2.*AUTONOM, TCP/IP";

            foreach (var articleEntry in ArticleChooser.FilteredArtikelList)
            {
                StringAssert.IsMatch(pattern, articleEntry);
            }
            Assert.That(ArticleChooser.FilteredArtikelList.Count() > 2);
        }
    }
}