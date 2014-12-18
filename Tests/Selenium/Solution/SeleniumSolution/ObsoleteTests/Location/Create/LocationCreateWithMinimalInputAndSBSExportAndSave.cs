using System;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Location;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Location.Create
{
    [TestFixture]
    public class LocationCreateWithMinimalInputAndSbsExportAndSave
    {
        private static readonly TimeSpan MillisecondsTimeout = TimeSpan.FromSeconds(1);

        [SetUp]
        public void TestInit()
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?CustomerId=404871");
        }

        [Test]
        public void CreateLocationWithSbsAndMinimalAndSave()
        {
            CustomerMenu.LocationCreate.Click();

            Selenium.Location.Create.CompanyName = "SYR SBS Standort A";
            Selenium.Location.Create.StreetNo = "SBS Way 201a-c";
            Selenium.Location.Create.Zip = "4554";
            Selenium.Location.Create.City = "SBS";

            Selenium.Location.Create.SaveButton.Click();

            Assert.AreEqual("SYR SBS Standort A", View.CompanyName);

            StringAssert.IsMatch(View.SbsDebitNumber, new Regex(TestRegExpPatterns.SbsDebitorNo));
            int retry = 10;
            do
            {
                try
                {
                    StringAssert.IsMatch(View.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNo));
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

        [Test]
        public void CountryOfCustomerIsUsedForAgencyOfLocation()
        {
            string country = Selenium.Customer.View.Country;
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual(country, Selenium.Location.Create.Country);
        }

        [Test]
        public void LanguageOfCustomerIsUsedForAgencyOfLocation()
        {
            string language = Selenium.Customer.View.Language;
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual(language, Selenium.Location.Create.Language);
        }

        [Test]
        public void CreateLocationCheckNavBar()
        {
            Assert.AreEqual("Kunde", NavigationBar.Current.Text);
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual("Kunde", NavigationBar.Current.Text);
        }

        [Test]
        public void CreateLocationCheckHeadline()
        {
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual("Neuer Standort", Lobby.Headline.Text);
        }
    }
}