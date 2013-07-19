using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Customer.Create
{
    [TestClass]
    public class CustomerCreateWithManualEp2NumberTest
    {
        private static CustomerCreate _customerCreate;
        private static CustomerMenu _customerMenu;

        private static string _adressAddition;
        private static string _cashIntegrator;
        private static string _agency;
        private static string _categoryCode;
        private static string _city;
        private static string _companyName;
        private static string _country;
        private static string _customerName;
        private static string _segment;

        private static long _dt;
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
        private static FormAlert _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _customerCreate = new CustomerCreate();
            _formAlerts = new FormAlert();

            _dt = DateTime.Now.Ticks; //timestamp for each test

            _supplier = "SIX Payment Services AG";
            _sbsCurrency = "EUR";
            _sbsBillingTenant = "SIX Payment Services (Europe)";
            _customerName = "SYR Kunde" + _dt;
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

            TestLauncher.Navigate("");

            _customerMenu.CustomerCreate.Click();

            _customerCreate.Supplier = _supplier;
            _customerCreate.SbsCurrency = _sbsCurrency;
            _customerCreate.SbsBillingTenant = _sbsBillingTenant;
            _customerCreate.CustomerName = _customerName;
            _customerCreate.CategoryCode = _categoryCode;
            _customerCreate.SupportContract = _supportContract;
            _customerCreate.CashIntegrator = _cashIntegrator;
            _customerCreate.Segment = _segment;
            _customerCreate.CompanyName = _companyName;
            _customerCreate.StreetNo = _streetName;
            _customerCreate.Zip = _zip;
            _customerCreate.City = _city;
            _customerCreate.Po = _po;
            _customerCreate.AdressAddition = _adressAddition;
            _customerCreate.Region = _region;
            _customerCreate.SapNumber = _sapNumber;
            _customerCreate.Agency = _agency;
            _customerCreate.Language = _language;
            _customerCreate.Country = _country;
            _customerCreate.Email = _email;
            _customerCreate.Telephone = _telephone;
            _customerCreate.Mobile = _mobile;
            _customerCreate.Fax = _fax;
            _customerCreate.Web = _web;
        }

        [TestMethod]
        public void TooShortEp2Number()
        {
            _customerCreate.Ep2MerchantId = "55555";
            _customerCreate.SaveButton.Click();
            Assert.AreEqual(1, _formAlerts.FormAlertList.Count);
            CollectionAssert.Contains(_formAlerts.FormAlertList, "Kundennummer schon vergeben");
        }

        [TestMethod]
        public void NegativeEp2Number()
        {
            _customerCreate.Ep2MerchantId = "-22";
            _customerCreate.SaveButton.Click();
            Assert.AreEqual(1, _formAlerts.FormAlertList.Count);
            CollectionAssert.Contains(_formAlerts.FormAlertList, "Kundennummer ungültig");
        }

        [TestMethod]
        public void InvalidCharactersEp2Number()
        {
            _customerCreate.Ep2MerchantId = "A*%D01111111115";
            _customerCreate.SaveButton.Click();
            Assert.AreEqual(1, _formAlerts.FormAlertList.Count);
            CollectionAssert.Contains(_formAlerts.FormAlertList, "Kundennummer ungültig");
        }

        [TestMethod]
        public void AlmostValidEp2Number()
        {
            _customerCreate.Ep2MerchantId = "TKSYR000000014";
            _customerCreate.SaveButton.Click();
            Assert.AreEqual(1, _formAlerts.FormAlertList.Count);
            CollectionAssert.Contains(_formAlerts.FormAlertList, "Kundennummer ungültig");
        }
    }
}