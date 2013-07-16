using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Location.Create
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
            Assert.IsTrue(_formAlerts.Count == 4);
        }

        [TestMethod]
        public void CompanyMissing()
        {
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Dies ist ein Pflichtfeld! Zu kurze Eingabe!"));
        }

        [TestMethod]
        public void StreetAndNumberMissing()
        {
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void ZipMissing()
        {
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CityMissing()
        {
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));
        }
    }
}