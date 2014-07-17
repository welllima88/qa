using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.SearchResult;

namespace Six.Scs.QA.Selenium.SmokeTest.Search.Customer
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class SearchForCustomerByIdTest
    {
        private const string SearchField = "1";

        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();
            QuickSearch.SearchField = SearchField;
            QuickSearch.SearchButton.Click();
        }

        [Test]
        [Category("Search"), Category("Customer")]
        public void CustomerIdInResultIsDisplayed()
        {
            StringAssert.Contains("SIX Payment Services AG", CustomerResult.Result().Text);
        }

        [Test]
        [Category("Search"), Category("Customer")]
        public void SearchStringInHeadlineIsDisplayed()
        {
            StringAssert.Contains(SearchField, SearchResults.Headline);
        }
    }
}