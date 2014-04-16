using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Create
{
    [TestClass]
    public class ContactCreateWithMissingDataTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Customer/?CustomerId=401152");

            CustomerMenu.ContactCreate.Click();

            ContactPersonCreate.Salutation = "Herr";
            ContactPersonCreate.FirstName = "Marc";
            ContactPersonCreate.Name = "Siegmund SYR AUTO";
            ContactPersonCreate.Language = "de";
            ContactPersonCreate.Telephone = "+41 58 399 6237 - 1";
            ContactPersonCreate.Mobile = "+41 58 399 6237 - 2";
            ContactPersonCreate.Fax = "+41 58 399 6237 - 3";
            ContactPersonCreate.Email = "contact@six-group.com";
            ContactPersonCreate.StreetNo = "Kontakt-Weg 1";
            ContactPersonCreate.Po = "POC";
            ContactPersonCreate.Zip = "55555";
            ContactPersonCreate.City = "Berlin";
            ContactPersonCreate.Region = "Mitte";
            ContactPersonCreate.Country = "DE";
            ContactPersonCreate.AdressAddition = "Zusatz1";
        }

        [TestMethod]
        public void WithoutFirstName()
        {
            ContactPersonCreate.FirstName = "";

            ContactPersonCreate.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Vorname: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void WithoutLastName()
        {
            ContactPersonCreate.Name = "";

            ContactPersonCreate.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Name: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void WithoutStreetAndNumber()
        {
            ContactPersonCreate.StreetNo = "";

            ContactPersonCreate.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void WithoutCityFailed()
        {
            ContactPersonCreate.City = "";

            ContactPersonCreate.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void WithoutZipFailed()
        {
            ContactPersonCreate.Zip = "";

            ContactPersonCreate.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }
    }
}