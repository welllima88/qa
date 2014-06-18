using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common;
using Six.Scs.QA.Selenium.Extension.TestObjects.Customer;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.Tests.Customer.Edit
{
    [TestClass]
    public class EditCustomerWithNoData
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?PageMode=edit&CUSTOMERID=401858");

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