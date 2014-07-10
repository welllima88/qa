using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.SearchResult;

namespace Six.Scs.QA.Selenium.Tests.Search.Customer
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class SearchForCustomerByIdTest
    {
        private const string SearchField = "401858";

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate();
            QuickSearch.SearchField = SearchField;
            QuickSearch.SearchButton.Click();
        }

        [TestMethod]
        [TestCategory("Search"), TestCategory("Customer")]
        public void CustomerResultNotEmpty()
        {
        }

        [TestMethod]
        [TestCategory("Search"), TestCategory("Customer")]
        public void SearchStringInHeadlineIsDisplayed()
        {
            StringAssert.Contains(SearchResults.Headline, SearchField);
        }

        [TestMethod]
        [TestCategory("Search"), TestCategory("Customer")]
        public void CustomerIdInResultIsDisplayed()
        {
            StringAssert.Contains(CustomerResult.Result().Text, SearchField);
        }

        [TestMethod]
        [TestCategory("Search"), TestCategory("Customer")]
        public void ShowLocationsAndTerminals()
        {
            CustomerResult.Result().Click();
            Assert.IsFalse(CustomerResult.Result().Displayed);
        }
    }
}