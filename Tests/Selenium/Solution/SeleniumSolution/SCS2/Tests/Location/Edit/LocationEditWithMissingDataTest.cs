using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Edit
{
    [TestClass]
    public class LocationEditWithMissingDataTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Location/Edit?LOCATIONID=071b90c2-c8c5-42c5-87c5-d816b26b0a1a");

            LocationEdit.StreetNo = "Hardturmstr. 201";
            LocationEdit.Zip = "8021";
            LocationEdit.City = "Zürich";
            LocationEdit.Po = "PFO1";
            LocationEdit.AdressAddition = "Etage 3";
            LocationEdit.SapNumber = "4440";

            LocationEdit.Language = "Deutsch [de]";
            LocationEdit.Country = "Schweiz [CH]";
            LocationEdit.Email = "marc.siegmund@six-group.com";
            LocationEdit.Telephone = "0031 58 399 6237";
            LocationEdit.Mobile = "0032 58 399 6237";
            LocationEdit.Fax = "0033 58 399 6237";
            LocationEdit.Web = "www.six-group.com/de-intern";

            LocationEdit.CompanyName = "SYR Sele Firma A";
        }

        [TestMethod]
        public void EditLocationWithoutCompanyNameFailed()
        {
            LocationEdit.CompanyName = "";
            LocationEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count, "Wrong number of form alerts");
            Assert.IsTrue(FormAlert.FormAlertList.Contains("Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!"),
                          "Wrong text in form alerts");
            LocationEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditLocationWithoutStreetAndNumberFailed()
        {
            LocationEdit.StreetNo = "";

            LocationEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void EditLocationWithoutCityFailed()
        {
            LocationEdit.City = "";

            LocationEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void EditLocationWithoutZipFailed()
        {
            LocationEdit.Zip = "";

            LocationEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }
    }
}