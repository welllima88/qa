﻿using System.Collections.Generic;
using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.QA.Selenium.Extension.WebDriver.WebElements;
using Six.Scs.QA.Selenium.View.Common;
using Six.Scs.QA.Selenium.View.Search;

namespace Six.Scs.QA.Selenium.SmokeTest.Search.Customer
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
            string[] searchStrings = SearchString.Split(splitter);
            IEnumerable<IWebElementAdapter> results = new SearchResult(Result.Customer).Result();

            foreach (IWebElementAdapter result in results)
            {
                foreach (string searchString in searchStrings)
                {
                    Assert.That(result.Text, Contains.Substring(searchString));
                }
            }
            new SearchResult(Result.Customer).First().Click();
        }

        [Test]
        [Category("Search"), Category("Customer")]
        public void SearchStringInHeadlineIsDisplayed()
        {
            StringAssert.Contains(SearchString, SearchResult.Headline);
        }
    }
}