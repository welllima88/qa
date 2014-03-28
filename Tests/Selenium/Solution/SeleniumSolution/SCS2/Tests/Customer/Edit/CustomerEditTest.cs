using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Menu;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Edit
{
    [TestClass]
    public class CustomerEditTest
    {
        private static string _customerNumber;
        private static string _supplier;
        private static string _sbsBillingTenant;
        private static string _sbsCurrency;
        private static string _sbsDebitNumber;
        private static string _sbsAdressNumber;
        private static string _customerName;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?CustomerId=401858");

            _customerNumber = CustomerView.CustomerNumber;
            _supplier = CustomerView.Supplier;

            _sbsBillingTenant = CustomerView.SbsBillingTenant;
            _sbsCurrency = CustomerView.SbsCurrency;
            _sbsDebitNumber = CustomerView.SbsDebitNumber;
            _sbsAdressNumber = CustomerView.SbsAdressNumber;
        }

        [TestMethod]
        public void EditCustomerAndSave()
        {
            StringAssert.Matches(CustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(CustomerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(CustomerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Edit();
            Check();

            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            Check();
        }

        public static void Edit()
        {
            _customerNumber = CustomerView.CustomerNumber;
            _sbsDebitNumber = CustomerView.SbsDebitNumber;
            _sbsAdressNumber = CustomerView.SbsAdressNumber;
            _sbsCurrency = CustomerView.SbsCurrency;
            _sbsBillingTenant = CustomerView.SbsBillingTenant;
            _supplier = CustomerView.Supplier;
            CustomerMenu.CustomerEdit.Click();

            _customerName = CustomerEdit.CustomerName = "SYR Kunde" + TestLauncher.GenerateTestId();

            CustomerEdit.CompanyName = "SYR Sele Firma A";
            CustomerEdit.StreetNo = "Hardturmstr. 201";
            CustomerEdit.Zip = "8021";
            CustomerEdit.City = "Zürich";
            CustomerEdit.Po = "PFO1";
            CustomerEdit.AdressAddition = "Etage 3";
            CustomerEdit.Region = "Reg 55";
            CustomerEdit.SapNumber = "5440";

            CustomerEdit.Agency = "SIX Payment Services (Europe)";
            CustomerEdit.Language = "de";
            CustomerEdit.Country = "CH";
            CustomerEdit.Email = "marc.siegmund@six-group.com";
            CustomerEdit.Telephone = "0031 58 399 6237";
            CustomerEdit.Mobile = "0032 58 399 6237";
            CustomerEdit.Fax = "0033 58 399 6237";
            CustomerEdit.Web = "www.six-group.com/de-intern";

            ChangeForm.Reason = "MerchantAddressChange";
            ChangeForm.Remark = "SYR " + TestLauncher.GenerateTestId() + " customer change remark";

            CustomerEdit.SaveButton.Click();
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

        public static void Check()
        {
            Assert.AreEqual(_customerNumber, CustomerView.CustomerNumber);
            Assert.AreEqual(_customerName, CustomerView.CustomerName);
            Assert.AreEqual(_supplier, CustomerView.Supplier);
            Assert.AreEqual(_sbsBillingTenant, CustomerView.SbsBillingTenant);
            Assert.AreEqual(_sbsCurrency, CustomerView.SbsCurrency);
            Assert.AreEqual(_sbsDebitNumber, CustomerView.SbsDebitNumber);
            Assert.AreEqual(_sbsAdressNumber, CustomerView.SbsAdressNumber);
            Assert.AreEqual("5440", CustomerView.SapNumber);
            Assert.AreEqual("SIX Payment Services AG", CustomerView.Supplier);
            Assert.AreEqual("SIX Payment Services (Europe)", CustomerView.SbsBillingTenant);
            StringAssert.Contains(CustomerView.SbsCurrency.ToUpper(), "EUR");

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
            StringAssert.Contains(CustomerView.Agency, "SIX Payment Services (Europe)");
            StringAssert.Contains(CustomerView.Language, "[de]");
            StringAssert.Contains(CustomerView.Country, "[CH]");
            Assert.AreEqual("marc.siegmund@six-group.com", CustomerView.Email);
            Assert.AreEqual("0031 58 399 6237", CustomerView.Telephone);
            Assert.AreEqual("0032 58 399 6237", CustomerView.Mobile);
            Assert.AreEqual("0033 58 399 6237", CustomerView.Fax);
            Assert.AreEqual("www.six-group.com/de-intern", CustomerView.Web);
        }
    }
}