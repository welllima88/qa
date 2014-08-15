using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Edit
{
    [TestClass]
    [Ignore]
    public class EditAndCancel
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

            _custId = View.CustomerNumber;
            _customerName = View.CustomerName;
            _supplier = View.Supplier;

            _sbsBillingTenant = View.SbsBillingTenant;
            _sbsCurrency = View.SbsCurrency;
            _sapNumber = View.SapNumber;
            _sbsDebitNumber = View.SbsDebitNumber;
            _sbsAdressNumber = View.SbsAdressNumber;
            _segment = View.Segment;

            _ep2MerchantId = View.Ep2MerchantId;

            _companyName = View.CompanyName;
            _po = View.Po;
            _adressAddition = View.AdressAddition;
            _streetName = View.StreetNo;
            _zip = View.Zip;
            _city = View.City;
            _agency = View.Agency;
            _language = View.Language;
            _country = View.Country;
            _email = View.Email;
            _telephone = View.Telephone;
            _mobile = View.Mobile;
            _fax = View.Fax;
            _web = View.Web;

            CustomerMenu.CustomerEdit.Click();

            Selenium.Customer.Edit.CustomerName = "SYR Sele Kunde AAA";

            Selenium.Customer.Edit.CompanyName = "SYR Sele Firma AAA";
            Selenium.Customer.Edit.StreetNo = "Hardturmstr. 2011";
            Selenium.Customer.Edit.Zip = "80222";
            Selenium.Customer.Edit.City = "Zürichhh";
            Selenium.Customer.Edit.Po = "PFO111";
            Selenium.Customer.Edit.AdressAddition = "Etage 333";
            Selenium.Customer.Edit.Region = "Reggg";
            Selenium.Customer.Edit.SapNumber = "4449";

            Selenium.Customer.Edit.Agency = "C01 Bellia Antoine";
            Selenium.Customer.Edit.Language = "Kroatisch [hr]";
            Selenium.Customer.Edit.Country = "Albanien [AL]";
            Selenium.Customer.Edit.Email = "marc.siegmund@six-group.commmm";
            Selenium.Customer.Edit.Telephone = "0031 58 399 623777";
            Selenium.Customer.Edit.Mobile = "0032 58 399 623777";
            Selenium.Customer.Edit.Fax = "0033 58 399 623777";
            Selenium.Customer.Edit.Web = "www.six-group.com/de-internnnn";

            Selenium.Customer.Edit.CancelButton.Click();
        }

        [TestMethod]
        public void EditCustomerAndCancel()
        {
            Assert.AreEqual(_custId, View.CustomerNumber);
            Assert.AreEqual(_customerName, View.CustomerName);
            Assert.AreEqual(_supplier, View.Supplier);
            Assert.AreEqual(_sbsDebitNumber, View.SbsDebitNumber);
            Assert.AreEqual(_sbsAdressNumber, View.SbsAdressNumber);
            Assert.AreEqual(_sbsBillingTenant, View.SbsBillingTenant);
            Assert.AreEqual(_sbsCurrency, View.SbsCurrency);
            Assert.AreEqual(_sapNumber, View.SapNumber);
            Assert.AreEqual(_segment, View.Segment);
            Assert.AreEqual(_ep2MerchantId, View.Ep2MerchantId);

            StringAssert.Matches(View.SbsDebitNumber, new Regex(TestRegExpPatterns.SbsDebitorNo));
            StringAssert.Matches(View.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNoOpt));
            StringAssert.Matches(View.Ep2MerchantId, new Regex(TestRegExpPatterns.Ep2MerchantId));

            Assert.AreEqual(_companyName, View.CompanyName);
            Assert.AreEqual(_po, View.Po);
            Assert.AreEqual(_adressAddition, View.AdressAddition);
            Assert.AreEqual(_streetName, View.StreetNo);
            Assert.AreEqual(_zip, View.Zip);
            Assert.AreEqual(_city, View.City);
            Assert.AreEqual(_agency, View.Agency);
            Assert.AreEqual(_language, View.Language);
            Assert.AreEqual(_country, View.Country);
            Assert.AreEqual(_email, View.Email);
            Assert.AreEqual(_telephone, View.Telephone);
            Assert.AreEqual(_mobile, View.Mobile);
            Assert.AreEqual(_fax, View.Fax);
            Assert.AreEqual(_web, View.Web);
        }
    }
}