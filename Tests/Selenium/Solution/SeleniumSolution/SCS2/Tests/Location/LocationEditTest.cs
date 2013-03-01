using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Location
{
    [TestClass]
    public class LocationEditTest
    {
        private static LocationView _locationView;
        private static LocationEdit _locationEdit;
        private static IWebDriverAdapter _driver;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static TestDirector _tb;
        private static FormAlert _formAlert;
        private static LocationCreate _locationCreate;
        private static LocationMenu _locationMenu;
        private static MenusTest _menusTests;
        private static Lobby _lobby;
        private long _dt;
        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login

            _locationMenu = new LocationMenu(_driver);
            _locationCreate = new LocationCreate(_driver);
            _locationEdit = new LocationEdit(_driver);
            _locationView = new LocationView(_driver);
            _recentElements = new RecentElements(_driver);
            _menusTests = new MenusTest();

            _navigationBar = new NavigationBar(_driver);
            _formAlert = new FormAlert(_driver);
            _lobby = new Lobby(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            _driver.Url = _tb.BaseUrl + "/Location?LocationId=4b77d4f2-d5db-4823-9d52-63c1534de457";
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
        public void EditLocationAndCancel()
        {
            string guid = _locationView.Guid;

            string sapNumber = _locationView.SapNumber;
            string sbsDebitNumber = _locationView.SbsDebitNumber;
            string sbsAdressNumber = _locationView.SbsAdressNumber;

            string ep2MerchantId = _locationView.Ep2MerchantId;

            string companyName = _locationView.CompanyName;
            string po = _locationView.Po;
            string adressAddition = _locationView.AdressAddition;
            string streetName = _locationView.StreetName;
            string zip = _locationView.Zip;
            string city = _locationView.City;
            string language = _locationView.Language;
            string country = _locationView.Country;
            string email = _locationView.Email;
            string telephone = _locationView.Telephone;
            string mobile = _locationView.Mobile;
            string fax = _locationView.Fax;
            string web = _locationView.Web;

            _locationMenu.LocationEdit.Click();

            _locationEdit.CompanyName = "SYR Sele Firma AAA";
            _locationEdit.StreetName = "Hardturmstr. 2011";
            _locationEdit.Zip = "80222";
            _locationEdit.City = "Zürichhh";
            _locationEdit.Po = "PFO111";
            _locationEdit.AdressAddition = "Etage 333";
            _locationEdit.Region = "Reggg";
            _locationEdit.SapNumber = "4449";

            _locationEdit.Language = "Kroatisch [hr]";
            _locationEdit.Country = "Albanien [AL]";
            _locationEdit.Email = "marc.siegmund@six-group.com";
            _locationEdit.Telephone = "0031 58 399 623777";
            _locationEdit.Mobile = "0032 58 399 623777";
            _locationEdit.Fax = "0033 58 399 623777";
            _locationEdit.Web = "www.six-group.com/de-internnnn";

            _locationEdit.CancelButton.Click();

            Assert.AreEqual(guid, _locationView.Guid);
            Assert.AreEqual(sapNumber, _locationView.SapNumber);

            StringAssert.Matches(_locationView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(_locationView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(_locationView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual(sbsDebitNumber, _locationView.SbsDebitNumber);
            Assert.AreEqual(sbsAdressNumber, _locationView.SbsAdressNumber);
            Assert.AreEqual(ep2MerchantId, _locationView.Ep2MerchantId);
            Assert.AreEqual(companyName, _locationView.CompanyName);
            Assert.AreEqual(po, _locationView.Po);
            Assert.AreEqual(adressAddition, _locationView.AdressAddition);
            Assert.AreEqual(streetName, _locationView.StreetName);
            Assert.AreEqual(zip, _locationView.Zip);
            Assert.AreEqual(city, _locationView.City);
            Assert.AreEqual(language, _locationView.Language);
            Assert.AreEqual(country, _locationView.Country);
            Assert.AreEqual(email, _locationView.Email);
            Assert.AreEqual(telephone, _locationView.Telephone);
            Assert.AreEqual(mobile, _locationView.Mobile);
            Assert.AreEqual(fax, _locationView.Fax);
            Assert.AreEqual(web, _locationView.Web);
        }

        [TestMethod]
        public void EditLocationWithInvalidDataFailed()
        {
            _locationMenu.LocationEdit.Click();

            _locationEdit.CompanyName = "SYR Sele Firma A$°";
            _locationEdit.StreetName = "Hardturmstr. 201$°";
            _locationEdit.Zip = "802$°";
            _locationEdit.City = "Zürich$°";
            _locationEdit.Po = "PFO1$°";
            _locationEdit.AdressAddition = "Etage 3$°";
            _locationEdit.Region = "Reg 3[]$°";
            _locationEdit.SapNumber = "444$°";

            _locationEdit.Language = "Deutsch [de]";
            _locationEdit.Country = "Schweiz [CH]";
            _locationEdit.Email = "marc.siegmund@six-grou$°p.com()";
            _locationEdit.Telephone = "0031 58 399 6237$";
            _locationEdit.Mobile = "0032 58 399 6237$";
            _locationEdit.Fax = "0033 58 399 6237$";
            _locationEdit.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            _locationEdit.SaveButton.Click();

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
            Assert.IsTrue(_formAlerts.Count == 12, "Wrong number of form alerts");
        }

        [TestMethod]
        public void EditLocationWithoutCompanyNameFailed()
        {
            _locationMenu.LocationEdit.Click();

            _locationEdit.StreetName = "Hardturmstr. 201";
            _locationEdit.Zip = "8021";
            _locationEdit.City = "Zürich";
            _locationEdit.Po = "PFO1";
            _locationEdit.AdressAddition = "Etage 3";
            _locationEdit.SapNumber = "4440";

            _locationEdit.Language = "Deutsch [de]";
            _locationEdit.Country = "Schweiz [CH]";
            _locationEdit.Email = "marc.siegmund@six-group.com";
            _locationEdit.Telephone = "0031 58 399 6237";
            _locationEdit.Mobile = "0032 58 399 6237";
            _locationEdit.Fax = "0033 58 399 6237";
            _locationEdit.Web = "www.six-group.com/de-intern";

            _locationEdit.CompanyName = "";
            _locationEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1, "Wrong number of form alerts");
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!"),
                          "Wrong text in form alerts");
            _locationEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditLocationWithIncompleteDataFailed()
        {
            _locationMenu.LocationEdit.Click();

            _locationEdit.CompanyName = "";
            _locationEdit.StreetName = "";
            _locationEdit.Zip = "";
            _locationEdit.City = "";
            _locationEdit.Po = "";
            _locationEdit.AdressAddition = "";
            _locationEdit.Region = "";
            _locationEdit.SapNumber = "";

            _locationEdit.Email = "";
            _locationEdit.Telephone = "";
            _locationEdit.Mobile = "";
            _locationEdit.Fax = "";
            _locationEdit.Web = "";

            _locationEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Count == 4);
        }

        [TestMethod]
        public void CheckLocationMenu()
        {
            _menusTests.LocationMenuCheck(_locationMenu);
            _locationMenu.LocationEdit.Click();
            _locationEdit.CancelButton.Click();
            _menusTests.LocationMenuCheck(_locationMenu);
        }

        [TestMethod]
        public void EditLocationWithoutStreetAndNumberFailed()
        {
            _locationMenu.LocationEdit.Click();

            _locationEdit.CompanyName = "SYR Sele Firma A";
            _locationEdit.StreetName = "";
            _locationEdit.Zip = "8021";
            _locationEdit.City = "Zürich";
            _locationEdit.Po = "PFO1";
            _locationEdit.AdressAddition = "Etage 3";
            _locationEdit.SapNumber = "4440";

            _locationEdit.Language = "Deutsch [de]";
            _locationEdit.Country = "Schweiz [CH]";
            _locationEdit.Email = "marc.siegmund@six-group.com";
            _locationEdit.Telephone = "0031 58 399 6237";
            _locationEdit.Mobile = "0032 58 399 6237";
            _locationEdit.Fax = "0033 58 399 6237";
            _locationEdit.Web = "www.six-group.com/de-intern";

            _locationEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void EditLocationWithoutCityFailed()
        {
            _locationMenu.LocationEdit.Click();

            _locationEdit.CompanyName = "SYR Sele Firma A";
            _locationEdit.StreetName = "Hardturmstr. 201";
            _locationEdit.Zip = "8021";
            _locationEdit.City = "";
            _locationEdit.Po = "PFO1";
            _locationEdit.AdressAddition = "Etage 3";
            _locationEdit.SapNumber = "4440";

            _locationEdit.Language = "Deutsch [de]";
            _locationEdit.Country = "Schweiz [CH]";
            _locationEdit.Email = "marc.siegmund@six-group.com";
            _locationEdit.Telephone = "0031 58 399 6237";
            _locationEdit.Mobile = "0032 58 399 6237";
            _locationEdit.Fax = "0033 58 399 6237";
            _locationEdit.Web = "www.six-group.com/de-intern";

            _locationEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void EditLocationWithoutZipFailed()
        {
            _locationMenu.LocationEdit.Click();

            _locationEdit.CompanyName = "SYR Sele Firma A";
            _locationEdit.StreetName = "Hardturmstr. 201";
            _locationEdit.Zip = "";
            _locationEdit.City = "Zürich";
            _locationEdit.Po = "PFO1";
            _locationEdit.AdressAddition = "Etage 3";
            _locationEdit.SapNumber = "4440";

            _locationEdit.Language = "Deutsch [de]";
            _locationEdit.Country = "Schweiz [CH]";
            _locationEdit.Email = "marc.siegmund@six-group.com";
            _locationEdit.Telephone = "0031 58 399 6237";
            _locationEdit.Mobile = "0032 58 399 6237";
            _locationEdit.Fax = "0033 58 399 6237";
            _locationEdit.Web = "www.six-group.com/de-intern";

            _locationEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void EditLocationAndSave()
        {
            string guid = _locationView.Guid;
            string ep2MerchantId = _locationView.Ep2MerchantId;
            string sbsDebitNumber = _locationView.SbsDebitNumber;
            string sbsAdressNumber = _locationView.SbsAdressNumber;

            _locationMenu.LocationEdit.Click();
            Assert.AreEqual(_locationEdit.Guid, guid);
            Assert.AreEqual(_locationEdit.Ep2MerchantId, ep2MerchantId);
            Assert.AreEqual(_locationEdit.SbsDebitNumber, sbsDebitNumber);
            Assert.AreEqual(_locationEdit.SbsAdressNumber, sbsAdressNumber);

            _locationEdit.CompanyName = "SYR Standort SELE B";
            _locationEdit.StreetName = "Am Bärenplatz 2";
            _locationEdit.Zip = "8001";
            _locationEdit.City = "Kreuzlingen";
            _locationEdit.Po = "PO2-A";
            _locationEdit.AdressAddition = "Level2";
            _locationEdit.SapNumber = "1331";
            _locationEdit.Email = "marc.siegmund@six-group.com";
            _locationEdit.Telephone = "+41 58 399 6237";
            _locationEdit.Mobile = "+42 58 399 6237";
            _locationEdit.Fax = "+43 58 399 6237";
            _locationEdit.Web = "www.six-group.com";

            _locationEdit.Language = "Englisch [en]";
            _locationEdit.Country = "Schweiz [CH]";

            _locationCreate.SaveButton.Click();

            Assert.AreEqual(_locationView.Guid, guid);
            Assert.AreEqual(_locationView.Ep2MerchantId, ep2MerchantId);
            Assert.AreEqual("SYR Standort SELE B", _locationView.CompanyName);

            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual(_locationView.Guid, guid);
            Assert.AreEqual(_locationView.Ep2MerchantId, ep2MerchantId);
            Assert.AreEqual("SYR Standort SELE B", _locationView.CompanyName);

            StringAssert.Matches(_locationView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(_locationView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(_locationView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual("Am Bärenplatz 2", _locationView.StreetName);
            Assert.AreEqual("1331", _locationView.SapNumber);
            Assert.AreEqual("SYR Standort SELE B", _locationView.CompanyName);
            Assert.AreEqual("8001", _locationView.Zip);
            Assert.AreEqual("PO2-A", _locationView.Po);
            Assert.AreEqual("Level2", _locationView.AdressAddition);
            Assert.AreEqual("Kreuzlingen", _locationView.City);
            Assert.AreEqual("Englisch [en]", _locationView.Language);
            Assert.AreEqual("Schweiz [CH]", _locationView.Country);
            Assert.AreEqual("marc.siegmund@six-group.com", _locationView.Email);
            Assert.AreEqual("+41 58 399 6237", _locationView.Telephone);
            Assert.AreEqual("+42 58 399 6237", _locationView.Mobile);
            Assert.AreEqual("+43 58 399 6237", _locationView.Fax);
            Assert.AreEqual("www.six-group.com", _locationView.Web);
        }

        [TestMethod]
        public void EditLocationWithMinimalAndSave()
        {
            string guid = _locationView.Guid;
            string ep2MerchantId = _locationView.Ep2MerchantId;
            string sbsDebitNumber = _locationView.SbsDebitNumber;
            string sbsAdressNumber = _locationView.SbsAdressNumber;

            _locationMenu.LocationEdit.Click();
            Assert.AreEqual(_locationEdit.Guid, guid);
            Assert.AreEqual(_locationEdit.Ep2MerchantId, ep2MerchantId);
            Assert.AreEqual(_locationEdit.SbsDebitNumber, sbsDebitNumber);
            Assert.AreEqual(_locationEdit.SbsAdressNumber, sbsAdressNumber);

            _locationEdit.CompanyName = "SYR Standort SELE B";
            _locationEdit.StreetName = "Am Bärenplatz 2";
            _locationEdit.Zip = "8001";
            _locationEdit.City = "Kreuzlingen";
            _locationEdit.Po = "";
            _locationEdit.AdressAddition = "";
            _locationEdit.SapNumber = "";
            _locationEdit.Email = "";
            _locationEdit.Telephone = "";
            _locationEdit.Mobile = "";
            _locationEdit.Fax = "";
            _locationEdit.Web = "";

            _locationEdit.Language = "Englisch [en]";
            _locationEdit.Country = "Schweiz [CH]";

            _locationCreate.SaveButton.Click();

            Assert.AreEqual(_locationView.Guid, guid);
            Assert.AreEqual(_locationView.Ep2MerchantId, ep2MerchantId);
            Assert.AreEqual("SYR Standort SELE B", _locationView.CompanyName);

            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual(_locationView.Guid, guid);
            Assert.AreEqual(_locationView.Ep2MerchantId, ep2MerchantId);
            Assert.AreEqual("SYR Standort SELE B", _locationView.CompanyName);

            StringAssert.Matches(_locationView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(_locationView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(_locationView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual("Am Bärenplatz 2", _locationView.StreetName);
            Assert.AreEqual("", _locationView.SapNumber);
            Assert.AreEqual("SYR Standort SELE B", _locationView.CompanyName);
            Assert.AreEqual("8001", _locationView.Zip);
            Assert.AreEqual("", _locationView.Po);
            Assert.AreEqual("", _locationView.AdressAddition);
            Assert.AreEqual("Kreuzlingen", _locationView.City);
            Assert.AreEqual("Englisch [en]", _locationView.Language);
            Assert.AreEqual("Schweiz [CH]", _locationView.Country);
            Assert.AreEqual("", _locationView.Email);
            Assert.AreEqual("", _locationView.Telephone);
            Assert.AreEqual("", _locationView.Mobile);
            Assert.AreEqual("", _locationView.Fax);
            Assert.AreEqual("", _locationView.Web);
        }

        [TestMethod]
        public void EditLocationCheckNavBar()
        {
            Assert.AreEqual("Standort", _navigationBar.Current.Text);
            _locationMenu.LocationEdit.Click();
            Assert.AreEqual("Standort", _navigationBar.Current.Text);
        }

        [TestMethod]
        public void EditLocationCheckHeadline()
        {
            StringAssert.Matches(_lobby.Headline.Text, new Regex(@"\d+: .*"));
            _locationMenu.LocationEdit.Click();
            StringAssert.Matches(_lobby.Headline.Text, new Regex(@"\d+: .*"));
        }
    }
}