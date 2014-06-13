using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.Tests.Selenium.Extension.Selenium;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Person;

namespace SIX.SCS.Tests.Selenium.Tests.Contact.Edit
{
    [TestClass]
    public class ContactEditWithNoDataTest
    {
        private static string _contactId;

        [ClassInitialize]
        public static void TestInit(TestContext testContext)
        {
            _contactId = "31432";
            TestDirector.Navigate("Person/?PERSONID=" + _contactId);

            ContactMenu.ContactEdit.Click();

            ContactPersonEdit.Salutation = "";
            ContactPersonEdit.FirstName = "";
            ContactPersonEdit.Name = "";
            ContactPersonEdit.Telephone = "";
            ContactPersonEdit.Mobile = "";
            ContactPersonEdit.Fax = "";
            ContactPersonEdit.Email = "";

            ContactPersonEdit.Po = "";
            ContactPersonEdit.StreetNo = "";
            ContactPersonEdit.Zip = "";
            ContactPersonEdit.City = "";
            ContactPersonEdit.Region = "";
            ContactPersonEdit.AdressAddition = "";
            ContactPersonEdit.Web = "";

            ContactPersonEdit.SaveButton.Click();
        }

        [TestMethod]
        public void NumberOfFormAlerts()
        {
            Assert.AreEqual(5, FormAlert.FormAlertList.Count);
        }

        [TestMethod]
        public void NameInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Name: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void FirstNameInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Vorname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void StreetAndNumberInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void ZipInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CityInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }
    }
}