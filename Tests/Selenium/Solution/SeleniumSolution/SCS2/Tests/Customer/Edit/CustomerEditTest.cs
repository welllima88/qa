using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common.Menu;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Customer;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Menu;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Edit
{
    [TestClass]
    public class CustomerEditTest
    {
        private static CustomerEdit _customerEdit;
        private static CustomerView _customerView;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static FormAlert _formAlert;
        private static CustomerMenu _customerMenu;
        private static MenusTest _menusTests;
        private static LobbyView _lobby;

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
            _customerMenu = new CustomerMenu();
            _customerEdit = new CustomerEdit();
            _customerView = new CustomerView();
            _recentElements = new RecentElements();
            _navigationBar = new NavigationBar();
            _formAlert = new FormAlert();
            _menusTests = new MenusTest();
            _lobby = new LobbyView();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=405125");

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

        [TestMethod]
        public void CheckLocationMenu()
        {
            _menusTests.CustomerMenuCheck(_customerMenu);
            _customerMenu.CustomerEdit.Click();
            _customerEdit.CancelButton.Click();
            _menusTests.CustomerMenuCheck(_customerMenu);
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
        }

        [TestMethod]
        public void EditCustomerAndSave()
        {
            string customerNumber = _customerView.CustomerNumber;
            string guid = _customerView.Guid;
            string sbsDebitNumber = _customerView.SbsDebitNumber;
            string sbsAdressNumber = _customerView.SbsAdressNumber;
            string sbsCurrency = _customerView.SbsCurrency;
            string sbsBillingTenant = _customerView.SbsBillingTenant;
            string supplier = _customerView.Supplier;
            string ep2MerchantId = _customerView.Ep2MerchantId;

            // StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNo);
            StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(_customerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
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
            _customerEdit.StreetNo = "Hardturmstr. 201";
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