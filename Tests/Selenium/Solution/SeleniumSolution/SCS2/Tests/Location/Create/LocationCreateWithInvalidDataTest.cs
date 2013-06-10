using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Location.Create
{
    [TestClass]
    public class LocationCreateWithInvalidDataTest
    {
        private static IWebDriverAdapter _driver;
        private static TestDirector _tb;
        private static FormAlert _formAlert;
        private static LocationCreate _locationCreate;
        private static CustomerMenu _customerMenu;

        private static List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login
            _customerMenu = new CustomerMenu(_driver);
            _locationCreate = new LocationCreate(_driver);
            _formAlert = new FormAlert(_driver);

            _driver.Url = _tb.BaseUrl + "/Pages/Customer/CustomerEdit.aspx?CustomerId=404871";

            _customerMenu.LocationCreate.Click();

            _locationCreate.CompanyName = "SYR Sele Firma A$°";
            _locationCreate.StreetName = "Hardturmstr. 201$°";
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

        [TestInitialize]
        public void TestInit()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            //after last test-method finished
            _tb.ShutDownTest();
        }

        [TestMethod]
        public void CompanyNameInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void AdressAdditionInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Zusatz: Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void TelephoneInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Telefon: Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void MobileNumberInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Mobiltelefon: Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void FaxInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Fax: Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void StreetNumberInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void ZipInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("PLZ: Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void PoInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Postfach: Ungültige Zeichen gefunden!"));
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
            Assert.IsTrue(_formAlerts.Contains("Email: Dies ist keine gültige E-Mail Adresse!"));
        }

        [TestMethod]
        public void WebInvalid()
        {
            Assert.IsTrue(_formAlerts.Contains("Web: Dies ist keine gültige Web Adresse!"));
        }

        [TestMethod]
        public void NumberOfFormAlerts()
        {
            Assert.IsTrue(_formAlerts.Count == 12);
        }
    }
}