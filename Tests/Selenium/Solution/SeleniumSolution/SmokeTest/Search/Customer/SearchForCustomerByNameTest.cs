﻿using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Search;
using Six.Scs.QA.Selenium.Search.Result;

namespace Six.Scs.QA.Selenium.SmokeTest.Search.Customer
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class SearchForCustomerByNameTest
    {
        private const string SearchField = "SYR Kunde6";

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
            StringAssert.Contains(SearchField, SearchResult.First(new Selenium.Search.Result.Customer()).Text);
        }

        [Test]
        [Category("Search"), Category("Customer")]
        public void SearchStringInHeadlineIsDisplayed()
        {
            StringAssert.Contains(SearchField, SearchResult.Headline);
        }
    }
}