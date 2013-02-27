using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Location
{
    [TestClass]
    public class LocationCreateTest
    {
        private const int MillisecondsTimeout = 1000;
        private static LocationView _locationView;
        private static IWebDriver _driver;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static TestDirector _tb;
        private static FormAlert _formAlert;
        private static LocationCreate _locationCreate;
        private static LocationMenu _locationMenu;
        private static CustomerMenu _customerMenu;
        private static MenusTest _menusTests;
        private static CustomerView _customerView;
        private static Lobby _lobby;

        private long _dt;
        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new Scs2TestDirector();
            _driver = _tb.SetupTest(); //default QA-L with certificate login
            _customerMenu = new CustomerMenu(_driver);
            _customerView = new CustomerView(_driver);
            _locationMenu = new LocationMenu(_driver);
            _locationCreate = new LocationCreate(_driver);
            _locationView = new LocationView(_driver);
            _recentElements = new RecentElements(_driver);

            _navigationBar = new NavigationBar(_driver);
            _formAlert = new FormAlert(_driver);
            _menusTests = new MenusTest();
            _lobby = new Lobby(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            _driver.Url = _tb.BaseUrl + "/Pages/Customer/CustomerEdit.aspx?CustomerId=404871";
            _dt = DateTime.Now.Ticks; //timestamp for each test
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            //after last test-method finished
            _tb.ShutDownTest();
        }

        [TestMethod]
        public void CreateLocationWithInvalidDataFailed()
        {
            _customerMenu.LocationCreate.Click();

            _locationCreate.CompanyName = "SYR Sele Firma A$°";
            _locationCreate.StreetName = "Hardturmstr. 201$°";
            _locationCreate.Zip = "802$°";
            _locationCreate.City = "Zürich$°";
            _locationCreate.Po = "PFO1$°";
            _locationCreate.AdressAddition = "Etage 3$°";
            _locationCreate.Region = "Reg 3[]$°";
            _locationCreate.SapNumber = "444$°";

            _locationCreate.Language = "Deutsch [de]";
            _locationCreate.Country = "Schweiz [CH]";
            _locationCreate.Email = "marc.siegmund@six-grou$°p.com";
            _locationCreate.Telephone = "0031 58 399 6237$";
            _locationCreate.Mobile = "0032 58 399 6237$";
            _locationCreate.Fax = "0033 58 399 6237$";
            _locationCreate.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            _locationCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Zusatz: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Telefon: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Mobiltelefon: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Fax: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("PLZ: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Postfach: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Ort: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Region (Kurzzeichen): Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Email: Dies ist keine gültige E-Mail Adresse!"));
            Assert.IsTrue(_formAlerts.Contains("Web: Dies ist keine gültige Web Adresse!"));
            Assert.IsTrue(_formAlerts.Count == 12);
        }

        [TestMethod]
        public void CreateLocationWithIncompleteDataFailed()
        {
            _customerMenu.LocationCreate.Click();

            _locationCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 4);
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Dies ist ein Pflichtfeld! Zu kurze Eingabe!"));
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateLocationrWithoutCompanyNameFailed()
        {
            _customerMenu.LocationCreate.Click();

            _locationCreate.CompanyName = "";
            _locationCreate.StreetName = "Hardturmstr. 201";
            _locationCreate.Zip = "8021";
            _locationCreate.City = "Zürich";
            _locationCreate.Po = "PFO1";
            _locationCreate.AdressAddition = "Etage 3";
            _locationCreate.Region = "Reg 55";
            _locationCreate.SapNumber = "4440";

            _locationCreate.Language = "Deutsch [de]";
            _locationCreate.Country = "Schweiz [CH]";
            _locationCreate.Email = "marc.siegmund@six-group.com";
            _locationCreate.Telephone = "0031 58 399 6237";
            _locationCreate.Mobile = "0032 58 399 6237";
            _locationCreate.Fax = "0033 58 399 6237";
            _locationCreate.Web = "www.six-group.com/de-intern";

            _locationCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateLocationWithoutStreetAndNumberFailed()
        {
            _customerMenu.LocationCreate.Click();

            _locationCreate.CompanyName = "SYR Sele Firma A";
            _locationCreate.StreetName = "";
            _locationCreate.Zip = "8021";
            _locationCreate.City = "Zürich";
            _locationCreate.Po = "PFO1";
            _locationCreate.AdressAddition = "Etage 3";
            _locationCreate.Region = "Reg 55";
            _locationCreate.SapNumber = "4440";

            _locationCreate.Language = "Deutsch [de]";
            _locationCreate.Country = "Schweiz [CH]";
            _locationCreate.Email = "marc.siegmund@six-group.com";
            _locationCreate.Telephone = "0031 58 399 6237";
            _locationCreate.Mobile = "0032 58 399 6237";
            _locationCreate.Fax = "0033 58 399 6237";
            _locationCreate.Web = "www.six-group.com/de-intern";

            _locationCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateLocationWithoutCityFailed()
        {
            _customerMenu.LocationCreate.Click();

            _locationCreate.CompanyName = "SYR Sele Firma A";
            _locationCreate.StreetName = "Hardturmstr. 201";
            _locationCreate.Zip = "8021";
            _locationCreate.City = "";
            _locationCreate.Po = "PFO1";
            _locationCreate.AdressAddition = "Etage 3";
            _locationCreate.Region = "Reg 55";
            _locationCreate.SapNumber = "4440";

            _locationCreate.Language = "Deutsch [de]";
            _locationCreate.Country = "Schweiz [CH]";
            _locationCreate.Email = "marc.siegmund@six-group.com";
            _locationCreate.Telephone = "0031 58 399 6237";
            _locationCreate.Mobile = "0032 58 399 6237";
            _locationCreate.Fax = "0033 58 399 6237";
            _locationCreate.Web = "www.six-group.com/de-intern";

            _locationCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateLocationWithoutZipFailed()
        {
            _customerMenu.LocationCreate.Click();

            _locationCreate.CompanyName = "SYR Sele Firma A";
            _locationCreate.StreetName = "Hardturmstr. 201";
            _locationCreate.Zip = "";
            _locationCreate.City = "Zürich";
            _locationCreate.Po = "PFO1";
            _locationCreate.AdressAddition = "Etage 3";
            _locationCreate.Region = "Reg 55";
            _locationCreate.SapNumber = "4440";

            _locationCreate.Language = "Deutsch [de]";
            _locationCreate.Country = "Schweiz [CH]";
            _locationCreate.Email = "marc.siegmund@six-group.com";
            _locationCreate.Telephone = "0031 58 399 6237";
            _locationCreate.Mobile = "0032 58 399 6237";
            _locationCreate.Fax = "0033 58 399 6237";
            _locationCreate.Web = "www.six-group.com/de-intern";

            _locationCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateLocationAndSave()
        {
            _customerMenu.LocationCreate.Click();

            _locationCreate.CompanyName = "SYR Standort SELE A";
            _locationCreate.StreetName = "Bröselstr. 201a-c";
            _locationCreate.Zip = "55555";
            _locationCreate.City = "München";
            _locationCreate.Po = "PO1";
            _locationCreate.AdressAddition = "AdressAdd1";
            _locationCreate.Region = "Reg 55";
            _locationCreate.SapNumber = "4444";

            _locationCreate.Language = "Französisch [fr]";
            _locationCreate.Country = "Frankreich [FR]";
            _locationCreate.Email = "marc.siegmund@six-group.com";
            _locationCreate.Telephone = "0031 58 399 6237";
            _locationCreate.Mobile = "0032 58 399 6237";
            _locationCreate.Fax = "0033 58 399 6237";
            _locationCreate.Web = "www.six-group.com/de-intern";

            _locationCreate.SaveButton.Click();

            string locId = _locationView.Guid;
            string ep2MerchantId = _locationView.Ep2MerchantId;
            Assert.AreEqual("SYR Standort SELE A", _locationView.CompanyName);
            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual(locId, _locationView.Guid);
            Assert.AreEqual("SYR Standort SELE A", _locationView.CompanyName);
            Assert.AreEqual(ep2MerchantId, _locationView.Ep2MerchantId);

            StringAssert.Matches(_locationView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);

            try
            {
                StringAssert.Matches(_locationView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNo);
            }
            catch (AssertFailedException)
            {
            }
            StringAssert.Matches(_locationView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual("Bröselstr. 201a-c", _locationView.StreetName);
            Assert.AreEqual("PO1", _locationView.Po);
            Assert.AreEqual("SYR Standort SELE A", _locationView.CompanyName);
            Assert.AreEqual("55555", _locationView.Zip);
            Assert.AreEqual("München", _locationView.City);
            Assert.AreEqual("Reg 55", _locationView.Region);
            Assert.AreEqual("AdressAdd1", _locationView.AdressAddition);
            Assert.AreEqual("Französisch [fr]", _locationView.Language);
            Assert.AreEqual("Frankreich [FR]", _locationView.Country);
            Assert.AreEqual("marc.siegmund@six-group.com", _locationView.Email);
            Assert.AreEqual("0031 58 399 6237", _locationView.Telephone);
            Assert.AreEqual("0032 58 399 6237", _locationView.Mobile);
            Assert.AreEqual("0033 58 399 6237", _locationView.Fax);
            Assert.AreEqual("www.six-group.com/de-intern", _locationView.Web);
        }

        [TestMethod]
        public void CreateLocationWithMinimalAndSave()
        {
            _customerMenu.LocationCreate.Click();

            _locationCreate.CompanyName = "SYR Standort SELE A";
            _locationCreate.StreetName = "Bröselstr. 201a-c";
            _locationCreate.Zip = "55555";
            _locationCreate.City = "München";

            _locationCreate.Language = "Französisch [fr]";
            _locationCreate.Country = "Frankreich [FR]";

            _locationCreate.SaveButton.Click();

            Assert.AreEqual("SYR Standort SELE A", _locationView.CompanyName);

            _menusTests.LocationMenuCheck(_locationMenu);

            string locId = _locationView.Guid;
            string ep2MerchantId = _locationView.Ep2MerchantId;

            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual(locId, _locationView.Guid);
            Assert.AreEqual("SYR Standort SELE A", _locationView.CompanyName);
            Assert.AreEqual(ep2MerchantId, _locationView.Ep2MerchantId);

            StringAssert.Matches(_locationView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            try
            {
                StringAssert.Matches(_locationView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNo);
            }
            catch (AssertFailedException)
            {
            }
            StringAssert.Matches(_locationView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual("Bröselstr. 201a-c", _locationView.StreetName);
            Assert.AreEqual("", _locationView.Po);
            Assert.AreEqual("SYR Standort SELE A", _locationView.CompanyName);
            Assert.AreEqual("55555", _locationView.Zip);
            Assert.AreEqual("München", _locationView.City);
            Assert.AreEqual("", _locationView.AdressAddition);
            Assert.AreEqual("", _locationView.Region);
            Assert.AreEqual("Französisch [fr]", _locationView.Language);
            Assert.AreEqual("Frankreich [FR]", _locationView.Country);
            Assert.AreEqual("", _locationView.Email);
            Assert.AreEqual("", _locationView.Telephone);
            Assert.AreEqual("", _locationView.Mobile);
            Assert.AreEqual("", _locationView.Fax);
            Assert.AreEqual("", _locationView.Web);
        }

        [TestMethod]
        public void CreateLocationWithSbsAndMinimalAndSave()
        {
            _customerMenu.LocationCreate.Click();

            _locationCreate.CompanyName = "SYR SBS Standort A";
            _locationCreate.StreetName = "SBS Way 201a-c";
            _locationCreate.Zip = "4554";
            _locationCreate.City = "SBS";

            _locationCreate.SaveButton.Click();

            Assert.AreEqual("SYR SBS Standort A", _locationView.CompanyName);

            StringAssert.Matches(_locationView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            int retry = 10;
            do
            {
                try
                {
                    StringAssert.Matches(_locationView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNo);
                    retry = 0; //no retry necessary anymore
                }
                catch (AssertFailedException)
                {
                    Thread.Sleep(MillisecondsTimeout);
                    _locationMenu.Location.Click();
                    retry--;
                }
            } while (retry > 0);
            Assert.AreEqual("SBS Way 201a-c", _locationView.StreetName);
            Assert.AreEqual("4554", _locationView.Zip);
            Assert.AreEqual("SBS", _locationView.City);
        }

        [Ignore] //obsolete
        [TestMethod]
        public void AgencyOfCustomerIsUsedForAgencyOfLocation()
        {
            string agency = _customerView.Agency;
            _customerMenu.LocationCreate.Click();
            //Assert.AreEqual(agency, _locationCreate.Agency);
        }

        [TestMethod]
        public void CountryOfCustomerIsUsedForAgencyOfLocation()
        {
            string country = _customerView.Country;
            _customerMenu.LocationCreate.Click();
            Assert.AreEqual(country, _locationCreate.Country);
        }

        [TestMethod]
        public void LanguageOfCustomerIsUsedForAgencyOfLocation()
        {
            string language = _customerView.Language;
            _customerMenu.LocationCreate.Click();
            Assert.AreEqual(language, _locationCreate.Language);
        }


        [TestMethod]
        public void CreateLocationCheckNavBar()
        {
            Assert.AreEqual("Kunde", _navigationBar.Current.Text);
            _customerMenu.LocationCreate.Click();
            Assert.AreEqual("Kunde", _navigationBar.Current.Text);
        }

        [TestMethod]
        public void CreateLocationCheckHeadline()
        {
            _customerMenu.LocationCreate.Click();
            Assert.AreEqual("Neuer Standort", _lobby.Headline.Text);
        }
    }
}