using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.Tests.Selenium.Extension.Selenium;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Location;

namespace SIX.SCS.Tests.Selenium.Tests.Location.Create
{
    [TestClass]
    public class LocationCreateWithMissingDataTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Location/New?CUSTOMERID=401858");

            LocationCreate.CompanyName = "SYR Sele Firma A";
            LocationCreate.StreetNo = "Hardturmstr. 201";
            LocationCreate.Zip = "8021";
            LocationCreate.City = "Zürich";
            LocationCreate.Po = "PFO1";
            LocationCreate.AdressAddition = "Etage 3";
            LocationCreate.Region = "Reg 55";
            LocationCreate.SapNumber = "4440";

            LocationCreate.Language = "Deutsch [de]";
            LocationCreate.Country = "Schweiz [CH]";
            LocationCreate.Email = "marc.siegmund@six-group.com";
            LocationCreate.Telephone = "0031 58 399 6237";
            LocationCreate.Mobile = "0032 58 399 6237";
            LocationCreate.Fax = "0033 58 399 6237";
            LocationCreate.Web = "www.six-group.com/de-intern";
        }

        [TestMethod]
        public void CreateLocationrWithoutCompanyNameFailed()
        {
            CustomerMenu.LocationCreate.Click();

            LocationCreate.CompanyName = "";

            LocationCreate.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateLocationWithoutStreetAndNumberFailed()
        {
            CustomerMenu.LocationCreate.Click();

            LocationCreate.StreetNo = "";

            LocationCreate.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateLocationWithoutCityFailed()
        {
            CustomerMenu.LocationCreate.Click();

            LocationCreate.City = "";

            LocationCreate.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateLocationWithoutZipFailed()
        {
            CustomerMenu.LocationCreate.Click();

            LocationCreate.Zip = "";

            LocationCreate.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }
    }
}