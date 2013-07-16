using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        private static FormAlert _formAlert;
        private static CustomerMenu _customerMenu;

        private static List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _contactCreate = new ContactCreate();
            new ContactView();
            new ContactMenu();
            new RecentElements();
            new NavigationBar();
            _formAlert = new FormAlert();
            new MenusTest();
            new LobbyView();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=401152");

            _customerMenu.ContactCreate.Click();

            _contactCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
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