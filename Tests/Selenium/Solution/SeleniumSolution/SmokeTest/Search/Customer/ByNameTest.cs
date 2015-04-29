﻿using System.Collections.Generic;
using NUnit.Framework;
using Six.Scs.Test.View.Common;
using Six.Scs.Test.View.Search;
using Six.Test.Selenium.WebDriver;
using Six.Test.Selenium.WebDriver.WebElements;

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