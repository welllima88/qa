using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Person;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Contact.Create
{
    [TestClass]
    public class ContactCreateWithInvalidDataTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Customer/?CustomerId=401152");

            CustomerMenu.ContactCreate.Click();

            Person.Create.Salutation = "Herr^@}$°";
            Person.Create.FirstName = "Marc^@}$°";
            Person.Create.Name = "SYR AUTO ^@}$°";
            Person.Create.Telephone = "+41 58 399 ^@}$° - 1";
            Person.Create.Mobile = "+41 58 399 ^@}$° - 2";
            Person.Create.Fax = "+41 58 399 ^@}$° - 3";
            Person.Create.Email = "con^@}$°tact@six-group.com";
            Person.Create.StreetNo = "Kontakt-^@}$° 1";
            Person.Create.Po = "P^@}$°";
            Person.Create.Zip = "^@}$°";
            Person.Create.City = "^City@}$°";
            Person.Create.Region = "Re^@}$°";
            Person.Create.AdressAddition = "Add^@}$°";
            Person.Create.Web = "Add^@}$°";

            Person.Create.SaveButton.Click();
        }

        [TestMethod]
        public void SalutationInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Anreade: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void FirstNameInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Vorname: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void LastNameInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Nachname: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void AdditionInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Zusatz: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void TelephoneInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Telefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void MobileInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Mobiltelefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void FaxInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Fax: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void StreetAndNoInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void ZipInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void CityInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void RegionInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Region (Kurzzeichen): Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void EmailInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Email: Dies ist keine gültige E-Email Adresse!");
        }

        [TestMethod]
        public void WebInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Web: Dies ist keine gültige Web Adresse!");
        }

        [TestMethod]
        public void NumberOfFormAlerts()
        {
            Assert.AreEqual(13, FormAlert.FormAlertList.Count);
        }
    }
}