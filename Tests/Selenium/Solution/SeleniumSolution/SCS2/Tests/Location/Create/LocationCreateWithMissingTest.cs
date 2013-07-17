using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Location.Create
{
    [TestClass]
    public class LocationCreateWithMissingTest
    {
        private static LocationView _locationView;
        private static FormAlert _formAlert;
        private static LocationCreate _locationCreate;
        private static LocationMenu _locationMenu;
        private static CustomerMenu _customerMenu;

        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _locationMenu = new LocationMenu();
            _locationCreate = new LocationCreate();
            _locationView = new LocationView();
            _formAlert = new FormAlert();
            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=404871");
        }

        [TestInitialize]
        public void TestInit()
        {
            _locationCreate.CompanyName = "SYR Sele Firma A";
            _locationCreate.StreetName = "Hardturmstr. 201";
            _locationCreate.Zip = "8021";
            _locationCreate.City = "Zürich";
            _locationCreate.Po = "PFO1";
            _locationCreate.AdressAddition = "Etage 3";
            _locationCreate.Region = "Reg 55";
            _locationCreate.SapNumber = "4440";

            _locationCreate.Language = "Deutsch [de]";
            _locationCreate.Country = "Schweiz [CH]";
            _locationCreate.Email = "marc.siegmund@six-group.com";
            _locationCreate.Telephone = "0031 58 399 6237";
            _locationCreate.Mobile = "0032 58 399 6237";
            _locationCreate.Fax = "0033 58 399 6237";
            _locationCreate.Web = "www.six-group.com/de-intern";
        }

        [TestMethod]
        public void CreateLocationrWithoutCompanyNameFailed()
        {
            _customerMenu.LocationCreate.Click();

            _locationCreate.CompanyName = "";

            _locationCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateLocationWithoutStreetAndNumberFailed()
        {
            _customerMenu.LocationCreate.Click();

            _locationCreate.StreetName = "";

            _locationCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateLocationWithoutCityFailed()
        {
            _customerMenu.LocationCreate.Click();

            _locationCreate.City = "";

            _locationCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateLocationWithoutZipFailed()
        {
            _customerMenu.LocationCreate.Click();

            _locationCreate.Zip = "";

            _locationCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
        }
    }
}