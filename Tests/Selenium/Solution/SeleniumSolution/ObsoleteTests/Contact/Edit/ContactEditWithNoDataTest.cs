using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Contact.Edit
{
    [TestFixture]
    public class ContactEditWithNoDataTest
    {
        private static string _contactId;

        [TestFixtureSetUp]
        public static void TestInit()
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

        [Test]
        public void NumberOfFormAlerts()
        {
            Assert.AreEqual(5, FormAlert.FormAlertList.Count);
        }

        [Test]
        public void NameInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Name: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void FirstNameInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Vorname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void StreetAndNumberInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void ZipInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void CityInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }
    }
}