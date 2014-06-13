using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.Tests.Selenium.Extension;
using SIX.SCS.Tests.Selenium.Extension.Selenium;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Customer;
using SIX.SCS.Tests.Selenium.Tests.Menu;

namespace SIX.SCS.Tests.Selenium.Tests.Customer.Edit.Delayed
{
    [TestClass]
    public class CustomerEditAndDelayedSaveTest
    {
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
        private static string customerNumber;
        private static string sbsDebitNumber;
        private static string sbsAdressNumber;
        private static string sbsCurrency;
        private static string sbsBillingTenant;
        private static string supplier;
        private static string ep2MerchantId;

        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?CustomerId=401858");

            ReadPreState();

            StringAssert.Matches(CustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(CustomerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(CustomerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            CustomerMenu.CustomerEdit.Click();

            Assert.AreEqual(customerNumber, CustomerEdit.CustomerNumber);
            Assert.AreEqual(ep2MerchantId, CustomerEdit.Ep2MerchantId);

            EditCustomer();

            ChangeOptions(new TimeSpan().Add(TimeSpan.FromMinutes(3)));

            CustomerEdit.SaveButton.Click();
        }

        private static void ChangeOptions(TimeSpan add)
        {
            ChangeForm.Reason = "Adressänderung";
            ChangeForm.Remark = "SYR Auto EDIT Delayed";
            ChangeForm.DelayTime(add);
        }

        private static void EditCustomer()
        {
            CustomerEdit.CustomerName = "SYR Sele Kunde A";

            CustomerEdit.CompanyName = "SYR Sele Firma A";
            CustomerEdit.StreetNo = "Hardturmstr. 201";
            CustomerEdit.Zip = "8021";
            CustomerEdit.City = "Zürich";
            CustomerEdit.Po = "PFO1";
            CustomerEdit.AdressAddition = "Etage 3";
            CustomerEdit.Region = "Reg 55";
            CustomerEdit.SapNumber = "5440";

            CustomerEdit.Agency = "SIX Payment Services (Europe)";
            CustomerEdit.Language = "Deutsch [de]";
            CustomerEdit.Country = "Schweiz [CH]";
            CustomerEdit.Email = "marc.siegmund@six-group.com";
            CustomerEdit.Telephone = "0031 58 399 6237";
            CustomerEdit.Mobile = "0032 58 399 6237";
            CustomerEdit.Fax = "0033 58 399 6237";
            CustomerEdit.Web = "www.six-group.com/de-intern";
        }

        private static void ReadPreState()
        {
            _custId = CustomerView.CustomerNumber;
            _customerName = CustomerView.CustomerName;
            _supplier = CustomerView.Supplier;

            _sbsBillingTenant = CustomerView.SbsBillingTenant;
            _sbsCurrency = CustomerView.SbsCurrency;
            _sapNumber = CustomerView.SapNumber;
            _sbsDebitNumber = CustomerView.SbsDebitNumber;
            _sbsAdressNumber = CustomerView.SbsAdressNumber;
            _segment = CustomerView.Segment;

            _ep2MerchantId = CustomerView.Ep2MerchantId;

            _companyName = CustomerView.CompanyName;
            _po = CustomerView.Po;
            _adressAddition = CustomerView.AdressAddition;
            _streetName = CustomerView.StreetNo;
            _zip = CustomerView.Zip;
            _city = CustomerView.City;
            _agency = CustomerView.Agency;
            _language = CustomerView.Language;
            _country = CustomerView.Country;
            _email = CustomerView.Email;
            _telephone = CustomerView.Telephone;
            _mobile = CustomerView.Mobile;
            _fax = CustomerView.Fax;
            _web = CustomerView.Web;

            customerNumber = CustomerView.CustomerNumber;
            sbsDebitNumber = CustomerView.SbsDebitNumber;
            sbsAdressNumber = CustomerView.SbsAdressNumber;
            sbsCurrency = CustomerView.SbsCurrency;
            sbsBillingTenant = CustomerView.SbsBillingTenant;
            supplier = CustomerView.Supplier;
            ep2MerchantId = CustomerView.Ep2MerchantId;
        }

        [TestMethod]
        public void EditCustomerAndSave()
        {
            Assert.AreEqual(customerNumber, CustomerView.CustomerNumber);
            Assert.AreEqual("SYR Sele Kunde A", CustomerView.CustomerName);
            Assert.AreEqual(supplier, CustomerView.Supplier);
            Assert.AreEqual(sbsBillingTenant, CustomerView.SbsBillingTenant);
            Assert.AreEqual(sbsCurrency, CustomerView.SbsCurrency);
            Assert.AreEqual(sbsDebitNumber, CustomerView.SbsDebitNumber);
            Assert.AreEqual(sbsAdressNumber, CustomerView.SbsAdressNumber);
            Assert.AreEqual("5172: PETROLEUM/PETROL PRODUCTS", CustomerView.CategoryCode);
            Assert.AreEqual("Hotline und Wartung kostenpflichtig", CustomerView.SupportContract);
            Assert.AreEqual("Wincor Nixdorf AG, Brüttisellen", CustomerView.CashIntegrator);
            Assert.AreEqual("5440", CustomerView.SapNumber);
            Assert.AreEqual("SYR Sele Kunde A", CustomerView.CustomerName);
            Assert.AreEqual("SYR Sele Kunde A", CustomerView.CustomerName);
            Assert.AreEqual("SIX Payment Services AG", CustomerView.Supplier);
            Assert.AreEqual("SIX Payment Services (Europe)", CustomerView.SbsBillingTenant);
            Assert.AreEqual("Euro", CustomerView.SbsCurrency);
            Assert.AreEqual("5440", CustomerView.SapNumber);

            StringAssert.Matches(CustomerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(CustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(CustomerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual("SYR Sele Firma A", CustomerView.CompanyName);
            Assert.AreEqual("PFO1", CustomerView.Po);
            Assert.AreEqual("Etage 3", CustomerView.AdressAddition);
            Assert.AreEqual("Reg 55", CustomerView.Region);
            Assert.AreEqual("Hardturmstr. 201", CustomerView.StreetNo);
            Assert.AreEqual("8021", CustomerView.Zip);
            Assert.AreEqual("Zürich", CustomerView.City);
            Assert.AreEqual("SIX Payment Services (Europe)", CustomerView.Agency);
            Assert.AreEqual("Deutsch [de]", CustomerView.Language);
            Assert.AreEqual("Schweiz [CH]", CustomerView.Country);
            Assert.AreEqual("marc.siegmund@six-group.com", CustomerView.Email);
            Assert.AreEqual("0031 58 399 6237", CustomerView.Telephone);
            Assert.AreEqual("0032 58 399 6237", CustomerView.Mobile);
            Assert.AreEqual("0033 58 399 6237", CustomerView.Fax);
            Assert.AreEqual("www.six-group.com/de-intern", CustomerView.Web);
        }

        [TestMethod]
        public void EditCustomerCheckNavBar()
        {
            Assert.AreEqual("Kunde", NavigationBar.Current.Text);
            CustomerMenu.CustomerEdit.Click();
            Assert.AreEqual("Kunde", NavigationBar.Current.Text);
        }

        [TestMethod]
        public void EditCustomerCheckMenu()
        {
            MenusTest.CustomerMenuCheck();
            CustomerMenu.CustomerEdit.Click();
            MenusTest.CustomerMenuCheck();
        }

        [TestMethod]
        public void EditCustomerCheckHeadline()
        {
            StringAssert.Matches(LobbyView.Headline.Text, new Regex(@"\d+:.*"));
            string headLine = LobbyView.Headline.Text;
            CustomerMenu.CustomerEdit.Click();
            StringAssert.Contains(LobbyView.Headline.Text, headLine);
        }
    }
}