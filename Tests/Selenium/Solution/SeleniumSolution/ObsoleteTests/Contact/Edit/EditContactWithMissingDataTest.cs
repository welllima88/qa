using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Contact.Edit
{
    [TestFixture]
    public class EditContactWithMissingDataTest
    {
        private readonly string _contactId;

        public EditContactWithMissingDataTest(string contactId)
        {
            _contactId = contactId;
        }

        [SetUp]
        public void TestInit()
        {
            TestDirector.Navigate("Person/?PERSONID=" + _contactId);

            ContactMenu.ContactEdit.Click();

            Person.Edit.Salutation = "Herr";
            Person.Edit.FirstName = "Marc";
            Person.Edit.Name = "Siegmund";
            Person.Edit.Language = "Italienisch [it]";
            Person.Edit.Telephone = "0123456789";
            Person.Edit.Mobile = "1234567890";
            Person.Edit.Fax = "2345678901";
            Person.Edit.Email = "tksyr_contact@six-group.com";
            Person.Edit.Po = "Pof";
            Person.Edit.StreetNo = "Strasse 1";
            Person.Edit.Zip = "2351";
            Person.Edit.City = "City";
            Person.Edit.Region = "Reg";
            Person.Edit.Country = "Frankreich [FR]";
            Person.Edit.AdressAddition = "Addr-Add";
        }

        [Test]
        public void EditContactWithoutFirstNameFailed()
        {
            Person.Edit.FirstName = "";
            Person.Edit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void EditContactWithoutNameFailed()
        {
            Person.Edit.Name = "";
            Person.Edit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void EditContactWithoutStreetAndNumberFailed()
        {
            Person.Edit.StreetNo = "";

            Person.Edit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void EditContactWithoutCityFailed()
        {
            Person.Edit.City = "";

            Person.Edit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void EditContactWithoutZipFailed()
        {
            Person.Edit.Zip = "";
            Person.Edit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }
    }
}