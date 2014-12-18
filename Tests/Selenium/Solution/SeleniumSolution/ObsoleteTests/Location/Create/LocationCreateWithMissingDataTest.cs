using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Location.Create
{
    [TestFixture]
    public class LocationCreateWithMissingDataTest
    {
        [SetUp]
        public void TestInit()
        {
            TestDirector.Navigate("Location/New?CUSTOMERID=401858");

            Selenium.Location.Create.CompanyName = "SYR Sele Firma A";
            Selenium.Location.Create.StreetNo = "Hardturmstr. 201";
            Selenium.Location.Create.Zip = "8021";
            Selenium.Location.Create.City = "Zürich";
            Selenium.Location.Create.Po = "PFO1";
            Selenium.Location.Create.AdressAddition = "Etage 3";
            Selenium.Location.Create.Region = "Reg 55";
            Selenium.Location.Create.SapNumber = "4440";

            Selenium.Location.Create.Language = "Deutsch [de]";
            Selenium.Location.Create.Country = "Schweiz [CH]";
            Selenium.Location.Create.Email = "marc.siegmund@six-group.com";
            Selenium.Location.Create.Telephone = "0031 58 399 6237";
            Selenium.Location.Create.Mobile = "0032 58 399 6237";
            Selenium.Location.Create.Fax = "0033 58 399 6237";
            Selenium.Location.Create.Web = "www.six-group.com/de-intern";
        }

        [Test]
        public void CreateLocationrWithoutCompanyNameFailed()
        {
            CustomerMenu.LocationCreate.Click();

            Selenium.Location.Create.CompanyName = "";

            Selenium.Location.Create.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void CreateLocationWithoutStreetAndNumberFailed()
        {
            CustomerMenu.LocationCreate.Click();

            Selenium.Location.Create.StreetNo = "";

            Selenium.Location.Create.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void CreateLocationWithoutCityFailed()
        {
            CustomerMenu.LocationCreate.Click();

            Selenium.Location.Create.City = "";

            Selenium.Location.Create.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }

        [Test]
        public void CreateLocationWithoutZipFailed()
        {
            CustomerMenu.LocationCreate.Click();

            Selenium.Location.Create.Zip = "";

            Selenium.Location.Create.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }
    }
}