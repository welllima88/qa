using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Location;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Location.Edit
{
    [TestClass]
    public class LocationEditWithMissingDataTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Location/Edit?LOCATIONID=071b90c2-c8c5-42c5-87c5-d816b26b0a1a");

            Selenium.Location.Edit.StreetNo = "Hardturmstr. 201";
            Selenium.Location.Edit.Zip = "8021";
            Selenium.Location.Edit.City = "Zürich";
            Selenium.Location.Edit.Po = "PFO1";
            Selenium.Location.Edit.AdressAddition = "Etage 3";
            Selenium.Location.Edit.SapNumber = "4440";

            Selenium.Location.Edit.Language = "Deutsch [de]";
            Selenium.Location.Edit.Country = "Schweiz [CH]";
            Selenium.Location.Edit.Email = "marc.siegmund@six-group.com";
            Selenium.Location.Edit.Telephone = "0031 58 399 6237";
            Selenium.Location.Edit.Mobile = "0032 58 399 6237";
            Selenium.Location.Edit.Fax = "0033 58 399 6237";
            Selenium.Location.Edit.Web = "www.six-group.com/de-intern";

            Selenium.Location.Edit.CompanyName = "SYR Sele Firma A";
        }

        [TestMethod]
        public void EditLocationWithoutCompanyNameFailed()
        {
            Selenium.Location.Edit.CompanyName = "";
            Selenium.Location.Edit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count, "Wrong number of form alerts");
            Assert.IsTrue(FormAlert.FormAlertList.Contains("Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!"),
                "Wrong text in form alerts");
            Selenium.Location.Edit.CancelButton.Click();
        }

        [TestMethod]
        public void EditLocationWithoutStreetAndNumberFailed()
        {
            Selenium.Location.Edit.StreetNo = "";

            Selenium.Location.Edit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void EditLocationWithoutCityFailed()
        {
            Selenium.Location.Edit.City = "";

            Selenium.Location.Edit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void EditLocationWithoutZipFailed()
        {
            Selenium.Location.Edit.Zip = "";

            Selenium.Location.Edit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }
    }
}