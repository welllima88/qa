﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Edit
{
    [TestClass]
    public class EditCustomerWithNoData
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=405125");
            CustomerMenu.CustomerEdit.Click();

            CustomerEdit.CustomerName = "";
            CustomerEdit.CompanyName = "";
            CustomerEdit.StreetNo = "";
            CustomerEdit.Zip = "";
            CustomerEdit.City = "";
            CustomerEdit.Po = "";
            CustomerEdit.AdressAddition = "";
            CustomerEdit.Region = "";
            CustomerEdit.SapNumber = "";

            CustomerEdit.Email = "";
            CustomerEdit.Telephone = "";
            CustomerEdit.Mobile = "";
            CustomerEdit.Fax = "";
            CustomerEdit.Web = "";

            CustomerEdit.SaveButton.Click();
        }

        [TestMethod]
        public void NumberOfFormAlerts()
        {
            Assert.AreEqual(5, FormAlert.FormAlertList.Count);
        }

        [TestMethod]
        public void CustomerNameError()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Kundenname: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CompanyNameError()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Dies ist ein Pflichtfeld! Zu kurze Eingabe!");
        }

        [TestMethod]
        public void StreetAndNumberError()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void Zip()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void City()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }
    }
}