using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Edit
{
    [TestFixture]
    public class NoData
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?PageMode=edit&CUSTOMERID=401858");

            Selenium.Customer.Edit.CustomerName = "";
            Selenium.Customer.Edit.CompanyName = "";
            Selenium.Customer.Edit.StreetNo = "";
            Selenium.Customer.Edit.Zip = "";
            Selenium.Customer.Edit.City = "";
            Selenium.Customer.Edit.Po = "";
            Selenium.Customer.Edit.AdressAddition = "";
            Selenium.Customer.Edit.Region = "";
            Selenium.Customer.Edit.SapNumber = "";

            Selenium.Customer.Edit.Email = "";
            Selenium.Customer.Edit.Telephone = "";
            Selenium.Customer.Edit.Mobile = "";
            Selenium.Customer.Edit.Fax = "";
            Selenium.Customer.Edit.Web = "";

            Selenium.Customer.Edit.SaveButton.Click();
        }

        [Test]
        public void NumberOfFormAlerts()
        {
            Assert.AreEqual(5, FormAlert.FormAlertList.Count);
        }

        [Test]
        public void CustomerNameError()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Kundenname: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void CompanyNameError()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Dies ist ein Pflichtfeld! Zu kurze Eingabe!");
        }

        [Test]
        public void StreetAndNumberError()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void Zip()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void City()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }
    }
}