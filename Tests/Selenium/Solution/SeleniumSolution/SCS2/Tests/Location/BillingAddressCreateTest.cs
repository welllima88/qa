using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Location
{
    [TestClass]
    public class BillingAddressCreateTest
    {
        private static BillingAddressView _billingAddressView;
        private static BillingAddressCreate _billingAddressCreate;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static FormAlert _formAlert;
        private static MenusTest _menusTest;
        private static CustomerMenu _customerMenu;

        private long _dt;
        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _billingAddressCreate = new BillingAddressCreate();
            _billingAddressView = new BillingAddressView();
            _recentElements = new RecentElements();

            _navigationBar = new NavigationBar();
            _formAlert = new FormAlert();
            _customerMenu = new CustomerMenu();
            _menusTest = new MenusTest();
        }

        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=404871");
            _dt = DateTime.Now.Ticks; //timestamp for each test
        }

        [TestMethod]
        public void CreateBillingAddressWithInvalidDataFailed()
        {
            _customerMenu.LocationCreate.Click();

            _billingAddressCreate.CompanyName = "SYR Sele Firma A$°";
            _billingAddressCreate.StreetName = "Hardturmstr. 201$°";
            _billingAddressCreate.Zip = "802$°";
            _billingAddressCreate.City = "Zürich$°";
            _billingAddressCreate.Po = "PFO1$°";
            _billingAddressCreate.AdressAddition = "Etage 3$°";
            _billingAddressCreate.Region = "Reg 3[]$°";

            _billingAddressCreate.Language = "Deutsch [de]";
            _billingAddressCreate.Country = "Schweiz [CH]";
            _billingAddressCreate.Email = "marc.siegmund@six-grou$°p.com";
            _billingAddressCreate.Telephone = "0031 58 399 6237$";
            _billingAddressCreate.Mobile = "0032 58 399 6237$";
            _billingAddressCreate.Fax = "0033 58 399 6237$";
            _billingAddressCreate.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            _billingAddressCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            CollectionAssert.Contains(_formAlerts, "Firmenname: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "Zusatz: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "Telefon: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "Mobiltelefon: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "Fax: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "PLZ: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "Postfach: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "Ort: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "Region (Kurzzeichen): Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "Email: Dies ist keine gültige E-Mail Adresse!");
            CollectionAssert.Contains(_formAlerts, "Web: Dies ist keine gültige Web Adresse!");
            Assert.AreEqual(12, _formAlerts.Count);
        }

        [TestMethod]
        public void CreateBillingAddressWithIncompleteDataFailed()
        {
            _customerMenu.BillingAdressCreate.Click();

            _billingAddressCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(5, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "PLZ: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "Ort: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "Land: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateBillingAddressrWithoutCompanyNameFailed()
        {
            _customerMenu.LocationCreate.Click();

            _billingAddressCreate.CompanyName = "";
            _billingAddressCreate.StreetName = "Hardturmstr. 201";
            _billingAddressCreate.Zip = "8021";
            _billingAddressCreate.City = "Zürich";
            _billingAddressCreate.Po = "PFO1";
            _billingAddressCreate.AdressAddition = "Etage 3";
            _billingAddressCreate.Region = "Reg 55";
            _billingAddressCreate.Language = "Deutsch [de]";
            _billingAddressCreate.Country = "Schweiz [CH]";
            _billingAddressCreate.Email = "marc.siegmund@six-group.com";
            _billingAddressCreate.Telephone = "0031 58 399 6237";
            _billingAddressCreate.Mobile = "0032 58 399 6237";
            _billingAddressCreate.Fax = "0033 58 399 6237";
            _billingAddressCreate.Web = "www.six-group.com/de-intern";

            _billingAddressCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Firmenname: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateBillingAddressWithoutStreetAndNumberFailed()
        {
            _customerMenu.LocationCreate.Click();

            _billingAddressCreate.CompanyName = "SYR Sele Firma A";
            _billingAddressCreate.StreetName = "";
            _billingAddressCreate.Zip = "8021";
            _billingAddressCreate.City = "Zürich";
            _billingAddressCreate.Po = "PFO1";
            _billingAddressCreate.AdressAddition = "Etage 3";
            _billingAddressCreate.Region = "Reg 55";
            _billingAddressCreate.Language = "Deutsch [de]";
            _billingAddressCreate.Country = "Schweiz [CH]";
            _billingAddressCreate.Email = "marc.siegmund@six-group.com";
            _billingAddressCreate.Telephone = "0031 58 399 6237";
            _billingAddressCreate.Mobile = "0032 58 399 6237";
            _billingAddressCreate.Fax = "0033 58 399 6237";
            _billingAddressCreate.Web = "www.six-group.com/de-intern";

            _billingAddressCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateBillingAddressWithoutCityFailed()
        {
            _customerMenu.LocationCreate.Click();

            _billingAddressCreate.CompanyName = "SYR Sele Firma A";
            _billingAddressCreate.StreetName = "Hardturmstr. 201";
            _billingAddressCreate.Zip = "8021";
            _billingAddressCreate.City = "";
            _billingAddressCreate.Po = "PFO1";
            _billingAddressCreate.AdressAddition = "Etage 3";
            _billingAddressCreate.Region = "Reg 55";
            _billingAddressCreate.Language = "Deutsch [de]";
            _billingAddressCreate.Country = "Schweiz [CH]";
            _billingAddressCreate.Email = "marc.siegmund@six-group.com";
            _billingAddressCreate.Telephone = "0031 58 399 6237";
            _billingAddressCreate.Mobile = "0032 58 399 6237";
            _billingAddressCreate.Fax = "0033 58 399 6237";
            _billingAddressCreate.Web = "www.six-group.com/de-intern";

            _billingAddressCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Ort: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateBillingAddressWithoutZipFailed()
        {
            _customerMenu.LocationCreate.Click();

            _billingAddressCreate.CompanyName = "SYR Sele Firma A";
            _billingAddressCreate.StreetName = "Hardturmstr. 201";
            _billingAddressCreate.Zip = "";
            _billingAddressCreate.City = "Zürich";
            _billingAddressCreate.Po = "PFO1";
            _billingAddressCreate.AdressAddition = "Etage 3";
            _billingAddressCreate.Region = "Reg 55";
            _billingAddressCreate.Language = "Deutsch [de]";
            _billingAddressCreate.Country = "Schweiz [CH]";
            _billingAddressCreate.Email = "marc.siegmund@six-group.com";
            _billingAddressCreate.Telephone = "0031 58 399 6237";
            _billingAddressCreate.Mobile = "0032 58 399 6237";
            _billingAddressCreate.Fax = "0033 58 399 6237";
            _billingAddressCreate.Web = "www.six-group.com/de-intern";

            _billingAddressCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "PLZ: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateBillingAddressAndSave()
        {
            _menusTest.CustomerMenuCheck(_customerMenu);
            _customerMenu.BillingAdressCreate.Click();

            _billingAddressCreate.CompanyName = "SYR ReAd SELE A";
            _billingAddressCreate.StreetName = "Rechnungsallee 112";
            _billingAddressCreate.Zip = "10010";
            _billingAddressCreate.City = "Stuttgart";
            _billingAddressCreate.Po = "PO1";

            _billingAddressCreate.Language = "Swedish [sv]";
            _billingAddressCreate.Country = "Schweden [SE]";
            _billingAddressCreate.Email = "marc.siegmund@six-group.com";
            _billingAddressCreate.Telephone = "0031 58 399 6237";
            _billingAddressCreate.Mobile = "0032 58 399 6237";
            _billingAddressCreate.Fax = "0033 58 399 6237";
            _billingAddressCreate.Web = "www.six-group.com/de" + _dt;

            _billingAddressCreate.SaveButton.Click();

            _menusTest.CustomerMenuCheck(_customerMenu);

            Assert.AreEqual("SYR ReAd SELE A", _billingAddressView.CompanyName);
            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            //Assert.AreEqual(locId, _billingAddressView.Guid);
            Assert.AreEqual("SYR ReAd SELE A", _billingAddressView.CompanyName);

            Assert.AreEqual("Rechnungsallee 112", _billingAddressView.StreetName);
            Assert.AreEqual("SYR ReAd SELE A", _billingAddressView.CompanyName);
            Assert.AreEqual("10010", _billingAddressView.Zip);
            Assert.AreEqual("Stuttgart", _billingAddressView.City);
            Assert.AreEqual("Swedish [sv]", _billingAddressView.Language);
            Assert.AreEqual("Sweden [SE]", _billingAddressView.Country);
            Assert.AreEqual("marc.siegmund@six-group.com", _billingAddressView.Email);
            Assert.AreEqual("0031 58 399 6237", _billingAddressView.Telephone);
            Assert.AreEqual("0032 58 399 6237", _billingAddressView.Mobile);
            Assert.AreEqual("0033 58 399 6237", _billingAddressView.Fax);
            Assert.AreEqual("www.six-group.com/de" + _dt, _billingAddressView.Web);
        }

        [TestMethod]
        public void CreateBillingAddressWithMinimalAndSave()
        {
            _customerMenu.BillingAdressCreate.Click();

            _billingAddressCreate.CompanyName = "SYR ReAd SELE A";
            _billingAddressCreate.StreetName = "Rechnungsallee 112";
            _billingAddressCreate.Zip = "10010";
            _billingAddressCreate.City = "Stuttgart";
            _billingAddressCreate.Po = "PO1";

            _billingAddressCreate.Language = "Swedish [sv]";
            _billingAddressCreate.Country = "Schweden [SE]";
            _billingAddressCreate.Email = "marc.siegmund@six-group.com";
            _billingAddressCreate.Telephone = "0031 58 399 6237";
            _billingAddressCreate.Mobile = "0032 58 399 6237";
            _billingAddressCreate.Fax = "0033 58 399 6237";
            _billingAddressCreate.Web = "www.six-group.com/de" + _dt;

            _billingAddressCreate.SaveButton.Click();

            //var locId = _driver.PageSource.;
            Assert.AreEqual("SYR ReAd SELE A", _billingAddressView.CompanyName);
            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            //Assert.AreEqual(locId, _billingAddressView.Guid);
            Assert.AreEqual("SYR ReAd SELE A", _billingAddressView.CompanyName);

            Assert.AreEqual("Rechnungsallee 112", _billingAddressView.StreetName);
            Assert.AreEqual("SYR ReAd SELE A", _billingAddressView.CompanyName);
            Assert.AreEqual("10010", _billingAddressView.Zip);
            Assert.AreEqual("Stuttgart", _billingAddressView.City);
            Assert.AreEqual("Swedish [sv]", _billingAddressView.Language);
            Assert.AreEqual("Sweden [SE]", _billingAddressView.Country);
            Assert.AreEqual("marc.siegmund@six-group.com", _billingAddressView.Email);
            Assert.AreEqual("0031 58 399 6237", _billingAddressView.Telephone);
            Assert.AreEqual("0032 58 399 6237", _billingAddressView.Mobile);
            Assert.AreEqual("0033 58 399 6237", _billingAddressView.Fax);
            Assert.AreEqual("www.six-group.com/de" + _dt, _billingAddressView.Web);
        }
    }
}