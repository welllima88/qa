using NUnit.Framework;
using Six.Scs.Test.View.Common;
using Six.Scs.Test.View.Search;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Search.Customer
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class ByNameTest
    {
        [SetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();
            QuickSearch.SearchField = SearchString;
            QuickSearch.SearchButton.Click();
        }

        private const string SearchString = "SYR Kunde63498 Hardt";

        [Test]
        [Category("Search"), Category("Customer")]
        public void CustomerIdInResultIsDisplayed()
        {
            char[] splitter = {' ', '*'};
            var searchStrings = SearchString.Split(splitter);
            var results = SearchResult.Result(Result.Customer);

            foreach (var result in results)
            {
                foreach (var searchString in searchStrings)
                {
                    Assert.That(result.Text, Contains.Substring(searchString));
                }
            }
            SearchResult.First(Result.Customer).Click();
        }

        [Test]
        [Category("Search"), Category("Customer")]
        public void SearchStringInHeadlineIsDisplayed()
        {
            StringAssert.Contains(SearchString, SearchResult.Headline);
        }
    }
}