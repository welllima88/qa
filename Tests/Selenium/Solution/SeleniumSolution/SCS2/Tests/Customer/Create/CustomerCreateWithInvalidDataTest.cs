using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Customer.Create
{
    [TestClass]
    public class CustomerCreateWithInvalidDataTest
    {
        private static CustomerCreate _customerCreate;
        private static FormAlert _formAlert;
        private static CustomerMenu _customerMenu;

        private static List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts

            _customerMenu = new CustomerMenu();
            _customerCreate = new CustomerCreate();
            _formAlert = new FormAlert();

            TestLauncher.Navigate("");

            _customerMenu.CustomerCreate.Click();

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
            _customerCreate.Ep2MerchantId = "12DDFF_3-3";
            _customerCreate.Agency = "Albert Brun & Partner";
            _customerCreate.Language = "Deutsch [de]";
            _customerCreate.Country = "Schweiz [CH]";
            _customerCreate.Email = "marc.siegmund@six-grou$°p.com";
            _customerCreate.Telephone = "0031 58 399 6237$";
            _customerCreate.Mobile = "0032 58 399 6237$";
            _customerCreate.Fax = "0033 58 399 6237$";
            _customerCreate.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            _customerCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
        }

        [TestMethod]
        public void CreateCustomerWithInvalidCustomerNameFailed()
        {
            CollectionAssert.Contains(_formAlerts, "Kundenname: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void CreateCustomerWithInvalidCustomerNumberFailed()
        {
            CollectionAssert.Contains(_formAlerts, "Kundennummer: Ihre Eingabe ist ungültig!");
        }

        [TestMethod]
        public void CreateCustomerWithInvalidCompanyNameFailed()
        {
            CollectionAssert.Contains(_formAlerts, "Firmenname: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void CreateCustomerWithInvalidAdressAdditionFailed()
        {
            CollectionAssert.Contains(_formAlerts, "Zusatz: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void CreateCustomerWithInvalidTelephoneFailed()
        {
            CollectionAssert.Contains(_formAlerts, "Telefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void CreateCustomerWithInvalidMobileFailed()
        {
            CollectionAssert.Contains(_formAlerts, "Mobiltelefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void CreateCustomerWithInvalidFaxFailed()
        {
            CollectionAssert.Contains(_formAlerts, "Fax: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void CreateCustomerWithInvalidStreetNumberFailed()
        {
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void CreateCustomerWithInvalidZipFailed()
        {
            CollectionAssert.Contains(_formAlerts, "PLZ: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void CreateCustomerWithInvalidPoFailed()
        {
            CollectionAssert.Contains(_formAlerts, "Postfach: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void CreateCustomerWithInvalidCityFailed()
        {
            CollectionAssert.Contains(_formAlerts, "Ort: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void CreateCustomerWithInvalidRegionFailed()
        {
            CollectionAssert.Contains(_formAlerts, "Region (Kurzzeichen): Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void CreateCustomerWithInvalidEmailFailed()
        {
            CollectionAssert.Contains(_formAlerts, "Email: Dies ist keine gültige E-Mail Adresse!");
        }

        [TestMethod]
        public void CreateCustomerWithInvalidWebFailed()
        {
            CollectionAssert.Contains(_formAlerts, "Web: Dies ist keine gültige Web Adresse!");
        }

        [TestMethod]
        public void CreateCustomerWithInvalidEp2MerchantIdFailed()
        {
            CollectionAssert.Contains(_formAlerts, "Dies ist keine gültige EP2 Händlernummer.");
        }
    }
}