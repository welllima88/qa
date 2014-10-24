using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Contact.Edit
{
    [TestClass]
    public class EditContactWithInvalidDataTest
    {
        private static string _contactId;

        [ClassInitialize]
        public static void TestInit(TestContext testContext)
        {
            _contactId = "31432";
            TestDirector.Navigate("Person/?PERSONID=" + _contactId);
            ContactMenu.ContactEdit.Click();

            Person.Edit.Salutation = "Herr";
            Person.Edit.FirstName = "Marc[]rn$°";
            Person.Edit.Name = "Siegmund[]rn$°";
            Person.Edit.Language = "it";
            Person.Edit.Telephone = "0123456789[]rn$°";
            Person.Edit.Mobile = "1234567890[]rn$°";
            Person.Edit.Fax = "2345678901[]rn$°";
            Person.Edit.Email = "tksyr_contact@six-group.com[]rn$°";
            Person.Edit.Po = "Pof[]rn$°";
            Person.Edit.StreetNo = "Strasse 1[]rn$°";
            Person.Edit.Zip = "[]rn$°";
            Person.Edit.City = "City[]rn$°";
            Person.Edit.Region = "Reg[]rn$°";
            Person.Edit.Country = "IT";
            Person.Edit.AdressAddition = "Addr[]rn$°";
            // ContactPersonEdit.Web = "Web[]rn$°";

            Person.Edit.SaveButton.Click();
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
        public void WebInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Web: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void FormAlertCounts()
        {
            Assert.AreEqual(12, FormAlert.FormAlertList.Count);
        }
    }
}