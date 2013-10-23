using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Edit
{
    [TestClass]
    public class EditContactWithInvalidDataTest
    {
        private readonly string _contactId;

        public EditContactWithInvalidDataTest(string contactId)
        {
            _contactId = contactId;
        }

        [ClassInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("/Pages/Person/ContactPersonEdit.aspx?PageMode=view&PersonId=" + _contactId);
            ContactMenu.ContactEdit.Click();

            ContactPersonEdit.Salutation = "Herr";
            ContactPersonEdit.FirstName = "Marc[]rn$°";
            ContactPersonEdit.Name = "Siegmund[]rn$°";
            ContactPersonEdit.Language = "Italienisch [it]";
            ContactPersonEdit.Telephone = "0123456789[]rn$°";
            ContactPersonEdit.Mobile = "1234567890[]rn$°";
            ContactPersonEdit.Fax = "2345678901[]rn$°";
            ContactPersonEdit.Email = "tksyr_contact@six-group.com[]rn$°";
            ContactPersonEdit.Po = "Pof[]rn$°";
            ContactPersonEdit.StreetNo = "Strasse 1[]rn$°";
            ContactPersonEdit.Zip = "[]rn$°";
            ContactPersonEdit.City = "City[]rn$°";
            ContactPersonEdit.Region = "Reg[]rn$°";
            ContactPersonEdit.Country = "Frankreich [FR]";

            ContactPersonEdit.AdressAddition = "Addr[]rn$°";

            ContactPersonEdit.SaveButton.Click();
        }

        [TestMethod]
        public void FirstNameInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Vorname: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void NameInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Nachname: Ungültige Zeichen gefunden!");
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
        public void StreetAndNumberInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void ZipInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void PoInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Postfach: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void CityInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void Invalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Region (Kurzzeichen): Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void EmailInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Email: Dies ist keine gültige E-Email Adresse!");
        }

        [TestMethod]
        public void AdressAdditionInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Zusatz: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void FormAlertCounts()
        {
            Assert.AreEqual(12, FormAlert.FormAlertList.Count);
        }
    }
}