using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Create
{
    [TestClass]
    public class LocationCreateWithoutUserInputTest
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

            _locationCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
        }

        [TestMethod]
        public void NumberOfAlerts()
        {
            Assert.AreEqual(4, _formAlerts.Count);
        }

        [TestMethod]
        public void CompanyMissing()
        {
            CollectionAssert.Contains(_formAlerts, "Firmenname: Dies ist ein Pflichtfeld! Zu kurze Eingabe!");
        }

        [TestMethod]
        public void StreetAndNumberMissing()
        {
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void ZipMissing()
        {
            CollectionAssert.Contains(_formAlerts, "PLZ: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CityMissing()
        {
            CollectionAssert.Contains(_formAlerts, "Ort: Dies ist ein Pflichtfeld!");
        }
    }
}