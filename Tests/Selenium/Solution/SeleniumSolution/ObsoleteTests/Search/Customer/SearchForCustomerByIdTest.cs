using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Search.Result;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Search.Customer
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
            StringAssert.Contains(SearchResult.Headline, SearchField);
        }

        [TestMethod]
        [TestCategory("Search"), TestCategory("Customer")]
        public void CustomerIdInResultIsDisplayed()
        {
            StringAssert.Contains(SearchResult.First(new Selenium.Search.Result.Customer()).Text, SearchField);
        }

        [TestMethod]
        [TestCategory("Search"), TestCategory("Customer")]
        public void ShowLocationsAndTerminals()
        {
            SearchResult.LoadMoreLink(new Selenium.Search.Result.Customer()).Click();
            Assert.IsFalse(SearchResult.First(new Selenium.Search.Result.Customer()).Displayed);
        }
    }
}