﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Location.Create
{
    [TestClass]
    public class LocationCreateWithInvalidDataTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Location/New?CUSTOMERID=401858");

            Selenium.Location.Create.CompanyName = "SYR Sele Firma A$°";
            Selenium.Location.Create.StreetNo = "Hardturmstr. 201$°";
            Selenium.Location.Create.Zip = "802$°";
            Selenium.Location.Create.City = "Zürich$°";
            Selenium.Location.Create.Po = "PFO1$°";
            Selenium.Location.Create.AdressAddition = "Etage 3$°";
            Selenium.Location.Create.Region = "Reg 3[]$°";
            Selenium.Location.Create.SapNumber = "444$°";

            Selenium.Location.Create.Language = "Deutsch [de]";
            Selenium.Location.Create.Country = "Schweiz [CH]";
            Selenium.Location.Create.Email = "marc.siegmund@six-grou$°p.com";
            Selenium.Location.Create.Telephone = "0031 58 399 6237$";
            Selenium.Location.Create.Mobile = "0032 58 399 6237$";
            Selenium.Location.Create.Fax = "0033 58 399 6237$";
            Selenium.Location.Create.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            Selenium.Location.Create.SaveButton.Click();
        }

        [TestMethod]
        public void CompanyNameInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void AdressAdditionInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Zusatz: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void TelephoneInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Telefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void MobileNumberInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Mobiltelefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void FaxInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Fax: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void StreetNumberInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void ZipInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void PoInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Postfach: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void CityInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void RegionInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Region (Kurzzeichen): Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void EmailInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Email: Dies ist keine gültige E-Mail Adresse!");
        }

        [TestMethod]
        public void WebInvalid()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Web: Dies ist keine gültige Web Adresse!");
        }

        [TestMethod]
        public void NumberOfFormAlerts()
        {
            Assert.AreEqual(12, FormAlert.FormAlertList.Count);
        }
    }
}