﻿using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Location.Edit
{
    [TestFixture]
    public class LocationEditWithInvalidDataTest
    {
        [SetUp]
        public void TestInit()
        {
            TestDirector.Navigate("Location/Edit?LOCATIONID=071b90c2-c8c5-42c5-87c5-d816b26b0a1a");
            LocationMenu.LocationEdit.Click();

            Selenium.Location.Edit.CompanyName = "SYR Sele Firma A$°";
            Selenium.Location.Edit.StreetNo = "Hardturmstr. 201$°";
            Selenium.Location.Edit.Zip = "802$°";
            Selenium.Location.Edit.City = "Zürich$°";
            Selenium.Location.Edit.Po = "PFO1$°";
            Selenium.Location.Edit.AdressAddition = "Etage 3$°";
            Selenium.Location.Edit.Region = "Reg 3[]$°";
            Selenium.Location.Edit.SapNumber = "444$°";

            Selenium.Location.Edit.Language = "Deutsch [de]";
            Selenium.Location.Edit.Country = "Schweiz [CH]";
            Selenium.Location.Edit.Email = "marc.siegmund@six-grou$°p.com()";
            Selenium.Location.Edit.Telephone = "0031 58 399 6237$";
            Selenium.Location.Edit.Mobile = "0032 58 399 6237$";
            Selenium.Location.Edit.Fax = "0033 58 399 6237$";
            Selenium.Location.Edit.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            Selenium.Location.Edit.SaveButton.Click();
        }

        [Test]
        public void CompanyName()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Ungültige Zeichen gefunden!");
        }

        [Test]
        public void AdressAddition()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Zusatz: Ungültige Zeichen gefunden!");
        }

        [Test]
        public void Telephone()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Telefon: Ungültige Zeichen gefunden!");
        }

        [Test]
        public void Mobile()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Mobiltelefon: Ungültige Zeichen gefunden!");
        }

        [Test]
        public void EditLocationWithInvalidDataFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Fax: Ungültige Zeichen gefunden!");
        }

        [Test]
        public void StreetNo()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Ungültige Zeichen gefunden!");
        }

        [Test]
        public void Zip()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Ungültige Zeichen gefunden!");
        }

        [Test]
        public void Po()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Postfach: Ungültige Zeichen gefunden!");
        }

        [Test]
        public void City()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Ungültige Zeichen gefunden!");
        }

        [Test]
        public void Region()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Region (Kurzzeichen): Ungültige Zeichen gefunden!");
        }

        [Test]
        public void Email()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Email: Dies ist keine gültige E-Mail Adresse!");
        }

        [Test]
        public void Web()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Web: Dies ist keine gültige Web Adresse!");
        }

        [Test]
        public void NumberOfAlerts()
        {
            Assert.AreEqual(12, FormAlert.FormAlertList.Count, "Wrong number of form alerts");
        }
    }
}