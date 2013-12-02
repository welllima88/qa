using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.SearchResult;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Search.Customer
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
            StringAssert.Contains(CustomerResult.Result(SearchField).Text, SearchField);
        }

        [TestMethod]
        [TestCategory("Search"), TestCategory("Customer")]
        public void ShowLocationsAndTerminals()
        {
            CustomerResult.ShowDescent(SearchField).Click();
            Assert.IsFalse(CustomerResult.ShowDescent("").Displayed);
        }
    }
}