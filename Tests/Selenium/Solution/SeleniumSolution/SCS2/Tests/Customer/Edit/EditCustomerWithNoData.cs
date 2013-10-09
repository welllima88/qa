using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Edit
{
    [TestClass]
    public class EditCustomerWithNoData
    {
        private static CustomerEdit _customerEdit;
        private static FormAlert _formAlert;
        private static CustomerMenu _customerMenu;

        private static List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _customerEdit = new CustomerEdit();
            _formAlert = new FormAlert();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=405125");
            _customerMenu.CustomerEdit.Click();

            _customerEdit.CustomerName = "";
            _customerEdit.CompanyName = "";
            _customerEdit.StreetNo = "";
            _customerEdit.Zip = "";
            _customerEdit.City = "";
            _customerEdit.Po = "";
            _customerEdit.AdressAddition = "";
            _customerEdit.Region = "";
            _customerEdit.SapNumber = "";

            _customerEdit.Email = "";
            _customerEdit.Telephone = "";
            _customerEdit.Mobile = "";
            _customerEdit.Fax = "";
            _customerEdit.Web = "";

            _customerEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
        }

        [TestMethod]
        public void NumberOfFormAlerts()
        {
            Assert.AreEqual(5, _formAlerts.Count);
        }

        [TestMethod]
        public void CustomerNameError()
        {
            CollectionAssert.Contains(_formAlerts, "Kundenname: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CompanyNameError()
        {
            CollectionAssert.Contains(_formAlerts, "Firmenname: Dies ist ein Pflichtfeld! Zu kurze Eingabe!");
        }

        [TestMethod]
        public void StreetAndNumberError()
        {
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void Zip()
        {
            CollectionAssert.Contains(_formAlerts, "PLZ: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void City()
        {
            CollectionAssert.Contains(_formAlerts, "Ort: Dies ist ein Pflichtfeld!");
        }
    }
}