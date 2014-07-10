using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common;
using Six.Scs.QA.Selenium.Extension.TestObjects.SearchResult;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.SmokeTest.Search.Customer
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class SearchForCustomerByIdTest
    {
        private const string SearchField = "401858";

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
            StringAssert.Contains(SearchField, CustomerResult.Result().Text);
        }

        [Test]
        [Category("Search"), Category("Customer")]
        public void CustomerResultNotEmpty()
        {
        }

        [Test]
        [Category("Search"), Category("Customer")]
        public void SearchStringInHeadlineIsDisplayed()
        {
            StringAssert.Contains(SearchField, SearchResults.Headline);
        }

        [Test]
        [Category("Search"), Category("Customer")]
        public void ShowLocationsAndTerminals()
        {
            CustomerResult.Result().Click();
            Assert.IsFalse(CustomerResult.Result().Displayed);
        }
    }
}