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

            Selenium.Customer.Edit.CustomerName = "SYR Sele Kunde A";
            Selenium.Customer.Edit.CompanyName = "SYR Sele Firma A";
            Selenium.Customer.Edit.StreetNo = "Hardturmstr. 201";
            Selenium.Customer.Edit.Zip = "8021";
            Selenium.Customer.Edit.City = "Zürich";
            Selenium.Customer.Edit.Po = "PFO1";
            Selenium.Customer.Edit.AdressAddition = "Etage 3";
            Selenium.Customer.Edit.Region = "Reg 55";
            Selenium.Customer.Edit.SapNumber = "4440";
            Selenium.Customer.Edit.Agency = "SIX Payment Services (Europe)";
            Selenium.Customer.Edit.Language = "Deutsch [de]";
            Selenium.Customer.Edit.Country = "Schweiz [CH]";
            Selenium.Customer.Edit.Email = "marc.siegmund@six-group.com";
            Selenium.Customer.Edit.Telephone = "0031 58 399 6237";
            Selenium.Customer.Edit.Mobile = "0032 58 399 6237";
            Selenium.Customer.Edit.Fax = "0033 58 399 6237";
            Selenium.Customer.Edit.Web = "www.six-group.com/de-intern";
        }

        [TestMethod]
        public void EditCustomerWithoutCompanyNameFailed()
        {
            Selenium.Customer.Edit.CompanyName = "";

            Selenium.Customer.Edit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void EditCustomerWithoutStreetAndNumberFailed()
        {
            Selenium.Customer.Edit.StreetNo = "";

            Selenium.Customer.Edit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
            Selenium.Customer.Edit.CancelButton.Click();
        }

        [TestMethod]
        public void EditCustomerWithoutCityFailed()
        {
            Selenium.Customer.Edit.City = "";

            Selenium.Customer.Edit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
            Selenium.Customer.Edit.CancelButton.Click();
        }

        [TestMethod]
        public void EditCustomerWithoutZipFailed()
        {
            Selenium.Customer.Edit.Zip = "";

            Selenium.Customer.Edit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
            Selenium.Customer.Edit.CancelButton.Click();
        }
    }
}