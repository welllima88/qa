using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Common;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Common.Menu;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Person;
using Six.Scs.Tests.Selenium.Extension.WebDriver;

namespace Six.Scs.Tests.Selenium.Tests.Contact.Create
{
    [TestClass]
    public class ContactCreateWithNoDataTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Customer/?CustomerId=401152");

            CustomerMenu.ContactCreate.Click();

            ContactPersonCreate.SaveButton.Click();
        }

        [TestMethod]
        public void FirstNameMissing()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Vorname: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void SurnameMissing()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Nachname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void StreetMissing()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void ZipMissing()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CityMissing()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void NumberOfFormAlerts()
        {
            Assert.AreEqual(5, FormAlert.FormAlertList.Count);
        }
    }
}