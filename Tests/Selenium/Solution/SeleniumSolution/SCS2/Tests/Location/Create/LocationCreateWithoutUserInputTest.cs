using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Location.Create
{
    [TestClass]
    public class LocationCreateWithoutUserInputTest
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