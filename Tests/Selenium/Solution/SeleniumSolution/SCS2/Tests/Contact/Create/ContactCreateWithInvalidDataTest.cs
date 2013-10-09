using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Create
{
    [TestClass]
    public class ContactCreateWithInvalidDataTest
    {
        private static ContactPersonCreate _contactPersonCreate;
        private static FormAlert _formAlert;
        private static CustomerMenu _customerMenu;

        private static List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _contactPersonCreate = new ContactPersonCreate();
            _formAlert = new FormAlert();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=401152");

            _customerMenu.ContactCreate.Click();

            _contactPersonCreate.Salutation = "Herr^@}$°";
            _contactPersonCreate.FirstName = "Marc^@}$°";
            _contactPersonCreate.Name = "SYR AUTO ^@}$°";
            _contactPersonCreate.Telephone = "+41 58 399 ^@}$° - 1";
            _contactPersonCreate.Mobile = "+41 58 399 ^@}$° - 2";
            _contactPersonCreate.Fax = "+41 58 399 ^@}$° - 3";
            _contactPersonCreate.Email = "con^@}$°tact@six-group.com";
            _contactPersonCreate.StreetNo = "Kontakt-^@}$° 1";
            _contactPersonCreate.Po = "P^@}$°";
            _contactPersonCreate.Zip = "^@}$°";
            _contactPersonCreate.City = "^City@}$°";
            _contactPersonCreate.Region = "Re^@}$°";
            _contactPersonCreate.AddressAddition = "Add^@}$°";

            _contactPersonCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
        }

        [TestMethod]
        public void SalutationInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Anreade: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void FirstNameInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Vorname: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void LastNameInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Nachname: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void AdditionInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Zusatz: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void TelephoneInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Telefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void MobileInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Mobiltelefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void FaxInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Fax: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void StreetAndNoInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void ZipInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "PLZ: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void CityInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Ort: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void RegionInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Region (Kurzzeichen): Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void EmailInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Email: Dies ist keine gültige E-Email Adresse!");
        }

        [TestMethod]
        public void WebInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Web: Dies ist keine gültige Web Adresse!");
        }

        [TestMethod]
        public void NumberOfFormAlerts()
        {
            Assert.AreEqual(13, _formAlerts.Count);
        }
    }
}