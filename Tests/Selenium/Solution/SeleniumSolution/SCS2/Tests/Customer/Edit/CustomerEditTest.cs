using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Customer.Edit
{
    [TestClass]
    public class CustomerEditTest
    {
        private static CustomerEdit _customerEdit;
        private static CustomerView _customerView;
        private static IWebDriverAdapter _driver;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static TestDirector _tb;
        private static FormAlert _formAlert;
        private static CustomerMenu _customerMenu;
        private static MenusTest _menusTests;
        private static LobbyView _lobby;
        private static long _dt;
        private List<string> _formAlerts;
        private static string _custId;
        private static string _customerName;
        private static string _supplier;
        private static string _sbsBillingTenant;
        private static string _sbsCurrency;
        private static string _sapNumber;
        private static string _sbsDebitNumber;
        private static string _sbsAdressNumber;
        private static string _ep2MerchantId;
        private static string _companyName;
        private static string _po;
        private static string _adressAddition;
        private static string _streetName;
        private static string _zip;
        private static string _city;
        private static string _agency;
        private static string _language;
        private static string _country;
        private static string _email;
        private static string _telephone;
        private static string _mobile;
        private static string _fax;
        private static string _web;
        private static string _segment;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login and 10 seconds response timeout

            _customerMenu = new CustomerMenu(_driver);
            _customerEdit = new CustomerEdit(_driver);
            _customerView = new CustomerView(_driver);
            _recentElements = new RecentElements(_driver);
            _navigationBar = new NavigationBar(_driver);
            _formAlert = new FormAlert(_driver);
            _menusTests = new MenusTest();
            _lobby = new LobbyView(_driver);
            
            _driver.Url = _tb.BaseUrl + "/Pages/Customer/CustomerEdit.aspx?CustomerId=405125";
            _dt = DateTime.Now.Ticks; //timestamp for each test

            _custId = _customerView.CustomerNumber;
            _customerName = _customerView.CustomerName;
            _supplier = _customerView.Supplier;

            _sbsBillingTenant = _customerView.SbsBillingTenant;
            _sbsCurrency = _customerView.SbsCurrency;
            _sapNumber = _customerView.SapNumber;
            _sbsDebitNumber = _customerView.SbsDebitNumber;
            _sbsAdressNumber = _customerView.SbsAdressNumber;
            _segment = _customerView.Segment;

            _ep2MerchantId = _customerView.Ep2MerchantId;

            _companyName = _customerView.CompanyName;
            _po = _customerView.Po;
            _adressAddition = _customerView.AdressAddition;
            _streetName = _customerView.StreetNo;
            _zip = _customerView.Zip;
            _city = _customerView.City;
            _agency = _customerView.Agency;
            _language = _customerView.Language;
            _country = _customerView.Country;
            _email = _customerView.Email;
            _telephone = _customerView.Telephone;
            _mobile = _customerView.Mobile;
            _fax = _customerView.Fax;
            _web = _customerView.Web;
        }

        [TestInitialize]
        public void TestInit()
        {
            
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
        public void CheckLocationMenu()
        {
            _menusTests.CustomerMenuCheck(_customerMenu);
            _customerMenu.CustomerEdit.Click();
            _customerEdit.CancelButton.Click();
            _menusTests.CustomerMenuCheck(_customerMenu);
        }

        [TestMethod]
        public void EditCustomerAndCancel()
        {

            _customerMenu.CustomerEdit.Click();

            _customerEdit.CustomerName = "SYR Sele Kunde AAA";

            _customerEdit.CompanyName = "SYR Sele Firma AAA";
            _customerEdit.StreetName = "Hardturmstr. 2011";
            _customerEdit.Zip = "80222";
            _customerEdit.City = "Zürichhh";
            _customerEdit.Po = "PFO111";
            _customerEdit.AdressAddition = "Etage 333";
            _customerEdit.Region = "Reggg";
            _customerEdit.SapNumber = "4449";

            _customerEdit.Agency = "C01 Bellia Antoine";
            _customerEdit.Language = "Kroatisch [hr]";
            _customerEdit.Country = "Albanien [AL]";
            _customerEdit.Email = "marc.siegmund@six-group.commmm";
            _customerEdit.Telephone = "0031 58 399 623777";
            _customerEdit.Mobile = "0032 58 399 623777";
            _customerEdit.Fax = "0033 58 399 623777";
            _customerEdit.Web = "www.six-group.com/de-internnnn";

            _customerEdit.CancelButton.Click();

            Assert.AreEqual(_custId, _customerView.CustomerNumber);
            Assert.AreEqual(_customerName, _customerView.CustomerName);
            Assert.AreEqual(_supplier, _customerView.Supplier);
            Assert.AreEqual(_sbsDebitNumber, _customerView.SbsDebitNumber);
            Assert.AreEqual(_sbsAdressNumber, _customerView.SbsAdressNumber);
            Assert.AreEqual(_sbsBillingTenant, _customerView.SbsBillingTenant);
            Assert.AreEqual(_sbsCurrency, _customerView.SbsCurrency);
            Assert.AreEqual(_sapNumber, _customerView.SapNumber);
            Assert.AreEqual(_segment, _customerView.Segment);
            Assert.AreEqual(_ep2MerchantId, _customerView.Ep2MerchantId);

            StringAssert.Matches(_customerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(_customerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual(_companyName, _customerView.CompanyName);
            Assert.AreEqual(_po, _customerView.Po);
            Assert.AreEqual(_adressAddition, _customerView.AdressAddition);
            Assert.AreEqual(_streetName, _customerView.StreetNo);
            Assert.AreEqual(_zip, _customerView.Zip);
            Assert.AreEqual(_city, _customerView.City);
            Assert.AreEqual(_agency, _customerView.Agency);
            Assert.AreEqual(_language, _customerView.Language);
            Assert.AreEqual(_country, _customerView.Country);
            Assert.AreEqual(_email, _customerView.Email);
            Assert.AreEqual(_telephone, _customerView.Telephone);
            Assert.AreEqual(_mobile, _customerView.Mobile);
            Assert.AreEqual(_fax, _customerView.Fax);
            Assert.AreEqual(_web, _customerView.Web);
        }

        [Ignore]
        [TestMethod]
        public void EditCustomerDoesNotAllowCustomerNumberChange()
        {
            throw new NotImplementedException();
        }

        [Ignore]
        [TestMethod]
        public void EditCustomerDoesNotAllowSupplierChange()
        {
            throw new NotImplementedException();
        }

        [Ignore]
        [TestMethod]
        public void EditCustomerDoesNotAllowSbsBillingTenantChange()
        {
            throw new NotImplementedException();
        }

        [Ignore]
        [TestMethod]
        public void EditCustomerDoesNotAllowSbsCurrencyChange()
        {
            throw new NotImplementedException();
            //Todo implement ignored tests
        }

        [TestMethod]
        public void EditCustomerWithInvalidDataFailed()
        {
            _customerMenu.CustomerEdit.Click();

            _customerEdit.CustomerName = "SYR Sele Kunde A$°";

            _customerEdit.CompanyName = "SYR Sele Firma A$°";
            _customerEdit.StreetName = "Hardturmstr. 201$°";
            _customerEdit.Zip = "802$°";
            _customerEdit.City = "Zürich$°";
            _customerEdit.Po = "PFO1$°";
            _customerEdit.AdressAddition = "Etage 3$°";
            _customerEdit.Region = "Reg 3[]$°";
            _customerEdit.SapNumber = "4}$°";

            _customerEdit.Agency = "SIX Payment Services (Europe)";
            _customerEdit.Language = "Deutsch [de]";
            _customerEdit.Country = "Schweiz [CH]";
            _customerEdit.Email = "marc.siegmund@six-grou$°p.com";
            _customerEdit.Telephone = "0031 58 399 6237}$°";
            _customerEdit.Mobile = "0032 58 399 6237}$°";
            _customerEdit.Fax = "0033 58 399 6237}$°";
            _customerEdit.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            _customerEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Contains("Kundenname: Ungültige Zeichen gefunden!"));
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
            Assert.IsTrue(_formAlerts.Count == 13);
        }

        [TestMethod]
        public void EditCustomerWithoutCompanyNameFailed()
        {
            _customerMenu.CustomerEdit.Click();

            _customerEdit.CustomerName = "SYR Sele Kunde A";

            _customerEdit.StreetName = "Hardturmstr. 201";
            _customerEdit.Zip = "8021";
            _customerEdit.City = "Zürich";
            _customerEdit.Po = "PFO1";
            _customerEdit.AdressAddition = "Etage 3";
            _customerEdit.Region = "Reg 55";
            _customerEdit.SapNumber = "4440";

            _customerEdit.Agency = "SIX Payment Services (Europe)";
            _customerEdit.Language = "Deutsch [de]";
            _customerEdit.Country = "Schweiz [CH]";
            _customerEdit.Email = "marc.siegmund@six-group.com";
            _customerEdit.Telephone = "0031 58 399 6237";
            _customerEdit.Mobile = "0032 58 399 6237";
            _customerEdit.Fax = "0033 58 399 6237";
            _customerEdit.Web = "www.six-group.com/de-intern";

            _customerEdit.CompanyName = "";
            _customerEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!"));
            _customerEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditCustomerWithIncompleteDataFailed()
        {
            _customerMenu.CustomerEdit.Click();

            _customerEdit.CustomerName = "";
            _customerEdit.CompanyName = "";
            _customerEdit.StreetName = "";
            _customerEdit.Zip = "";
            _customerEdit.City = "";
            _customerEdit.Po = "";
            _customerEdit.AdressAddition = "";
            _customerEdit.Region = "";
            _customerEdit.SapNumber = "";

            _customerEdit.Email = "";
            _customerEdit.Telephone = "";
            _customerEdit.Mobile = "";
            _customerEdit.Fax = "";
            _customerEdit.Web = "";

            _customerEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 5);
            Assert.IsTrue(_formAlerts.Contains("Kundenname: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Dies ist ein Pflichtfeld! Zu kurze Eingabe!"));
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));

            _customerEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditCustomerWithoutStreetAndNumberFailed()
        {
            _customerMenu.CustomerEdit.Click();

            _customerEdit.CustomerName = "SYR Sele Kunde A";

            _customerEdit.CompanyName = "SYR Sele Firma A";
            _customerEdit.StreetName = "";
            _customerEdit.Zip = "8021";
            _customerEdit.City = "Zürich";
            _customerEdit.Po = "PFO1";
            _customerEdit.AdressAddition = "Etage 3";
            _customerEdit.Region = "Reg 55";
            _customerEdit.SapNumber = "4440";

            _customerEdit.Agency = "SIX Payment Services (Europe)";
            _customerEdit.Language = "Deutsch [de]";
            _customerEdit.Country = "Schweiz [CH]";
            _customerEdit.Email = "marc.siegmund@six-group.com";
            _customerEdit.Telephone = "0031 58 399 6237";
            _customerEdit.Mobile = "0032 58 399 6237";
            _customerEdit.Fax = "0033 58 399 6237";
            _customerEdit.Web = "www.six-group.com/de-intern";

            _customerEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
            _customerEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditCustomerWithoutCityFailed()
        {
            _customerMenu.CustomerEdit.Click();

            _customerEdit.CustomerName = "SYR Sele Kunde A";

            _customerEdit.CompanyName = "SYR Sele Firma A";
            _customerEdit.StreetName = "Hardturmstr. 201";
            _customerEdit.Zip = "8021";
            _customerEdit.City = "";
            _customerEdit.Po = "PFO1";
            _customerEdit.AdressAddition = "Etage 3";
            _customerEdit.Region = "Reg 55";
            _customerEdit.SapNumber = "4440";

            _customerEdit.Agency = "SIX Payment Services (Europe)";
            _customerEdit.Language = "Deutsch [de]";
            _customerEdit.Country = "Schweiz [CH]";
            _customerEdit.Email = "marc.siegmund@six-group.com";
            _customerEdit.Telephone = "0031 58 399 6237";
            _customerEdit.Mobile = "0032 58 399 6237";
            _customerEdit.Fax = "0033 58 399 6237";
            _customerEdit.Web = "www.six-group.com/de-intern";

            _customerEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));
            _customerEdit.CancelButton.Click();
        }

        public void EditCustomerWithoutZipFailed()
        {
            _customerMenu.CustomerEdit.Click();

            _customerEdit.CustomerName = "SYR Sele Kunde A";

            _customerEdit.CompanyName = "SYR Sele Firma A";
            _customerEdit.StreetName = "Hardturmstr. 201";
            _customerEdit.Zip = "";
            _customerEdit.City = "Zürich";
            _customerEdit.Po = "PFO1";
            _customerEdit.AdressAddition = "Etage 3";
            _customerEdit.Region = "Reg 55";
            _customerEdit.SapNumber = "4440";

            _customerEdit.Agency = "SIX Payment Services (Europe)";
            _customerEdit.Language = "Deutsch [de]";
            _customerEdit.Country = "Schweiz [CH]";
            _customerEdit.Email = "marc.siegmund@six-group.com";
            _customerEdit.Telephone = "0031 58 399 6237";
            _customerEdit.Mobile = "0032 58 399 6237";
            _customerEdit.Fax = "0033 58 399 6237";
            _customerEdit.Web = "www.six-group.com/de-intern";

            _customerEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
            _customerEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditCustomerAndSave()
        {
            string customerNumber = _customerView.CustomerNumber;
            string guid = _customerView.Guid;
            string customerName = _customerView.CustomerName;
            string sbsDebitNumber = _customerView.SbsDebitNumber;
            string sbsAdressNumber = _customerView.SbsAdressNumber;
            string sbsCurrency = _customerView.SbsCurrency;
            string sbsBillingTenant = _customerView.SbsBillingTenant;
            string supplier = _customerView.Supplier;
            string sapNumber = _customerView.SapNumber;
            string ep2MerchantId = _customerView.Ep2MerchantId;
            string companyName = _customerView.CompanyName;
            string streetName = _customerView.StreetNo;
            string zip = _customerView.Zip;
            string city = _customerView.City;
            string po = _customerView.Po;
            string adressAddition = _customerView.AdressAddition;
            string region = _customerView.Region;
            string categoryCode = _customerView.CategoryCode;
            string supportContract = _customerView.SupportContract;
            string agency = _customerView.Agency;
            string cashIntegrator = _customerView.CashIntegrator;
            string language = _customerView.Language;
            string country = _customerView.Country;
            string email = _customerView.Email;
            string telephone = _customerView.Telephone;
            string fax = _customerView.Fax;
            string web = _customerView.Web;

            // StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNo);
            StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(_customerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            _customerMenu.CustomerEdit.Click();

            Assert.AreEqual(customerNumber, _customerEdit.CustomerNumber);
            Assert.AreEqual(supplier, _customerEdit.Supplier);
            Assert.AreEqual(ep2MerchantId, _customerEdit.Ep2MerchantId);
            Assert.AreEqual(sbsDebitNumber, _customerEdit.SbsDebitNumber);
            Assert.AreEqual(sbsAdressNumber, _customerEdit.SbsAdressNumber);
            Assert.AreEqual(sbsCurrency, _customerEdit.SbsCurrency);
            Assert.AreEqual(sbsBillingTenant, _customerEdit.SbsBillingTenant);

            _customerEdit.CustomerName = "SYR Sele Kunde A";

            _customerEdit.CompanyName = "SYR Sele Firma A";
            _customerEdit.StreetName = "Hardturmstr. 201";
            _customerEdit.Zip = "8021";
            _customerEdit.City = "Zürich";
            _customerEdit.Po = "PFO1";
            _customerEdit.AdressAddition = "Etage 3";
            _customerEdit.Region = "Reg 55";
            _customerEdit.SapNumber = "5440";
            _customerEdit.CategoryCode = "5172: PETROLEUM/PETROL PRODUCTS";
            _customerEdit.SupportContract = "Hotline und Wartung kostenpflichtig";
            _customerEdit.CashIntegrator = "Wincor Nixdorf AG, Brüttisellen";

            _customerEdit.Agency = "SIX Payment Services (Europe)";
            _customerEdit.Language = "Deutsch [de]";
            _customerEdit.Country = "Schweiz [CH]";
            _customerEdit.Email = "marc.siegmund@six-group.com";
            _customerEdit.Telephone = "0031 58 399 6237";
            _customerEdit.Mobile = "0032 58 399 6237";
            _customerEdit.Fax = "0033 58 399 6237";
            _customerEdit.Web = "www.six-group.com/de-intern";

            _customerEdit.SaveButton.Click();

            Assert.AreEqual(customerNumber, _customerView.CustomerNumber);
            Assert.AreEqual(guid, _customerView.Guid);

            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual(customerNumber, _customerView.CustomerNumber);
            Assert.AreEqual(guid, _customerView.Guid);
            Assert.AreEqual("SYR Sele Kunde A", _customerView.CustomerName);
            Assert.AreEqual(supplier, _customerView.Supplier);
            Assert.AreEqual(sbsBillingTenant, _customerView.SbsBillingTenant);
            Assert.AreEqual(sbsCurrency, _customerView.SbsCurrency);
            Assert.AreEqual(sbsDebitNumber, _customerView.SbsDebitNumber);
            Assert.AreEqual(sbsAdressNumber, _customerView.SbsAdressNumber);
            Assert.AreEqual("5172: PETROLEUM/PETROL PRODUCTS", _customerView.CategoryCode);
            Assert.AreEqual("Hotline und Wartung kostenpflichtig", _customerView.SupportContract);
            Assert.AreEqual("Wincor Nixdorf AG, Brüttisellen", _customerView.CashIntegrator);
            Assert.AreEqual("5440", _customerView.SapNumber);
            Assert.AreEqual("SYR Sele Kunde A", _customerView.CustomerName);
            Assert.AreEqual(customerNumber, _customerView.CustomerNumber);
            Assert.AreEqual("SYR Sele Kunde A", _customerView.CustomerName);
            Assert.AreEqual("SIX Payment Services AG", _customerView.Supplier);
            Assert.AreEqual("SIX Payment Services (Europe)", _customerView.SbsBillingTenant);
            Assert.AreEqual("EUR", _customerView.SbsCurrency);
            Assert.AreEqual("5440", _customerView.SapNumber);

            StringAssert.Matches(_customerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);

            int retry = 5;
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

            StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(_customerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual("SYR Sele Firma A", _customerView.CompanyName);
            Assert.AreEqual("PFO1", _customerView.Po);
            Assert.AreEqual("Etage 3", _customerView.AdressAddition);
            Assert.AreEqual("Reg 55", _customerView.Region);
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
        public void EditCustomerWithMinimalAndSave()
        {
            string customerNumber = _customerView.CustomerNumber;
            string guid = _customerView.Guid;
            string customerName = _customerView.CustomerName;
            string sbsDebitNumber = _customerView.SbsDebitNumber;
            string sbsAdressNumber = _customerView.SbsAdressNumber;
            string sbsCurrency = _customerView.SbsCurrency;
            string sbsBillingTenant = _customerView.SbsBillingTenant;
            string supplier = _customerView.Supplier;
            string sapNumber = _customerView.SapNumber;
            string ep2MerchantId = _customerView.Ep2MerchantId;
            string companyName = _customerView.CompanyName;
            string streetName = _customerView.StreetNo;
            string zip = _customerView.Zip;
            string city = _customerView.City;
            string po = _customerView.Po;
            string adressAddition = _customerView.AdressAddition;
            string region = _customerView.Region;
            string categoryCode = _customerView.CategoryCode;
            string supportContract = _customerView.SupportContract;
            string agency = _customerView.Agency;
            string cashIntegrator = _customerView.CashIntegrator;
            string language = _customerView.Language;
            string country = _customerView.Country;
            string email = _customerView.Email;
            string telephone = _customerView.Telephone;
            string fax = _customerView.Fax;
            string web = _customerView.Web;

            // StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNo);
            StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(_customerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            _customerMenu.CustomerEdit.Click();

            Assert.AreEqual(customerNumber, _customerEdit.CustomerNumber);
            Assert.AreEqual(supplier, _customerEdit.Supplier);
            Assert.AreEqual(ep2MerchantId, _customerEdit.Ep2MerchantId);
            Assert.AreEqual(sbsDebitNumber, _customerEdit.SbsDebitNumber);
            Assert.AreEqual(sbsAdressNumber, _customerEdit.SbsAdressNumber);
            Assert.AreEqual(sbsCurrency, _customerEdit.SbsCurrency);
            Assert.AreEqual(sbsBillingTenant, _customerEdit.SbsBillingTenant);

            _customerEdit.CustomerName = "SYR Sele Kunde A";

            _customerEdit.CompanyName = "SYR Sele Firma A";
            _customerEdit.StreetName = "Hardturmstr. 201";
            _customerEdit.Po = "";
            _customerEdit.Region = "";
            _customerEdit.AdressAddition = "";
            _customerEdit.Zip = "8021";
            _customerEdit.City = "Zürich";
            _customerEdit.SupportContract = "Kein Supportvertrag";
            _customerEdit.CashIntegrator = "Kein Kassenintegrator";

            _customerEdit.Agency = "Keine Agentur";
            _customerEdit.Language = "Deutsch [de]";
            _customerEdit.Country = "Schweiz [CH]";
            _customerEdit.Email = "";
            _customerEdit.Telephone = "";
            _customerEdit.Mobile = "";
            _customerEdit.Fax = "";
            _customerEdit.Web = "";

            _customerEdit.SaveButton.Click();

            Assert.AreEqual(guid, _customerView.Guid);
            Assert.AreEqual(customerNumber, _customerView.CustomerNumber);

            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual(customerNumber, _customerView.CustomerNumber);
            Assert.AreEqual(guid, _customerView.Guid);
            Assert.AreEqual("SYR Sele Kunde A", _customerView.CustomerName);
            Assert.AreEqual(supplier, _customerView.Supplier);
            Assert.AreEqual(sbsBillingTenant, _customerView.SbsBillingTenant);
            Assert.AreEqual(sbsCurrency, _customerView.SbsCurrency);
            Assert.AreEqual(sbsDebitNumber, _customerView.SbsDebitNumber);
            Assert.AreEqual(sbsAdressNumber, _customerView.SbsAdressNumber);
            Assert.AreEqual("Kein Supportvertrag", _customerView.SupportContract);
            Assert.AreEqual("Kein Kassenintegrator", _customerView.CashIntegrator);
            Assert.AreEqual(sapNumber, _customerView.SapNumber);
            Assert.AreEqual(categoryCode, _customerView.CategoryCode);

            StringAssert.Matches(_customerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);

            int retry = 5;
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

            StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(_customerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual("SYR Sele Firma A", _customerView.CompanyName);
            Assert.AreEqual(" ", _customerView.Po);
            Assert.AreEqual(" ", _customerView.AdressAddition);
            Assert.AreEqual(" ", _customerView.Region);
            Assert.AreEqual("Hardturmstr. 201", _customerView.StreetNo);
            Assert.AreEqual("8021", _customerView.Zip);
            Assert.AreEqual("Zürich", _customerView.City);
            Assert.AreEqual("Keine Agentur", _customerView.Agency);
            Assert.AreEqual(language, _customerView.Language);
            Assert.AreEqual(country, _customerView.Country);
            Assert.AreEqual(" ", _customerView.Email);
            Assert.AreEqual(" ", _customerView.Telephone);
            Assert.AreEqual(" ", _customerView.Mobile);
            Assert.AreEqual(" ", _customerView.Fax);
            Assert.AreEqual("", _customerView.Web);
        }

        [TestMethod]
        public void EditCustomerCheckNavBar()
        {
            Assert.AreEqual("Kunde", _navigationBar.Current.Text);
            _customerMenu.CustomerEdit.Click();
            Assert.AreEqual("Kunde", _navigationBar.Current.Text);
        }

        [TestMethod]
        public void EditCustomerCheckMenu()
        {
            _menusTests.CustomerMenuCheck(_customerMenu);
            _customerMenu.CustomerEdit.Click();
            _menusTests.CustomerMenuCheck(_customerMenu);
        }


        [TestMethod]
        public void EditCustomerCheckHeadline()
        {
            StringAssert.Matches(_lobby.Headline.Text, new Regex(@"\d+:.*"));
            string headLine = _lobby.Headline.Text;
            _customerMenu.CustomerEdit.Click();
            StringAssert.Contains(_lobby.Headline.Text, headLine);
        }
    }
}