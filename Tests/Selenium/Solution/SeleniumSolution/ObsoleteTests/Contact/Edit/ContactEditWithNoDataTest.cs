using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Person;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Contact.Edit
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

            Person.Edit.Salutation = "";
            Person.Edit.FirstName = "";
            Person.Edit.Name = "";
            Person.Edit.Telephone = "";
            Person.Edit.Mobile = "";
            Person.Edit.Fax = "";
            Person.Edit.Email = "";

            Person.Edit.Po = "";
            Person.Edit.StreetNo = "";
            Person.Edit.Zip = "";
            Person.Edit.City = "";
            Person.Edit.Region = "";
            Person.Edit.AdressAddition = "";
            Person.Edit.Web = "";

            Person.Edit.SaveButton.Click();
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