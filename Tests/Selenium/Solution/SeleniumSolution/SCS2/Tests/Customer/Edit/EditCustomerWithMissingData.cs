using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common.Menu;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Edit
{
    [TestClass]
    public class EditCustomerWithMissingData
    {
        private static CustomerEdit _customerEdit;
        private static FormAlert _formAlert;
        private static CustomerMenu _customerMenu;

        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _customerEdit = new CustomerEdit();
            _formAlert = new FormAlert();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=405125");
        }

        [TestInitialize]
        public void TestInit()
        {
            _customerMenu.CustomerEdit.Click();

            _customerEdit.CustomerName = "SYR Sele Kunde A";
            _customerEdit.CompanyName = "SYR Sele Firma A";
            _customerEdit.StreetNo = "Hardturmstr. 201";
            _customerEdit.Zip = "8021";
            _customerEdit.City = "Zürich";
            _customerEdit.Po = "PFO1";
            _customerEdit.AdressAddition = "Etage 3";
            _customerEdit.Region = "Reg 55";
            _customerEdit.SapNumber = "4440";
            _customerEdit.Agency = "SIX Payment Services (Europe)";
            _customerEdit.Language = "Deutsch [de]";
            _customerEdit.Country = "Schweiz [CH]";
            _customerEdit.Email = "marc.siegmund@six-group.com";
            _customerEdit.Telephone = "0031 58 399 6237";
            _customerEdit.Mobile = "0032 58 399 6237";
            _customerEdit.Fax = "0033 58 399 6237";
            _customerEdit.Web = "www.six-group.com/de-intern";
        }

        [TestMethod]
        public void EditCustomerWithoutCompanyNameFailed()
        {
            _customerEdit.CompanyName = "";
            _formAlerts = _formAlert.FormAlertList;

            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void EditCustomerWithoutStreetAndNumberFailed()
        {
            _customerMenu.CustomerEdit.Click();

            _customerEdit.StreetNo = "";

            _customerEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Dies ist ein Pflichtfeld!");
            _customerEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditCustomerWithoutCityFailed()
        {
            _customerEdit.City = "";

            _customerEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Ort: Dies ist ein Pflichtfeld!");
            _customerEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditCustomerWithoutZipFailed()
        {
            _customerEdit.Zip = "";

            _customerEdit.SaveButton.Click();
            _formAlerts = _formAlert.FormAlertList;

            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "PLZ: Dies ist ein Pflichtfeld!");
            _customerEdit.CancelButton.Click();
        }
    }
}