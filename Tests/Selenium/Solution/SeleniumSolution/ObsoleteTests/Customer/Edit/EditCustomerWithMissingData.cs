using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Edit
{
    [TestClass]
    public class EditCustomerWithMissingData
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?PageMode=edit&CUSTOMERID=401858");

            CustomerEdit.CustomerName = "SYR Sele Kunde A";
            CustomerEdit.CompanyName = "SYR Sele Firma A";
            CustomerEdit.StreetNo = "Hardturmstr. 201";
            CustomerEdit.Zip = "8021";
            CustomerEdit.City = "Zürich";
            CustomerEdit.Po = "PFO1";
            CustomerEdit.AdressAddition = "Etage 3";
            CustomerEdit.Region = "Reg 55";
            CustomerEdit.SapNumber = "4440";
            CustomerEdit.Agency = "SIX Payment Services (Europe)";
            CustomerEdit.Language = "Deutsch [de]";
            CustomerEdit.Country = "Schweiz [CH]";
            CustomerEdit.Email = "marc.siegmund@six-group.com";
            CustomerEdit.Telephone = "0031 58 399 6237";
            CustomerEdit.Mobile = "0032 58 399 6237";
            CustomerEdit.Fax = "0033 58 399 6237";
            CustomerEdit.Web = "www.six-group.com/de-intern";
        }

        [TestMethod]
        public void EditCustomerWithoutCompanyNameFailed()
        {
            CustomerEdit.CompanyName = "";

            CustomerEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void EditCustomerWithoutStreetAndNumberFailed()
        {
            CustomerEdit.StreetNo = "";

            CustomerEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
            CustomerEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditCustomerWithoutCityFailed()
        {
            CustomerEdit.City = "";

            CustomerEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
            CustomerEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditCustomerWithoutZipFailed()
        {
            CustomerEdit.Zip = "";

            CustomerEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
            CustomerEdit.CancelButton.Click();
        }
    }
}