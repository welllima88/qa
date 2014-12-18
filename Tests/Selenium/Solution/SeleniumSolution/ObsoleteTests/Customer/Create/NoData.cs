using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Create
{
    [TestFixture]
    public class NoData
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();

            CustomerMenu.CustomerCreate.Click();
            Selenium.Customer.Create.SaveButton.Click();
        }

        [Test]
        public void CustomerNumberOfFormAlerts()
        {
            Assert.AreEqual(7, FormAlert.FormAlertList.Count);
        }

        [Test]
        public void CustomerNameMissingFormAlert()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Kundenname: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void CompanyNameMissingFormAlert()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void SupplierMissingFormAlert()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Mandant: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void StreetNumberMissingFormAlert()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void ZipMissingFormAlert()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void CityMissingFormAlert()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void CountryMissingFormAlert()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Land: Dies ist ein Pflichtfeld!");
        }
    }
}