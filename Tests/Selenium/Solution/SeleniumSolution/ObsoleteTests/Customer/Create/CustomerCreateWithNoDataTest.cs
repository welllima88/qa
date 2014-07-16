﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Create
{
    [TestClass]
    public class CustomerCreateWithNoDataTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate();

            CustomerMenu.CustomerCreate.Click();
            CustomerCreate.SaveButton.Click();
        }

        [TestMethod]
        public void CustomerNumberOfFormAlerts()
        {
            Assert.AreEqual(7, FormAlert.FormAlertList.Count);
        }

        [TestMethod]
        public void CustomerNameMissingFormAlert()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Kundenname: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CompanyNameMissingFormAlert()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void SupplierMissingFormAlert()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Mandant: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void StreetNumberMissingFormAlert()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void ZipMissingFormAlert()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CityMissingFormAlert()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CountryMissingFormAlert()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Land: Dies ist ein Pflichtfeld!");
        }
    }
}