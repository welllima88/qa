using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Create
{
    [TestClass]
    public class CustomerCreateWithMissingDataTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate();
            CustomerMenu.CustomerCreate.Click();
        }

        [TestInitialize]
        public void TestInit()
        {
            CustomerCreate.CustomerName = "SYR Sele Kunde A";
            CustomerCreate.Supplier = "SIX Payment Services AG";
            CustomerCreate.SbsCurrency = "EUR";
            CustomerCreate.SbsBillingTenant = "SIX Payment Services (Europe)";

            CustomerCreate.CompanyName = "SYR Sele Firma A";
            CustomerCreate.StreetNo = "Hardturmstr. 201";
            CustomerCreate.Zip = "8021";
            CustomerCreate.City = "Zürich";
            CustomerCreate.Po = "PFO1";
            CustomerCreate.AdressAddition = "Etage 3";
            CustomerCreate.Region = "Reg 3";
            CustomerCreate.SapNumber = "4440";

            CustomerCreate.Agency = "Albert Brun & Partner";

            CustomerCreate.Email = "marc.siegmund@six-group.com";
            CustomerCreate.Telephone = "0031 58 399 6237";
            CustomerCreate.Mobile = "0032 58 399 6237";
            CustomerCreate.Fax = "0033 58 399 6237";
            CustomerCreate.Web = "www.six-group.com/de-intern";
            CustomerCreate.Language = "Deutsch [de]";
            CustomerCreate.Country = "Schweiz [CH]";
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
        }

        [TestMethod]
        public void CreateCustomerWithoutCustomerNameFailed()
        {
            CustomerCreate.CustomerName = "";
            CustomerCreate.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Kundenname: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateCustomerWithoutCompanyNameFailed()
        {
            CustomerCreate.CompanyName = "";
            CustomerCreate.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateCustomerWithoutStreetAndNumberFailed()
        {
            CustomerCreate.StreetNo = "";
            CustomerCreate.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateCustomerWithoutCityFailed()
        {
            CustomerCreate.City = "";
            CustomerCreate.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateCustomerWithoutZipFailed()
        {
            CustomerCreate.Zip = "";
            CustomerCreate.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateCustomerWithoutMandantFailed()
        {
            CustomerCreate.Supplier = "";
            CustomerCreate.SaveButton.Click();

            // Removed: thx to suggester: Assert.IsTrue(FormAlert.FormAlertList.Count == 1);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Mandant: Dies ist ein Pflichtfeld!");
        }
    }
}