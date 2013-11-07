using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Create
{
    [TestClass]
    public class CustomerCreateWithInvalidDataTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate();

            CustomerCreate.Supplier = "SIX Payment Services AG";
            CustomerCreate.SbsCurrency = "EUR";
            CustomerCreate.SbsBillingTenant = "SIX Payment Services (Europe)";
            CustomerCreate.CustomerName = "SYR Sele Kunde A$°";
            CustomerCreate.CompanyName = "SYR Sele Firma A$°";
            CustomerCreate.CustomerNumber = "^@}$°";
            CustomerCreate.StreetNo = "Hardturmstr. 201$°";
            CustomerCreate.Zip = "802$°";
            CustomerCreate.City = "Zürich$°";
            CustomerCreate.Po = "PFO1$°";
            CustomerCreate.AdressAddition = "Etage 3$°";
            CustomerCreate.Region = "Reg 3[]$°";
            CustomerCreate.SapNumber = "444$°";
            CustomerCreate.Ep2MerchantId = "12D$F_3-3";
            CustomerCreate.Agency = "Albert Brun & Partner";
            CustomerCreate.Language = "Deutsch [de]";
            CustomerCreate.Country = "Schweiz [CH]";
            CustomerCreate.Email = "marc.siegmund@six-grou$°p.com";
            CustomerCreate.Telephone = "0031 58 399 6237$";
            CustomerCreate.Mobile = "0032 58 399 6237$";
            CustomerCreate.Fax = "0033 58 399 6237$";
            CustomerCreate.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            CustomerCreate.SaveButton.Click();
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create"), TestCategory("Invalid")]
        public void CreateCustomerWithInvalidCustomerNameFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Kundenname: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create"), TestCategory("Invalid")]
        public void CreateCustomerWithInvalidCustomerNumberFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Kundennummer: Ihre Eingabe ist ungültig!");
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create"), TestCategory("Invalid")]
        public void CreateCustomerWithInvalidCompanyNameFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create"), TestCategory("Invalid")]
        public void CreateCustomerWithInvalidAdressAdditionFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Zusatz: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create"), TestCategory("Invalid")]
        public void CreateCustomerWithInvalidTelephoneFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Telefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create"), TestCategory("Invalid")]
        public void CreateCustomerWithInvalidMobileFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Mobiltelefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create"), TestCategory("Invalid")]
        public void CreateCustomerWithInvalidFaxFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Fax: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create"), TestCategory("Invalid")]
        public void CreateCustomerWithInvalidStreetNumberFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create"), TestCategory("Invalid")]
        public void CreateCustomerWithInvalidZipFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create"), TestCategory("Invalid")]
        public void CreateCustomerWithInvalidPoFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Postfach: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create"), TestCategory("Invalid")]
        public void CreateCustomerWithInvalidCityFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create"), TestCategory("Invalid")]
        public void CreateCustomerWithInvalidRegionFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Region (Kurzzeichen): Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create"), TestCategory("Invalid")]
        public void CreateCustomerWithInvalidEmailFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Email: Dies ist keine gültige E-Mail Adresse!");
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create"), TestCategory("Invalid")]
        public void CreateCustomerWithInvalidWebFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Web: Dies ist keine gültige Web Adresse!");
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create"), TestCategory("Invalid")]
        public void CreateCustomerWithInvalidEp2MerchantIdFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Dies ist keine gültige EP2 Händlernummer.");
        }
    }
}