using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Create
{
    [TestClass]
    public class LocationCreateWithInvalidDataTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=404871");

            CustomerMenu.LocationCreate.Click();

            LocationCreate.CompanyName = "SYR Sele Firma A$°";
            LocationCreate.StreetNo = "Hardturmstr. 201$°";
            LocationCreate.Zip = "802$°";
            LocationCreate.City = "Zürich$°";
            LocationCreate.Po = "PFO1$°";
            LocationCreate.AdressAddition = "Etage 3$°";
            LocationCreate.Region = "Reg 3[]$°";
            LocationCreate.SapNumber = "444$°";

            LocationCreate.Language = "Deutsch [de]";
            LocationCreate.Country = "Schweiz [CH]";
            LocationCreate.Email = "marc.siegmund@six-grou$°p.com";
            LocationCreate.Telephone = "0031 58 399 6237$";
            LocationCreate.Mobile = "0032 58 399 6237$";
            LocationCreate.Fax = "0033 58 399 6237$";
            LocationCreate.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            LocationCreate.SaveButton.Click();
        }

        [TestMethod]
        public void CompanyNameInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void AdressAdditionInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Zusatz: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void TelephoneInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Telefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void MobileNumberInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Mobiltelefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void FaxInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Fax: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void StreetNumberInvalid()
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
        public void RegionInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Region (Kurzzeichen): Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void EmailInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Email: Dies ist keine gültige E-Mail Adresse!");
        }

        [TestMethod]
        public void WebInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Web: Dies ist keine gültige Web Adresse!");
        }

        [TestMethod]
        public void NumberOfFormAlerts()
        {
            Assert.AreEqual(12, FormAlert.FormAlertList.Count);
        }
    }
}