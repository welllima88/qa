using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Edit
{
    [TestClass]
    public class LocationEditWithoutUserInputTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Location?LocationId=4b77d4f2-d5db-4823-9d52-63c1534de457");
            LocationMenu.LocationEdit.Click();

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