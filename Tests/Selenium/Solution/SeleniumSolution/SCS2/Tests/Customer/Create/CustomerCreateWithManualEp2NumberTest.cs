using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.TestData;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common.Menu;
using Six.Scs.QA.Selenium.Extension.TestObjects.Customer;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.Tests.Customer.Create
{
    [TestClass]
    public class CustomerCreateWithManualEp2NumberTest
    {
        private static string _adressAddition;
        private static string _cashIntegrator;
        private static string _agency;
        private static string _categoryCode;
        private static string _city;
        private static string _companyName;
        private static string _country;
        private static string _customerName;
        private static string _segment;

        private static string _email;
        private static string _fax;
        private static string _language;
        private static string _mobile;
        private static string _po;
        private static string _region;
        private static string _sapNumber;
        private static string _sbsBillingTenant;
        private static string _sbsCurrency;
        private static string _streetName;
        private static string _supplier;
        private static string _supportContract;
        private static string _telephone;
        private static string _web;
        private static string _zip;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _supplier = "SIX Payment Services AG";
            _sbsCurrency = "EUR";
            _sbsBillingTenant = "SIX Payment Services (Europe)";
            _customerName = "SYR Kunde" + Factory.GenerateTestId();
            _categoryCode = "3364: AGENCY RENT-A-CAR";
            _supportContract = "ServicePaket Top Account - Störungsbehebung vor Ort Mo-So 5h";
            _cashIntegrator = "Wincor Nixdorf AG, Brüttisellen";
            _segment = "01_CH";
            _companyName = "SYR Sele Firma A";
            _streetName = "Hardturmstr. 201";
            _agency = "B05 Leiser Peter";
            _zip = "8021";
            _city = "Zürich";
            _po = "PFO1";
            _adressAddition = "Etage 3";
            _region = "Reg 3";
            _sapNumber = "4440";
            _language = "Deutsch [de]";
            _country = "Schweiz [CH]";
            _email = "marc.siegmund@six-group.com";
            _telephone = "0031 58 399 6237";
            _mobile = "0032 58 399 6237";
            _fax = "0033 58 399 6237";
            _web = "www.six-group.com/de-intern";

            TestDirector.Navigate();

            CustomerMenu.CustomerCreate.Click();

            CustomerCreate.Supplier = _supplier;
            CustomerCreate.SbsCurrency = _sbsCurrency;
            CustomerCreate.SbsBillingTenant = _sbsBillingTenant;
            CustomerCreate.CustomerName = _customerName;
            CustomerCreate.CategoryCode = _categoryCode;
            CustomerCreate.SupportContract = _supportContract;
            CustomerCreate.CashIntegrator = _cashIntegrator;
            CustomerCreate.Segment = _segment;
            CustomerCreate.CompanyName = _companyName;
            CustomerCreate.StreetNo = _streetName;
            CustomerCreate.Zip = _zip;
            CustomerCreate.City = _city;
            CustomerCreate.Po = _po;
            CustomerCreate.AdressAddition = _adressAddition;
            CustomerCreate.Region = _region;
            CustomerCreate.SapNumber = _sapNumber;
            CustomerCreate.Agency = _agency;
            CustomerCreate.Language = _language;
            CustomerCreate.Country = _country;
            CustomerCreate.Email = _email;
            CustomerCreate.Telephone = _telephone;
            CustomerCreate.Mobile = _mobile;
            CustomerCreate.Fax = _fax;
            CustomerCreate.Web = _web;
        }

        [TestMethod]
        public void TooShortEp2Number()
        {
            CustomerCreate.Ep2MerchantId = "55555";
            CustomerCreate.SaveButton.Click();
            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Kundennummer schon vergeben");
        }

        [TestMethod]
        public void NegativeEp2Number()
        {
            CustomerCreate.Ep2MerchantId = "-22";
            CustomerCreate.SaveButton.Click();
            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Kundennummer ungültig");
        }

        [TestMethod]
        public void InvalidCharactersEp2Number()
        {
            CustomerCreate.Ep2MerchantId = "A*%D01111111115";
            CustomerCreate.SaveButton.Click();
            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Kundennummer ungültig");
        }

        [TestMethod]
        public void PartiallyValidEp2Number()
        {
            CustomerCreate.Ep2MerchantId = "TKSYR000000014";
            CustomerCreate.SaveButton.Click();
            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Kundennummer ungültig");
        }
    }
}