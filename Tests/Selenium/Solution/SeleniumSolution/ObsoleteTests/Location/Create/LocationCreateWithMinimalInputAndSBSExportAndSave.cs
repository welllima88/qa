﻿using System;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Location;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Location.Create
{
    [TestClass]
    public class LocationCreateWithMinimalInputAndSbsExportAndSave
    {
        private static readonly TimeSpan MillisecondsTimeout = TimeSpan.FromSeconds(1);

        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?CustomerId=404871");
        }

        [TestMethod]
        public void CreateLocationWithSbsAndMinimalAndSave()
        {
            CustomerMenu.LocationCreate.Click();

            LocationCreate.CompanyName = "SYR SBS Standort A";
            LocationCreate.StreetNo = "SBS Way 201a-c";
            LocationCreate.Zip = "4554";
            LocationCreate.City = "SBS";

            LocationCreate.SaveButton.Click();

            Assert.AreEqual("SYR SBS Standort A", LocationView.CompanyName);

            StringAssert.Matches(LocationView.SbsDebitNumber, new Regex(TestRegExpPatterns.SbsDebitorNo));
            int retry = 10;
            do
            {
                try
                {
                    StringAssert.Matches(LocationView.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNo));
                    retry = 0; //no retry necessary anymore
                }
                catch (AssertFailedException)
                {
                    Thread.Sleep(MillisecondsTimeout);
                    LocationMenu.Location.Click();
                    retry--;
                }
            } while (retry > 0);
            Assert.AreEqual("SBS Way 201a-c", LocationView.StreetNo);
            Assert.AreEqual("4554", LocationView.Zip);
            Assert.AreEqual("SBS", LocationView.City);
        }

        [TestMethod]
        public void CountryOfCustomerIsUsedForAgencyOfLocation()
        {
            string country = CustomerView.Country;
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual(country, LocationCreate.Country);
        }

        [TestMethod]
        public void LanguageOfCustomerIsUsedForAgencyOfLocation()
        {
            string language = CustomerView.Language;
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual(language, LocationCreate.Language);
        }

        [TestMethod]
        public void CreateLocationCheckNavBar()
        {
            Assert.AreEqual("Kunde", NavigationBar.Current.Text);
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual("Kunde", NavigationBar.Current.Text);
        }

        [TestMethod]
        public void CreateLocationCheckHeadline()
        {
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual("Neuer Standort", LobbyView.Headline.Text);
        }
    }
}