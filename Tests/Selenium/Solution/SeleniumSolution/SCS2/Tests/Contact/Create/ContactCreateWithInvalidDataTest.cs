using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Create
{
    [TestClass]
    public class ContactCreateWithInvalidDataTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=401152");

            CustomerMenu.ContactCreate.Click();

            ContactPersonCreate.Salutation = "Herr^@}$°";
            ContactPersonCreate.FirstName = "Marc^@}$°";
            ContactPersonCreate.Name = "SYR AUTO ^@}$°";
            ContactPersonCreate.Telephone = "+41 58 399 ^@}$° - 1";
            ContactPersonCreate.Mobile = "+41 58 399 ^@}$° - 2";
            ContactPersonCreate.Fax = "+41 58 399 ^@}$° - 3";
            ContactPersonCreate.Email = "con^@}$°tact@six-group.com";
            ContactPersonCreate.StreetNo = "Kontakt-^@}$° 1";
            ContactPersonCreate.Po = "P^@}$°";
            ContactPersonCreate.Zip = "^@}$°";
            ContactPersonCreate.City = "^City@}$°";
            ContactPersonCreate.Region = "Re^@}$°";
            ContactPersonCreate.AddressAddition = "Add^@}$°";

            ContactPersonCreate.SaveButton.Click();
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