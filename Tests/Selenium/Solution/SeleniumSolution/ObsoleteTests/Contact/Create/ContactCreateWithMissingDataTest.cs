using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Contact.Create
{
    [TestClass]
    public class ContactCreateWithMissingDataTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Customer/?CustomerId=401152");

            CustomerMenu.ContactCreate.Click();

            Person.Create.Salutation = "Herr";
            Person.Create.FirstName = "Marc";
            Person.Create.Name = "Siegmund SYR AUTO";
            Person.Create.Language = "de";
            Person.Create.Telephone = "+41 58 399 6237 - 1";
            Person.Create.Mobile = "+41 58 399 6237 - 2";
            Person.Create.Fax = "+41 58 399 6237 - 3";
            Person.Create.Email = "contact@six-group.com";
            Person.Create.StreetNo = "Kontakt-Weg 1";
            Person.Create.Po = "POC";
            Person.Create.Zip = "55555";
            Person.Create.City = "Berlin";
            Person.Create.Region = "Mitte";
            Person.Create.Country = "DE";
            Person.Create.AdressAddition = "Zusatz1";
        }

        [TestMethod]
        public void WithoutFirstName()
        {
            Person.Create.FirstName = "";

            Person.Create.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Vorname: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void WithoutLastName()
        {
            Person.Create.Name = "";

            Person.Create.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Name: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void WithoutStreetAndNumber()
        {
            Person.Create.StreetNo = "";

            Person.Create.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void WithoutCityFailed()
        {
            Person.Create.City = "";

            Person.Create.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void WithoutZipFailed()
        {
            Person.Create.Zip = "";

            Person.Create.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }
    }
}