using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Create
{
    [TestFixture]
    public class MissingData
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();
            CustomerMenu.CustomerCreate.Click();
        }

        [SetUp]
        public void TestInit()
        {
            Selenium.Customer.Create.CustomerName = "SYR Sele Kunde A";
            Selenium.Customer.Create.Supplier = "SIX Payment Services AG";
            Selenium.Customer.Create.SbsCurrency = "EUR";
            Selenium.Customer.Create.SbsBillingTenant = "SIX Payment Services (Europe)";

            Selenium.Customer.Create.CompanyName = "SYR Sele Firma A";
            Selenium.Customer.Create.StreetNo = "Hardturmstr. 201";
            Selenium.Customer.Create.Zip = "8021";
            Selenium.Customer.Create.City = "Zürich";
            Selenium.Customer.Create.Po = "PFO1";
            Selenium.Customer.Create.AdressAddition = "Etage 3";
            Selenium.Customer.Create.Region = "Reg 3";
            Selenium.Customer.Create.SapNumber = "4440";

            Selenium.Customer.Create.Agency = "Albert Brun & Partner";

            Selenium.Customer.Create.Email = "marc.siegmund@six-group.com";
            Selenium.Customer.Create.Telephone = "0031 58 399 6237";
            Selenium.Customer.Create.Mobile = "0032 58 399 6237";
            Selenium.Customer.Create.Fax = "0033 58 399 6237";
            Selenium.Customer.Create.Web = "www.six-group.com/de-intern";
            Selenium.Customer.Create.Language = "Deutsch [de]";
            Selenium.Customer.Create.Country = "Schweiz [CH]";
        }

        [TearDown]
        public void TearDown()
        {
        }

        [TestFixtureTearDown]
        public static void TestFixtureTearDown()
        {
        }

        [Test]
        public void CreateCustomerWithoutCustomerNameFailed()
        {
            Selenium.Customer.Create.CustomerName = "";
            Selenium.Customer.Create.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Kundenname: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void CreateCustomerWithoutCompanyNameFailed()
        {
            Selenium.Customer.Create.CompanyName = "";
            Selenium.Customer.Create.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void CreateCustomerWithoutStreetAndNumberFailed()
        {
            Selenium.Customer.Create.StreetNo = "";
            Selenium.Customer.Create.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void CreateCustomerWithoutCityFailed()
        {
            Selenium.Customer.Create.City = "";
            Selenium.Customer.Create.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void CreateCustomerWithoutZipFailed()
        {
            Selenium.Customer.Create.Zip = "";
            Selenium.Customer.Create.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void CreateCustomerWithoutMandantFailed()
        {
            Selenium.Customer.Create.Supplier = "";
            Selenium.Customer.Create.SaveButton.Click();

            // Removed: thx to suggester: Assert.IsTrue(FormAlert.FormAlertList.Count == 1);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Mandant: Dies ist ein Pflichtfeld!");
        }
    }
}