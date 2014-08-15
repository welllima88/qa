using System;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Location;
using View = Six.Scs.QA.Selenium.Location.View;

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

            Selenium.Location.Create.CompanyName = "SYR SBS Standort A";
            Selenium.Location.Create.StreetNo = "SBS Way 201a-c";
            Selenium.Location.Create.Zip = "4554";
            Selenium.Location.Create.City = "SBS";

            Selenium.Location.Create.SaveButton.Click();

            Assert.AreEqual("SYR SBS Standort A", View.CompanyName);

            StringAssert.Matches(View.SbsDebitNumber, new Regex(TestRegExpPatterns.SbsDebitorNo));
            int retry = 10;
            do
            {
                try
                {
                    StringAssert.Matches(View.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNo));
                    retry = 0; //no retry necessary anymore
                }
                catch (AssertFailedException)
                {
                    Thread.Sleep(MillisecondsTimeout);
                    LocationMenu.Location.Click();
                    retry--;
                }
            } while (retry > 0);
            Assert.AreEqual("SBS Way 201a-c", View.StreetNo);
            Assert.AreEqual("4554", View.Zip);
            Assert.AreEqual("SBS", View.City);
        }

        [TestMethod]
        public void CountryOfCustomerIsUsedForAgencyOfLocation()
        {
            string country = Selenium.Customer.View.Country;
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual(country, Selenium.Location.Create.Country);
        }

        [TestMethod]
        public void LanguageOfCustomerIsUsedForAgencyOfLocation()
        {
            string language = Selenium.Customer.View.Language;
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual(language, Selenium.Location.Create.Language);
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
            Assert.AreEqual("Neuer Standort", Lobby.Headline.Text);
        }
    }
}