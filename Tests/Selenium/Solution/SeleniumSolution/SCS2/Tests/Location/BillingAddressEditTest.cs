using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Location
{
    [TestClass]
    public class BillingAddressEditTest
    {
        private static BillingAddressView _billingAddressView;
        private static BillingAddressEdit _billingAddressEdit;
        private static IWebDriverAdapter _driver;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static TestDirector _tb;
        private static FormAlert _formAlert;
        private static BillingAddressCreate _billingAddressCreate;
        private static CustomerMenu _customerMenu;
        private static MenusTest _menusTests;
        private long _dt;
        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new Scs2TestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login

            _customerMenu = new CustomerMenu(_driver);
            _billingAddressCreate = new BillingAddressCreate(_driver);
            _billingAddressEdit = new BillingAddressEdit(_driver);
            _billingAddressView = new BillingAddressView(_driver);
            _recentElements = new RecentElements(_driver);
            _menusTests = new MenusTest();

            _navigationBar = new NavigationBar(_driver);
            _formAlert = new FormAlert(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            _driver.Url = _tb.BaseUrl +
                          "/BillingAddress?CustomerId=404840&BillingAddressId=1ef8d828-44ec-4304-8385-df0088cb0fc7";
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
        public void EditBillingAddressAndCancel()
        {
            string companyName = _billingAddressView.CompanyName;
            string po = _billingAddressView.Po;
            string adressAddition = _billingAddressView.AdressAddition;
            string streetName = _billingAddressView.StreetName;
            string zip = _billingAddressView.Zip;
            string city = _billingAddressView.City;
            string language = _billingAddressView.Language;
            string country = _billingAddressView.Country;
            string email = _billingAddressView.Email;
            string telephone = _billingAddressView.Telephone;
            string mobile = _billingAddressView.Mobile;
            string fax = _billingAddressView.Fax;
            string web = _billingAddressView.Web;

            _customerMenu.BillingAddressEdit.Click();

            _billingAddressEdit.CompanyName = "SYR Sele Firma AAA";
            _billingAddressEdit.StreetName = "Hardturmstr. 2011";
            _billingAddressEdit.Zip = "80222";
            _billingAddressEdit.City = "Zürichhh";
            _billingAddressEdit.Po = "PFO111";
            _billingAddressEdit.AdressAddition = "Etage 333";
            _billingAddressEdit.Region = "Reggg";
            _billingAddressEdit.Language = "Croatian [hr]";
            _billingAddressEdit.Country = "Albanien [AL]";
            _billingAddressEdit.Email = "marc.siegmund@six-group.commmm";
            _billingAddressEdit.Telephone = "0031 58 399 623777";
            _billingAddressEdit.Mobile = "0032 58 399 623777";
            _billingAddressEdit.Fax = "0033 58 399 623777";
            _billingAddressEdit.Web = "www.six-group.com/de-internnnn";

            _billingAddressEdit.CancelButton.Click();

            Assert.AreEqual(companyName, _billingAddressView.CompanyName);
            Assert.AreEqual(po, _billingAddressView.Po);
            Assert.AreEqual(adressAddition, _billingAddressView.AdressAddition);
            Assert.AreEqual(streetName, _billingAddressView.StreetName);
            Assert.AreEqual(zip, _billingAddressView.Zip);
            Assert.AreEqual(city, _billingAddressView.City);
            Assert.AreEqual(language, _billingAddressView.Language);
            Assert.AreEqual(country, _billingAddressView.Country);
            Assert.AreEqual(email, _billingAddressView.Email);
            Assert.AreEqual(telephone, _billingAddressView.Telephone);
            Assert.AreEqual(mobile, _billingAddressView.Mobile);
            Assert.AreEqual(fax, _billingAddressView.Fax);
            Assert.AreEqual(web, _billingAddressView.Web);
        }

        [TestMethod]
        public void EditBillingAddressWithInvalidDataFailed()
        {
            _customerMenu.BillingAddressEdit.Click();


            _billingAddressEdit.CompanyName = "SYR Sele Firma A$°";
            _billingAddressEdit.StreetName = "Hardturmstr. 201$°";
            _billingAddressEdit.Zip = "802$°";
            _billingAddressEdit.City = "Zürich$°";
            _billingAddressEdit.Po = "PFO1$°";
            _billingAddressEdit.AdressAddition = "Etage 3$°";
            _billingAddressEdit.Region = "Reg 3[]$°";
            _billingAddressEdit.Language = "Deutsch [de]";
            _billingAddressEdit.Country = "Schweiz [CH]";
            _billingAddressEdit.Email = "marc.siegmund@six-grou$°p.com";
            _billingAddressEdit.Telephone = "0031 58 399 6237$";
            _billingAddressEdit.Mobile = "0032 58 399 6237$";
            _billingAddressEdit.Fax = "0033 58 399 6237$";
            _billingAddressEdit.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            _billingAddressEdit.SaveButton.Click();

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
        public void EditBillingAddressWithoutCompanyNameFailed()
        {
            _customerMenu.BillingAddressEdit.Click();

            _billingAddressEdit.StreetName = "Hardturmstr. 201";
            _billingAddressEdit.Zip = "8021";
            _billingAddressEdit.City = "Zürich";
            _billingAddressEdit.Po = "PFO1";
            _billingAddressEdit.AdressAddition = "Etage 3";
            _billingAddressEdit.Language = "Deutsch [de]";
            _billingAddressEdit.Country = "Schweiz [CH]";
            _billingAddressEdit.Email = "marc.siegmund@six-group.com";
            _billingAddressEdit.Telephone = "0031 58 399 6237";
            _billingAddressEdit.Mobile = "0032 58 399 6237";
            _billingAddressEdit.Fax = "0033 58 399 6237";
            _billingAddressEdit.Web = "www.six-group.com/de-intern";

            _billingAddressEdit.CompanyName = "";
            _billingAddressEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!"));
            _billingAddressEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditBillingAddressWithIncompleteDataFailed()
        {
            _customerMenu.BillingAddressEdit.Click();

            _billingAddressEdit.CompanyName = "";
            _billingAddressEdit.StreetName = "";
            _billingAddressEdit.Zip = "";
            _billingAddressEdit.City = "";
            _billingAddressEdit.Po = "";
            _billingAddressEdit.AdressAddition = "";
            _billingAddressEdit.Region = "";

            _billingAddressEdit.Email = "";
            _billingAddressEdit.Telephone = "";
            _billingAddressEdit.Mobile = "";
            _billingAddressEdit.Fax = "";
            _billingAddressEdit.Web = "";

            _billingAddressEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Count == 4);

            _billingAddressEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditBillingAddressWithoutStreetAndNumberFailed()
        {
            _customerMenu.BillingAddressEdit.Click();

            _billingAddressEdit.CompanyName = "SYR Sele Firma A";
            _billingAddressEdit.StreetName = "";
            _billingAddressEdit.Zip = "8021";
            _billingAddressEdit.City = "Zürich";
            _billingAddressEdit.Po = "PFO1";
            _billingAddressEdit.AdressAddition = "Etage 3";
            _billingAddressEdit.Language = "Deutsch [de]";
            _billingAddressEdit.Country = "Schweiz [CH]";
            _billingAddressEdit.Email = "marc.siegmund@six-group.com";
            _billingAddressEdit.Telephone = "0031 58 399 6237";
            _billingAddressEdit.Mobile = "0032 58 399 6237";
            _billingAddressEdit.Fax = "0033 58 399 6237";
            _billingAddressEdit.Web = "www.six-group.com/de-intern";

            _billingAddressEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
            _billingAddressEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditBillingAddressWithoutCityFailed()
        {
            _customerMenu.BillingAddressEdit.Click();

            _billingAddressEdit.CompanyName = "SYR Sele Firma A";
            _billingAddressEdit.StreetName = "Hardturmstr. 201";
            _billingAddressEdit.Zip = "8021";
            _billingAddressEdit.City = "";
            _billingAddressEdit.Po = "PFO1";
            _billingAddressEdit.AdressAddition = "Etage 3";
            _billingAddressEdit.Language = "Deutsch [de]";
            _billingAddressEdit.Country = "Schweiz [CH]";
            _billingAddressEdit.Email = "marc.siegmund@six-group.com";
            _billingAddressEdit.Telephone = "0031 58 399 6237";
            _billingAddressEdit.Mobile = "0032 58 399 6237";
            _billingAddressEdit.Fax = "0033 58 399 6237";
            _billingAddressEdit.Web = "www.six-group.com/de-intern";

            _billingAddressEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));
            _billingAddressEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditBillingAddressWithoutZipFailed()
        {
            _customerMenu.BillingAddressEdit.Click();

            _billingAddressEdit.CompanyName = "SYR Sele Firma A";
            _billingAddressEdit.StreetName = "Hardturmstr. 201";
            _billingAddressEdit.Zip = "";
            _billingAddressEdit.City = "Zürich";
            _billingAddressEdit.Po = "PFO1";
            _billingAddressEdit.AdressAddition = "Etage 3";
            _billingAddressEdit.Language = "Deutsch [de]";
            _billingAddressEdit.Country = "Schweiz [CH]";
            _billingAddressEdit.Email = "marc.siegmund@six-group.com";
            _billingAddressEdit.Telephone = "0031 58 399 6237";
            _billingAddressEdit.Mobile = "0032 58 399 6237";
            _billingAddressEdit.Fax = "0033 58 399 6237";
            _billingAddressEdit.Web = "www.six-group.com/de-intern";

            _billingAddressEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
            _billingAddressEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditBillingAddressAndSave()
        {
            _menusTests.CustomerMenuCheck(_customerMenu);

            _customerMenu.BillingAddressEdit.Click();

            _billingAddressEdit.CompanyName = "SYR Standort SELE B";
            _billingAddressEdit.StreetName = "Am Bärenplatz 2";
            _billingAddressEdit.Zip = "8001";
            _billingAddressEdit.City = "Kreuzlingen";
            _billingAddressEdit.Po = "PO2-A";
            _billingAddressEdit.AdressAddition = "Level2";
            _billingAddressEdit.Email = "marc.siegmund@six-group.com/scs";
            _billingAddressEdit.Telephone = "+41 58 399 6237";
            _billingAddressEdit.Mobile = "+42 58 399 6237";
            _billingAddressEdit.Fax = "+43 58 399 6237";
            _billingAddressEdit.Web = "www.six-group.com";
            _billingAddressEdit.Language = "English [en]";
            _billingAddressEdit.Country = "Schweiz [CH]";

            _billingAddressCreate.SaveButton.Click();

            _menusTests.CustomerMenuCheck(_customerMenu);

            Assert.AreEqual("SYR Standort SELE B", _billingAddressView.CompanyName);
            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual("SYR Standort SELE B", _billingAddressView.CompanyName);
            Assert.AreEqual("Am Bärenplatz 2", _billingAddressView.StreetName);
            Assert.AreEqual("SYR Standort SELE B", _billingAddressView.CompanyName);
            Assert.AreEqual("8001", _billingAddressView.Zip);
            Assert.AreEqual("PO2-A", _billingAddressView.Po);
            Assert.AreEqual("Level2", _billingAddressView.AdressAddition);
            Assert.AreEqual("Kreuzlingen", _billingAddressView.City);
            Assert.AreEqual("English [en]", _billingAddressView.Language);
            Assert.AreEqual("Switzerland [CH]", _billingAddressView.Country);
            Assert.AreEqual("marc.siegmund@six-group.com/scs", _billingAddressView.Email);
            Assert.AreEqual("+41 58 399 6237", _billingAddressView.Telephone);
            Assert.AreEqual("+42 58 399 6237", _billingAddressView.Mobile);
            Assert.AreEqual("+43 58 399 6237", _billingAddressView.Fax);
            Assert.AreEqual("www.six-group.com", _billingAddressView.Web);
        }
    }
}