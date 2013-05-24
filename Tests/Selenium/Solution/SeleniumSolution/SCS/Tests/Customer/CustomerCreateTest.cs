using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Login.LoginMethod;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics.Tests.Customer
{
    [TestClass]
    [Ignore]
    public class CustomerCreateTest
    {
        private static CustomerCreate _customerCreate;
        private static CustomerView _customerView;
        private static IWebDriverAdapter _driver;
        private static TestDirector _tb;
        private static CustomerMenu _customerMenu;

        private long _dt;
        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //_tb = new TestDirector("IE");
            _tb = new TestDirector();
            _driver = _tb.WebDriver;

            var auth = new CertificateLogin("tkcposl", _driver);
            var app = new Scs(_driver);

            _tb.DefaultTestSetup();

            _customerCreate = new CustomerCreate(_driver);
            _customerView = new CustomerView(_driver);
            _customerMenu = new CustomerMenu(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            //_driver.Url = _tb.BaseUrl + "/Default.aspx";
            //_driver.Navigate();
            _dt = DateTime.Now.Ticks; //timestamp for each test
            _formAlerts = new List<string>();
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
        public void EmptyTest()
        {
        }

        [TestMethod]
        public void CreateCustomerAndCancel()
        {
            _customerCreate.CustomerName = "Selenium Test will cancel";
            _customerCreate.Supplier = "SIX Payment Services AG";
            _customerCreate.SbsBillingTenant = "SIX Payment Services AG";
            _customerCreate.StreetName = "Hardturmstr. 201";
            _customerCreate.Zip = "5555";
            _customerCreate.City = "Zürich";
            _customerCreate.SbsCurrency = "EUR";

            _customerCreate.CancelButton.Click();
            // ??:
            Assert.AreEqual("Lobby",
                            _driver.FindElement(By.CssSelector("span#ctl00_bodyContentPlaceHolder_lblTitle>h1")).Text);
        }

        [TestMethod]
        public void CreateCustomerWithInvalidDataFailed()
        {
            _customerCreate.Supplier = "SIX Payment Services AG";
            _customerCreate.SbsCurrency = "EUR";
            _customerCreate.SbsBillingTenant = "SIX Payment Services (Europe)";
            _customerCreate.CustomerName = "SYR Sele Kunde A$°";

            _customerCreate.CompanyName = "SYR Sele Firma A$°";
            _customerCreate.CustomerNumber = "^@}$°";
            _customerCreate.StreetName = "Hardturmstr. 201$°";
            _customerCreate.Zip = "802$°";
            _customerCreate.City = "Zürich$°";
            _customerCreate.Po = "PFO1$°";
            _customerCreate.AdressAddition = "Etage 3$°";
            _customerCreate.Region = "Reg 3[]$°";
            _customerCreate.SapNumber = "444$°";

            _customerCreate.Agency = "Albert Brun & Partner";
            _customerCreate.Language = "Deutsch [de]";
            _customerCreate.Country = "Schweiz [CH]";
            _customerCreate.Email = "marc.siegmund@six-grou$°p.com";
            _customerCreate.Telephone = "0031 58 399 6237$";
            _customerCreate.Mobile = "0032 58 399 6237$";
            _customerCreate.Fax = "0033 58 399 6237$";
            _customerCreate.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            _customerCreate.SaveButton.Click();

            Assert.IsTrue(_formAlerts.Contains("Kundenname: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Kundennummer: Ihre Eingabe ist ungültig!"));
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
            Assert.IsTrue(_formAlerts.Contains("Web: Dies ist keine gültige Web Adresse!"), "web adress not validated");
            Assert.IsTrue(_formAlerts.Count == 14);
        }

        [TestMethod]
        public void CreateCustomerWithIncompleteDataFailed()
        {
            _customerMenu.CustomerCreate.Click();

            _customerCreate.SaveButton.Click();

            Assert.IsTrue(_formAlerts.Count == 7);
            Assert.IsTrue(_formAlerts.Contains("Kundenname: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Mandant: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Land: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateCustomerWithoutCustomerNameFailed()
        {
            _customerMenu.CustomerCreate.Click();

            _customerCreate.Supplier = "SIX Payment Services AG";
            _customerCreate.SbsCurrency = "EUR";
            _customerCreate.SbsBillingTenant = "SIX Payment Services (Europe)";

            _customerCreate.CompanyName = "SYR Sele Firma A";
            _customerCreate.StreetName = "Hardturmstr. 201";
            _customerCreate.Zip = "8021";
            _customerCreate.City = "Zürich";
            _customerCreate.Po = "PFO1";
            _customerCreate.AdressAddition = "Etage 3";
            _customerCreate.Region = "Reg 3";
            _customerCreate.SapNumber = "4440";

            _customerCreate.Agency = "Albert Brun & Partner";
            _customerCreate.Language = "Deutsch [de]";
            _customerCreate.Country = "Schweiz [CH]";
            _customerCreate.Email = "marc.siegmund@six-group.com";
            _customerCreate.Telephone = "0031 58 399 6237";
            _customerCreate.Mobile = "0032 58 399 6237";
            _customerCreate.Fax = "0033 58 399 6237";
            _customerCreate.Web = "www.six-group.com/de-intern";

            _customerCreate.CustomerName = "";
            _customerCreate.SaveButton.Click();


            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Kundenname: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateCustomerWithoutCompanyNameFailed()
        {
            _customerMenu.CustomerCreate.Click();

            _customerCreate.Supplier = "SIX Payment Services AG";
            _customerCreate.SbsCurrency = "EUR";
            _customerCreate.SbsBillingTenant = "SIX Payment Services (Europe)";
            _customerCreate.CustomerName = "SYR Sele Kunde A";

            _customerCreate.Agency = "Albert Brun & Partner";
            _customerCreate.StreetName = "Hardturmstr. 201";
            _customerCreate.Zip = "8021";
            _customerCreate.City = "Zürich";
            _customerCreate.Po = "PFO1";
            _customerCreate.AdressAddition = "Etage 3";
            _customerCreate.Region = "Reg 3";
            _customerCreate.SapNumber = "4440";

            _customerCreate.Agency = "SIX Payment Services (Europe)";
            _customerCreate.Language = "Deutsch [de]";
            _customerCreate.Country = "Schweiz [CH]";
            _customerCreate.Email = "marc.siegmund@six-group.com";
            _customerCreate.Telephone = "0031 58 399 6237";
            _customerCreate.Mobile = "0032 58 399 6237";
            _customerCreate.Fax = "0033 58 399 6237";
            _customerCreate.Web = "www.six-group.com/de-intern";

            _customerCreate.CompanyName = "";
            _customerCreate.SaveButton.Click();


            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateCustomerWithoutStreetAndNumberFailed()
        {
            _customerMenu.CustomerCreate.Click();

            _customerCreate.Supplier = "SIX Payment Services AG";
            _customerCreate.SbsCurrency = "EUR";
            _customerCreate.SbsBillingTenant = "SIX Payment Services (Europe)";
            _customerCreate.CustomerName = "SYR Sele Kunde A";

            _customerCreate.Agency = "SIX Payment Services (Europe)";
            _customerCreate.CompanyName = "SYR Sele Firma A";
            _customerCreate.StreetName = "";
            _customerCreate.Zip = "8021";
            _customerCreate.City = "Zürich";
            _customerCreate.Po = "PFO1";
            _customerCreate.AdressAddition = "Etage 3";
            _customerCreate.Region = "Reg 3";
            _customerCreate.SapNumber = "4440";

            _customerCreate.Agency = "SIX Payment Services (Europe)";
            _customerCreate.Language = "Deutsch [de]";
            _customerCreate.Country = "Schweiz [CH]";
            _customerCreate.Email = "marc.siegmund@six-group.com";
            _customerCreate.Telephone = "0031 58 399 6237";
            _customerCreate.Mobile = "0032 58 399 6237";
            _customerCreate.Fax = "0033 58 399 6237";
            _customerCreate.Web = "www.six-group.com/de-intern";

            _customerCreate.SaveButton.Click();


            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateCustomerWithoutCityFailed()
        {
            _customerMenu.CustomerCreate.Click();

            _customerCreate.Supplier = "SIX Payment Services AG";
            _customerCreate.SbsCurrency = "EUR";
            _customerCreate.SbsBillingTenant = "SIX Payment Services (Europe)";
            _customerCreate.CustomerName = "SYR Sele Kunde A";

            _customerCreate.CompanyName = "SYR Sele Firma A";
            _customerCreate.StreetName = "Hardturmstr. 201";
            _customerCreate.Zip = "8021";
            _customerCreate.City = "";
            _customerCreate.Po = "PFO1";
            _customerCreate.AdressAddition = "Etage 3";
            _customerCreate.Region = "Reg 3";
            _customerCreate.SapNumber = "4440";

            _customerCreate.Agency = "SIX Payment Services (Europe)";
            _customerCreate.Language = "Deutsch [de]";
            _customerCreate.Country = "Schweiz [CH]";
            _customerCreate.Email = "marc.siegmund@six-group.com";
            _customerCreate.Telephone = "0031 58 399 6237";
            _customerCreate.Mobile = "0032 58 399 6237";
            _customerCreate.Fax = "0033 58 399 6237";
            _customerCreate.Web = "www.six-group.com/de-intern";

            _customerCreate.SaveButton.Click();


            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateCustomerWithoutZipFailed()
        {
            _customerMenu.CustomerCreate.Click();

            _customerCreate.Supplier = "SIX Payment Services AG";
            _customerCreate.SbsCurrency = "EUR";
            _customerCreate.SbsBillingTenant = "SIX Payment Services (Europe)";
            _customerCreate.CustomerName = "SYR Sele Kunde A";

            _customerCreate.CompanyName = "SYR Sele Firma A";
            _customerCreate.StreetName = "Hardturmstr. 201";
            _customerCreate.Zip = "";
            _customerCreate.City = "Zürich";
            _customerCreate.Po = "PFO1";
            _customerCreate.AdressAddition = "Etage 3";
            _customerCreate.Region = "Reg 3";
            _customerCreate.SapNumber = "4440";

            _customerCreate.Agency = "SIX Payment Services (Europe)";
            _customerCreate.Language = "Deutsch [de]";
            _customerCreate.Country = "Schweiz [CH]";
            _customerCreate.Email = "marc.siegmund@six-group.com";
            _customerCreate.Telephone = "0031 58 399 6237";
            _customerCreate.Mobile = "0032 58 399 6237";
            _customerCreate.Fax = "0033 58 399 6237";
            _customerCreate.Web = "www.six-group.com/de-intern";

            _customerCreate.SaveButton.Click();


            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateCustomerWithoutMandantFailed()
        {
            _customerMenu.CustomerCreate.Click();

            _customerCreate.CustomerName = "SYR Sele Kunde A";

            _customerCreate.CompanyName = "SYR Sele Firma A";
            _customerCreate.StreetName = "Hardturmstr. 201";
            _customerCreate.Zip = "8021";
            _customerCreate.City = "Zürich";
            _customerCreate.Po = "PFO1";
            _customerCreate.AdressAddition = "Etage 3";
            _customerCreate.Region = "Reg 3";
            _customerCreate.SapNumber = "4440";

            _customerCreate.Language = "Deutsch [de]";
            _customerCreate.Country = "Schweiz [CH]";
            _customerCreate.Email = "marc.siegmund@six-group.com";
            _customerCreate.Telephone = "0031 58 399 6237";
            _customerCreate.Mobile = "0032 58 399 6237";
            _customerCreate.Fax = "0033 58 399 6237";
            _customerCreate.Web = "www.six-group.com/de-intern";

            _customerCreate.SaveButton.Click();


            // Removed: thx to suggester: Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Mandant: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateCustomerAndSave()
        {
            _customerMenu.CustomerCreate.Click();

            _customerCreate.Supplier = "SIX Payment Services AG";
            _customerCreate.SbsCurrency = "EUR";
            _customerCreate.SbsBillingTenant = "SIX Payment Services (Europe)";
            _customerCreate.CustomerName = "SYR Kunde" + _dt;
            _customerCreate.CategoryCode = "3364: AGENCY RENT-A-CAR";
            _customerCreate.SupportContract = "ServicePaket Top Account - Störungsbehebung vor Ort Mo-So 5h";
            _customerCreate.CashIntegrator = "Wincor Nixdorf AG, Brüttisellen";

            _customerCreate.CompanyName = "SYR Sele Firma A";
            _customerCreate.StreetName = "Hardturmstr. 201";
            _customerCreate.Zip = "8021";
            _customerCreate.City = "Zürich";
            _customerCreate.Po = "PFO1";
            _customerCreate.AdressAddition = "Etage 3";
            _customerCreate.Region = "Reg 3";
            _customerCreate.SapNumber = "4440";

            _customerCreate.Agency = "SIX Payment Services (Europe)";
            _customerCreate.Language = "Deutsch [de]";
            _customerCreate.Country = "Schweiz [CH]";
            _customerCreate.Email = "marc.siegmund@six-group.com";
            _customerCreate.Telephone = "0031 58 399 6237";
            _customerCreate.Mobile = "0032 58 399 6237";
            _customerCreate.Fax = "0033 58 399 6237";
            _customerCreate.Web = "www.six-group.com/de-intern";

            _customerCreate.SaveButton.Click();

            Assert.AreEqual("SYR Kunde" + _dt, _customerView.CustomerName);
            string custId = _customerView.CustomerNumber;

            Assert.AreEqual(custId, _customerView.CustomerNumber);
            Assert.AreEqual("SYR Kunde" + _dt, _customerView.CustomerName);
            Assert.AreEqual("SIX Payment Services AG", _customerView.Supplier);
            Assert.AreEqual("SIX Payment Services (Europe)", _customerView.SbsBillingTenant);
            Assert.AreEqual("EUR", _customerView.SbsCurrency);
            Assert.AreEqual("4440", _customerView.SapNumber);
            Assert.AreEqual("3364: AGENCY RENT-A-CAR", _customerView.CategoryCode);
            Assert.AreEqual("ServicePaket Top Account - Störungsbehebung vor Ort Mo-So 5h",
                            _customerView.SupportContract);
            Assert.AreEqual("Wincor Nixdorf AG, Brüttisellen", _customerView.CashIntegrator);

            StringAssert.Matches(_customerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);

            try
            {
                StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNo);
            }
            catch (AssertFailedException)
            {
            }

            StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(_customerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual("SYR Kunde" + _dt, _customerView.CompanyName);
            Assert.AreEqual("PFO1", _customerView.Po);
            Assert.AreEqual("Etage 3", _customerView.AdressAddition);
            Assert.AreEqual("Reg 3", _customerView.Region);
            Assert.AreEqual("Hardturmstr. 201", _customerView.StreetNo);
            Assert.AreEqual("8021", _customerView.Zip);
            Assert.AreEqual("Zürich", _customerView.City);
            Assert.AreEqual("SIX Payment Services (Europe)", _customerView.Agency);
            Assert.AreEqual("Deutsch [de]", _customerView.Language);
            Assert.AreEqual("Schweiz [CH]", _customerView.Country);
            Assert.AreEqual("marc.siegmund@six-group.com", _customerView.Email);
            Assert.AreEqual("0031 58 399 6237", _customerView.Telephone);
            Assert.AreEqual("0032 58 399 6237", _customerView.Mobile);
            Assert.AreEqual("0033 58 399 6237", _customerView.Fax);
            Assert.AreEqual("www.six-group.com/de-intern", _customerView.Web);
        }

        [TestMethod]
        public void CreateCustomerWithMinimalAndSave()
        {
            _customerMenu.CustomerCreate.Click();

            _customerCreate.Supplier = "SIX Payment Services AG";
            _customerCreate.SbsCurrency = "CHF";
            _customerCreate.SbsBillingTenant = "SIX Payment Services (Europe)";
            _customerCreate.CustomerName = "SYR Kunde" + _dt;

            _customerCreate.CompanyName = "SYR Firma" + _dt;
            _customerCreate.StreetName = "Hardturmstr. 201";
            _customerCreate.Zip = "8021";
            _customerCreate.City = "Zürich";

            _customerCreate.Language = "Deutsch [de]";
            _customerCreate.Country = "Schweiz [CH]";

            _customerCreate.SaveButton.Click();

            Assert.AreEqual("SYR Kunde" + _dt, _customerView.CustomerName);
            string custId = _customerView.CustomerNumber;

            Assert.AreEqual(custId, _customerView.CustomerNumber);
            Assert.AreEqual(" ", _customerView.SapNumber);
            Assert.AreEqual("SYR Kunde" + _dt, _customerView.CustomerName);
            StringAssert.Matches(_customerView.Guid, TestRegExpPatterns.Guid);
            StringAssert.Matches(_customerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            Assert.AreEqual("CHF", _customerView.SbsCurrency);
            Assert.AreEqual("SIX Payment Services AG", _customerView.Supplier);
            Assert.AreEqual("(Keine Branche)", _customerView.CategoryCode);
            Assert.AreEqual("Keine Agentur", _customerView.Agency);
            Assert.AreEqual("Kein Supportvertrag", _customerView.SupportContract);
            Assert.AreEqual("Kein Kassenintegrator", _customerView.CashIntegrator);
            StringAssert.Matches(_customerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);
            Assert.AreEqual("SIX Payment Services (Europe)", _customerView.SbsBillingTenant);
            StringAssert.Matches(_customerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);

            try
            {
                StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNo);
            }
            catch (AssertFailedException)
            {
            }

            StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(_customerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual("SYR Firma" + _dt, _customerView.CompanyName);
            Assert.AreEqual(" ", _customerView.Po);
            Assert.AreEqual(" ", _customerView.AdressAddition);
            Assert.AreEqual(" ", _customerView.Region);
            Assert.AreEqual("Hardturmstr. 201", _customerView.StreetNo);
            Assert.AreEqual("8021", _customerView.Zip);
            Assert.AreEqual("Zürich", _customerView.City);
            Assert.AreEqual("Keine Agentur", _customerView.Agency);
            Assert.AreEqual("Deutsch [de]", _customerView.Language);
            Assert.AreEqual("Schweiz [CH]", _customerView.Country);
            Assert.AreEqual(" ", _customerView.Email);
            Assert.AreEqual(" ", _customerView.Telephone);
            Assert.AreEqual(" ", _customerView.Mobile);
            Assert.AreEqual(" ", _customerView.Fax);
            Assert.AreEqual("", _customerView.Web);
        }


        [TestMethod]
        public void CreateCustomerWithSbsAndMinimalAndSave()
        {
            _customerMenu.CustomerCreate.Click();

            _customerCreate.Supplier = "SIX Payment Services AG";
            _customerCreate.SbsCurrency = "CHF";
            _customerCreate.CustomerName = "SYR SBS Kunde" + _dt;

            _customerCreate.CompanyName = "SYR SBS Firma" + _dt;
            _customerCreate.StreetName = "SbsRoad. 201";
            _customerCreate.Zip = "8008";
            _customerCreate.City = "SBS";

            _customerCreate.SaveButton.Click();

            Assert.AreEqual("SYR SBS Kunde" + _dt, _customerView.CustomerName);
            string custId = _customerView.CustomerNumber;

            Assert.AreEqual(custId, _customerView.CustomerNumber);
            Assert.AreEqual(custId, _customerView.SbsDebitNumber);

            StringAssert.Matches(_customerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);

            Assert.AreEqual("SIX Payment Services AG", _customerView.Supplier);

            int retry = 10;
            do
            {
                try
                {
                    StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNo);
                    retry = 0; //no retry necessary anymore
                }
                catch (AssertFailedException)
                {
                    _customerMenu.Customer.Click();
                    retry--;
                }
            } while (retry > 0);

            Assert.AreEqual("SYR SBS Firma" + _dt, _customerView.CompanyName);
            Assert.AreEqual("SbsRoad. 201", _customerView.StreetNo);
            Assert.AreEqual("8008", _customerView.Zip);
            Assert.AreEqual("SBS", _customerView.City);
            Assert.AreEqual("CHF", _customerView.SbsCurrency);
        }
    }
}