using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Contact;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Contact.Create
{
    [TestClass]
    public class ContactCreateWithInvalidDataTest
    {
        private static ContactCreate _contactCreate;
        private static FormAlert _formAlert;
        private static CustomerMenu _customerMenu;

        private static List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _contactCreate = new ContactCreate();
            _formAlert = new FormAlert();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=401152");

            _customerMenu.ContactCreate.Click();

            _contactCreate.Salutation = "Herr^@}$°";
            _contactCreate.FirstName = "Marc^@}$°";
            _contactCreate.Name = "SYR AUTO ^@}$°";
            _contactCreate.Telephone = "+41 58 399 ^@}$° - 1";
            _contactCreate.Mobile = "+41 58 399 ^@}$° - 2";
            _contactCreate.Fax = "+41 58 399 ^@}$° - 3";
            _contactCreate.Email = "con^@}$°tact@six-group.com";
            _contactCreate.Street = "Kontakt-^@}$° 1";
            _contactCreate.Po = "P^@}$°";
            _contactCreate.Zip = "^@}$°";
            _contactCreate.City = "^City@}$°";
            _contactCreate.Region = "Re^@}$°";
            _contactCreate.AddressAddition = "Add^@}$°";

            _contactCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
        }

        [TestMethod]
        public void SalutationInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Anreade: Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void FirstNameInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Vorname: Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void LastNameInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Nachname: Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void AdditionInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Zusatz: Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void TelephoneInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Telefon: Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void MobileInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Mobiltelefon: Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void FaxInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Fax: Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void StreetAndNoInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void ZipInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("PLZ: Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void CityInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Ort: Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void RegionInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Region (Kurzzeichen): Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void EmailInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Email: Dies ist keine gültige E-Email Adresse!"));
        }

        [TestMethod]
        public void WebInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Web: Dies ist keine gültige Web Adresse!"));
        }

        [TestMethod]
        public void NumberOfFormAlerts()
        {
            Assert.AreEqual(13,_formAlerts.Count);
        }
    }
}