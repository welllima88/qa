using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.ObsoleteTests.Menu;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Edit.Delayed
{
    [TestClass]
    public class CustomerEditAndDelayedSaveTest
    {
        private static string _customerNumber;
        private static string _sbsDebitNumber;
        private static string _sbsAdressNumber;
        private static string _sbsCurrency;
        private static string _sbsBillingTenant;
        private static string _supplier;
        private static string _ep2MerchantId;

        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?CustomerId=401858");

            ReadPreState();

            StringAssert.Matches(View.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNoOpt));
            StringAssert.Matches(View.SbsDebitNumber, new Regex(TestRegExpPatterns.SbsDebitorNo));
            StringAssert.Matches(View.Ep2MerchantId, new Regex(TestRegExpPatterns.Ep2MerchantId));

            CustomerMenu.CustomerEdit.Click();

            Assert.AreEqual(_customerNumber, Selenium.Customer.Edit.CustomerNumber);
            Assert.AreEqual(_ep2MerchantId, Selenium.Customer.Edit.Ep2MerchantId);

            EditCustomer();

            ChangeOptions(new TimeSpan().Add(TimeSpan.FromMinutes(3)));

            Selenium.Customer.Edit.SaveButton.Click();
        }

        private static void ChangeOptions(TimeSpan add)
        {
            ChangeForm.Reason = "Adressänderung";
            ChangeForm.Remark = "SYR Auto EDIT Delayed";
            ChangeForm.DelayTime(add);
        }

        private static void EditCustomer()
        {
            Selenium.Customer.Edit.CustomerName = "SYR Sele Kunde A";

            Selenium.Customer.Edit.CompanyName = "SYR Sele Firma A";
            Selenium.Customer.Edit.StreetNo = "Hardturmstr. 201";
            Selenium.Customer.Edit.Zip = "8021";
            Selenium.Customer.Edit.City = "Zürich";
            Selenium.Customer.Edit.Po = "PFO1";
            Selenium.Customer.Edit.AdressAddition = "Etage 3";
            Selenium.Customer.Edit.Region = "Reg 55";
            Selenium.Customer.Edit.SapNumber = "5440";

            Selenium.Customer.Edit.Agency = "SIX Payment Services (Europe)";
            Selenium.Customer.Edit.Language = "Deutsch [de]";
            Selenium.Customer.Edit.Country = "Schweiz [CH]";
            Selenium.Customer.Edit.Email = "marc.siegmund@six-group.com";
            Selenium.Customer.Edit.Telephone = "0031 58 399 6237";
            Selenium.Customer.Edit.Mobile = "0032 58 399 6237";
            Selenium.Customer.Edit.Fax = "0033 58 399 6237";
            Selenium.Customer.Edit.Web = "www.six-group.com/de-intern";
        }

        private static void ReadPreState()
        {
            _customerNumber = View.CustomerNumber;
            _sbsDebitNumber = View.SbsDebitNumber;
            _sbsAdressNumber = View.SbsAdressNumber;
            _sbsCurrency = View.SbsCurrency;
            _sbsBillingTenant = View.SbsBillingTenant;
            _supplier = View.Supplier;
            _ep2MerchantId = View.Ep2MerchantId;
        }

        [TestMethod]
        public void EditCustomerAndSave()
        {
            Assert.AreEqual(_customerNumber, View.CustomerNumber);
            Assert.AreEqual("SYR Sele Kunde A", View.CustomerName);
            Assert.AreEqual(_supplier, View.Supplier);
            Assert.AreEqual(_sbsBillingTenant, View.SbsBillingTenant);
            Assert.AreEqual(_sbsCurrency, View.SbsCurrency);
            Assert.AreEqual(_sbsDebitNumber, View.SbsDebitNumber);
            Assert.AreEqual(_sbsAdressNumber, View.SbsAdressNumber);
            Assert.AreEqual("5172: PETROLEUM/PETROL PRODUCTS", View.CategoryCode);
            Assert.AreEqual("Hotline und Wartung kostenpflichtig", View.SupportContract);
            Assert.AreEqual("Wincor Nixdorf AG, Brüttisellen", View.CashIntegrator);
            Assert.AreEqual("5440", View.SapNumber);
            Assert.AreEqual("SYR Sele Kunde A", View.CustomerName);
            Assert.AreEqual("SYR Sele Kunde A", View.CustomerName);
            Assert.AreEqual("SIX Payment Services AG", View.Supplier);
            Assert.AreEqual("SIX Payment Services (Europe)", View.SbsBillingTenant);
            Assert.AreEqual("Euro", View.SbsCurrency);
            Assert.AreEqual("5440", View.SapNumber);

            StringAssert.Matches(View.SbsDebitNumber, new Regex(TestRegExpPatterns.SbsDebitorNo));
            StringAssert.Matches(View.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNoOpt));
            StringAssert.Matches(View.Ep2MerchantId, new Regex(TestRegExpPatterns.Ep2MerchantId));

            Assert.AreEqual("SYR Sele Firma A", View.CompanyName);
            Assert.AreEqual("PFO1", View.Po);
            Assert.AreEqual("Etage 3", View.AdressAddition);
            Assert.AreEqual("Reg 55", View.Region);
            Assert.AreEqual("Hardturmstr. 201", View.StreetNo);
            Assert.AreEqual("8021", View.Zip);
            Assert.AreEqual("Zürich", View.City);
            Assert.AreEqual("SIX Payment Services (Europe)", View.Agency);
            Assert.AreEqual("Deutsch [de]", View.Language);
            Assert.AreEqual("Schweiz [CH]", View.Country);
            Assert.AreEqual("marc.siegmund@six-group.com", View.Email);
            Assert.AreEqual("0031 58 399 6237", View.Telephone);
            Assert.AreEqual("0032 58 399 6237", View.Mobile);
            Assert.AreEqual("0033 58 399 6237", View.Fax);
            Assert.AreEqual("www.six-group.com/de-intern", View.Web);
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
            StringAssert.Matches(Lobby.Headline.Text, new Regex(@"\d+:.*"));
            string headLine = Lobby.Headline.Text;
            CustomerMenu.CustomerEdit.Click();
            StringAssert.Contains(Lobby.Headline.Text, headLine);
        }
    }
}