using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Contact;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Contact.Create
{
    [TestClass]
    public class ContactCreateWithNoDataTest
    {
        private static ContactCreate _contactCreate;
        private static IWebDriverAdapter _driver;
        private static TestDirector _tb;
        private static FormAlert _formAlert;
        private static CustomerMenu _customerMenu;

        private static List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login and 10 seconds response timeout

            _customerMenu = new CustomerMenu(_driver);
            _contactCreate = new ContactCreate(_driver);
            new ContactView(_driver);
            new ContactMenu(_driver);
            new RecentElements(_driver);
            new NavigationBar(_driver);
            _formAlert = new FormAlert(_driver);
            new MenusTest();
            new LobbyView(_driver);

            _driver.Url = _tb.BaseUrl + "/Pages/Customer/CustomerEdit.aspx?CustomerId=401152";

            _customerMenu.ContactCreate.Click();

            _contactCreate.SaveButton.Click();

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
        public void FirstNameMissing()
        {
            Assert.IsTrue(_formAlerts.Contains("Vorname: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void SurnameMissing()
        {
            Assert.IsTrue(_formAlerts.Contains("Nachname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void StreetMissing()
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

        [TestMethod]
        public void NumberOfFormAlerts()
        {
            Assert.IsTrue(_formAlerts.Count == 5);
        }
    }
}