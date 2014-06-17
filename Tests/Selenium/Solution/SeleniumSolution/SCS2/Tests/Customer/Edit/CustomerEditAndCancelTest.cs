using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.Tests.Selenium.Extension;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Common.Menu;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Customer;
using Six.Scs.Tests.Selenium.Extension.WebDriver;

namespace Six.Scs.Tests.Selenium.Tests.Customer.Edit
{
    [TestClass]
    [Ignore]
    public class CustomerEditAndCancel
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

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Customer/edit?customerId=405125");

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

            CustomerMenu.CustomerEdit.Click();

            CustomerEdit.CustomerName = "SYR Sele Kunde AAA";

            CustomerEdit.CompanyName = "SYR Sele Firma AAA";
            CustomerEdit.StreetNo = "Hardturmstr. 2011";
            CustomerEdit.Zip = "80222";
            CustomerEdit.City = "Zürichhh";
            CustomerEdit.Po = "PFO111";
            CustomerEdit.AdressAddition = "Etage 333";
            CustomerEdit.Region = "Reggg";
            CustomerEdit.SapNumber = "4449";

            CustomerEdit.Agency = "C01 Bellia Antoine";
            CustomerEdit.Language = "Kroatisch [hr]";
            CustomerEdit.Country = "Albanien [AL]";
            CustomerEdit.Email = "marc.siegmund@six-group.commmm";
            CustomerEdit.Telephone = "0031 58 399 623777";
            CustomerEdit.Mobile = "0032 58 399 623777";
            CustomerEdit.Fax = "0033 58 399 623777";
            CustomerEdit.Web = "www.six-group.com/de-internnnn";

            CustomerEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditCustomerAndCancel()
        {
            Assert.AreEqual(_custId, CustomerView.CustomerNumber);
            Assert.AreEqual(_customerName, CustomerView.CustomerName);
            Assert.AreEqual(_supplier, CustomerView.Supplier);
            Assert.AreEqual(_sbsDebitNumber, CustomerView.SbsDebitNumber);
            Assert.AreEqual(_sbsAdressNumber, CustomerView.SbsAdressNumber);
            Assert.AreEqual(_sbsBillingTenant, CustomerView.SbsBillingTenant);
            Assert.AreEqual(_sbsCurrency, CustomerView.SbsCurrency);
            Assert.AreEqual(_sapNumber, CustomerView.SapNumber);
            Assert.AreEqual(_segment, CustomerView.Segment);
            Assert.AreEqual(_ep2MerchantId, CustomerView.Ep2MerchantId);

            StringAssert.Matches(CustomerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(CustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(CustomerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual(_companyName, CustomerView.CompanyName);
            Assert.AreEqual(_po, CustomerView.Po);
            Assert.AreEqual(_adressAddition, CustomerView.AdressAddition);
            Assert.AreEqual(_streetName, CustomerView.StreetNo);
            Assert.AreEqual(_zip, CustomerView.Zip);
            Assert.AreEqual(_city, CustomerView.City);
            Assert.AreEqual(_agency, CustomerView.Agency);
            Assert.AreEqual(_language, CustomerView.Language);
            Assert.AreEqual(_country, CustomerView.Country);
            Assert.AreEqual(_email, CustomerView.Email);
            Assert.AreEqual(_telephone, CustomerView.Telephone);
            Assert.AreEqual(_mobile, CustomerView.Mobile);
            Assert.AreEqual(_fax, CustomerView.Fax);
            Assert.AreEqual(_web, CustomerView.Web);
        }
    }
}