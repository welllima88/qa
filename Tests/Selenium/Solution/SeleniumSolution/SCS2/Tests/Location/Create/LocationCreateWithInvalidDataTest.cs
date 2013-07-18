using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Location.Create
{
    [TestClass]
    public class LocationCreateWithInvalidDataTest
    {
        private static FormAlert _formAlert;
        private static LocationCreate _locationCreate;
        private static CustomerMenu _customerMenu;

        private static List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _locationCreate = new LocationCreate();
            _formAlert = new FormAlert();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=404871");

            _customerMenu.LocationCreate.Click();

            _locationCreate.CompanyName = "SYR Sele Firma A$°";
            _locationCreate.StreetNo = "Hardturmstr. 201$°";
            _locationCreate.Zip = "802$°";
            _locationCreate.City = "Zürich$°";
            _locationCreate.Po = "PFO1$°";
            _locationCreate.AdressAddition = "Etage 3$°";
            _locationCreate.Region = "Reg 3[]$°";
            _locationCreate.SapNumber = "444$°";

            _locationCreate.Language = "Deutsch [de]";
            _locationCreate.Country = "Schweiz [CH]";
            _locationCreate.Email = "marc.siegmund@six-grou$°p.com";
            _locationCreate.Telephone = "0031 58 399 6237$";
            _locationCreate.Mobile = "0032 58 399 6237$";
            _locationCreate.Fax = "0033 58 399 6237$";
            _locationCreate.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            _locationCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
        }

        [TestMethod]
        public void CompanyNameInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Firmenname: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void AdressAdditionInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Zusatz: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void TelephoneInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Telefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void MobileNumberInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Mobiltelefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void FaxInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Fax: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void StreetNumberInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void ZipInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "PLZ: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void PoInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Postfach: Ungültige Zeichen gefunden!");
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
            CollectionAssert.Contains(_formAlerts, "Email: Dies ist keine gültige E-Mail Adresse!");
        }

        [TestMethod]
        public void WebInvalid()
        {
            CollectionAssert.Contains(_formAlerts, "Web: Dies ist keine gültige Web Adresse!");
        }

        [TestMethod]
        public void NumberOfFormAlerts()
        {
            Assert.AreEqual(12, _formAlerts.Count);
        }
    }
}