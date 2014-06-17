using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Common;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Location;
using Six.Scs.Tests.Selenium.Extension.WebDriver;

namespace Six.Scs.Tests.Selenium.Tests.Location.Edit
{
    [TestClass]
    public class LocationEditWithoutUserInputTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Location/Edit?LOCATIONID=071b90c2-c8c5-42c5-87c5-d816b26b0a1a");

            LocationEdit.CompanyName = "";
            LocationEdit.StreetNo = "";
            LocationEdit.Zip = "";
            LocationEdit.City = "";
            LocationEdit.Po = "";
            LocationEdit.AdressAddition = "";
            LocationEdit.Region = "";
            LocationEdit.SapNumber = "";

            LocationEdit.Email = "";
            LocationEdit.Telephone = "";
            LocationEdit.Mobile = "";
            LocationEdit.Fax = "";
            LocationEdit.Web = "";

            LocationEdit.SaveButton.Click();
        }

        [TestMethod]
        public void CompanyName()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void StreetNo()
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

        [TestMethod]
        public void NumberOfFormAlerts()
        {
            Assert.AreEqual(4, FormAlert.FormAlertList.Count);
        }
    }
}