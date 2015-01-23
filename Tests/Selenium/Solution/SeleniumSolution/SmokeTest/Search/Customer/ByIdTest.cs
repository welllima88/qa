﻿using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Location;
using Six.Scs.QA.Selenium.Search;

namespace Six.Scs.QA.Selenium.SmokeTest.Search.Customer
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class ByIdTest
    {
        private static string _debitorNumber;
        private static string _ep2MerchantId;

        [TestFixtureSetUp]
        [Category("Search")]
        public static void ClassInit()
        {
            TestDirector.Navigate();
            Workflow.Search.Find("1");
            new SearchResult(Result.Customer).First().Click();
            _debitorNumber = View.SbsDebitNumber;
            _ep2MerchantId = View.Ep2MerchantId;
        }

        [Test]
        [Category("Search"), Category("Location")]
        public void DebitorNumber()
        {
            Workflow.Search.Find(_debitorNumber);
            StringAssert.Contains("SIX Payment Services AG", new SearchResult(Result.Customer).First().Text);
            new SearchResult(Result.Customer).First().Click();
            Assert.That(_debitorNumber, Is.EqualTo(View.SbsDebitNumber));
        }

        [Test]
        [Category("Search"), Category("Location")]
        public void Ep2MerchantId()
        {
            Workflow.Search.Find(_ep2MerchantId);
            StringAssert.Contains("SIX Payment Services AG", new SearchResult(Result.Customer).First().Text);
            new SearchResult(Result.Customer).First().Click();
            Assert.That(_ep2MerchantId, Is.EqualTo(View.Ep2MerchantId));
        }
    }
}