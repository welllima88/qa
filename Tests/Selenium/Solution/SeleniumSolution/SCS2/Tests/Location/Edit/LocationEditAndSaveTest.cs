﻿using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Menu;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Edit
{
    [TestClass]
    public class LocationEditAndSaveTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate("/Location?LocationId=4b77d4f2-d5db-4823-9d52-63c1534de457");
        }

        [TestMethod]
        public void EditLocationAndCancel()
        {
            string guid = LocationView.Guid;

            string sapNumber = LocationView.SapNumber;
            string sbsDebitNumber = LocationView.SbsDebitNumber;
            string sbsAdressNumber = LocationView.SbsAdressNumber;

            string ep2MerchantId = LocationView.Ep2MerchantId;

            string companyName = LocationView.CompanyName;
            string po = LocationView.Po;
            string adressAddition = LocationView.AdressAddition;
            string streetName = LocationView.StreetNo;
            string zip = LocationView.Zip;
            string city = LocationView.City;
            string language = LocationView.Language;
            string country = LocationView.Country;
            string email = LocationView.Email;
            string telephone = LocationView.Telephone;
            string mobile = LocationView.Mobile;
            string fax = LocationView.Fax;
            string web = LocationView.Web;

            LocationMenu.LocationEdit.Click();

            LocationEdit.CompanyName = "SYR Sele Firma AAA";
            LocationEdit.StreetNo = "Hardturmstr. 2011";
            LocationEdit.Zip = "80222";
            LocationEdit.City = "Zürichhh";
            LocationEdit.Po = "PFO111";
            LocationEdit.AdressAddition = "Etage 333";
            LocationEdit.Region = "Reggg";
            LocationEdit.SapNumber = "4449";

            LocationEdit.Language = "Kroatisch [hr]";
            LocationEdit.Country = "Albanien [AL]";
            LocationEdit.Email = "marc.siegmund@six-group.com";
            LocationEdit.Telephone = "0031 58 399 623777";
            LocationEdit.Mobile = "0032 58 399 623777";
            LocationEdit.Fax = "0033 58 399 623777";
            LocationEdit.Web = "www.six-group.com/de-internnnn";

            LocationEdit.CancelButton.Click();

            Assert.AreEqual(guid, LocationView.Guid);
            Assert.AreEqual(sapNumber, LocationView.SapNumber);

            StringAssert.Matches(LocationView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(LocationView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(LocationView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual(sbsDebitNumber, LocationView.SbsDebitNumber);
            Assert.AreEqual(sbsAdressNumber, LocationView.SbsAdressNumber);
            Assert.AreEqual(ep2MerchantId, LocationView.Ep2MerchantId);
            Assert.AreEqual(companyName, LocationView.CompanyName);
            Assert.AreEqual(po, LocationView.Po);
            Assert.AreEqual(adressAddition, LocationView.AdressAddition);
            Assert.AreEqual(streetName, LocationView.StreetNo);
            Assert.AreEqual(zip, LocationView.Zip);
            Assert.AreEqual(city, LocationView.City);
            Assert.AreEqual(language, LocationView.Language);
            Assert.AreEqual(country, LocationView.Country);
            Assert.AreEqual(email, LocationView.Email);
            Assert.AreEqual(telephone, LocationView.Telephone);
            Assert.AreEqual(mobile, LocationView.Mobile);
            Assert.AreEqual(fax, LocationView.Fax);
            Assert.AreEqual(web, LocationView.Web);
        }

        [TestMethod]
        public void EditLocationWithInvalidDataFailed()
        {
            LocationMenu.LocationEdit.Click();

            LocationEdit.CompanyName = "SYR Sele Firma A$°";
            LocationEdit.StreetNo = "Hardturmstr. 201$°";
            LocationEdit.Zip = "802$°";
            LocationEdit.City = "Zürich$°";
            LocationEdit.Po = "PFO1$°";
            LocationEdit.AdressAddition = "Etage 3$°";
            LocationEdit.Region = "Reg 3[]$°";
            LocationEdit.SapNumber = "444$°";

            LocationEdit.Language = "Deutsch [de]";
            LocationEdit.Country = "Schweiz [CH]";
            LocationEdit.Email = "marc.siegmund@six-grou$°p.com()";
            LocationEdit.Telephone = "0031 58 399 6237$";
            LocationEdit.Mobile = "0032 58 399 6237$";
            LocationEdit.Fax = "0033 58 399 6237$";
            LocationEdit.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            LocationEdit.SaveButton.Click();

            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Zusatz: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Telefon: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Mobiltelefon: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Fax: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Postfach: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Region (Kurzzeichen): Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Email: Dies ist keine gültige E-Mail Adresse!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Web: Dies ist keine gültige Web Adresse!");
            Assert.AreEqual(12, FormAlert.FormAlertList.Count, "Wrong number of form alerts");
        }

        [TestMethod]
        public void EditLocationWithoutCompanyNameFailed()
        {
            LocationMenu.LocationEdit.Click();

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

            LocationEdit.CompanyName = "";
            LocationEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count, "Wrong number of form alerts");
            Assert.IsTrue(FormAlert.FormAlertList.Contains("Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!"),
                          "Wrong text in form alerts");
            LocationEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditLocationWithIncompleteDataFailed()
        {
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

            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
            Assert.AreEqual(4, FormAlert.FormAlertList.Count);
        }

        [TestMethod]
        public void CheckLocationMenu()
        {
            MenusTest.LocationMenuCheck();
            LocationMenu.LocationEdit.Click();
            LocationEdit.CancelButton.Click();
            MenusTest.LocationMenuCheck();
        }

        [TestMethod]
        public void EditLocationWithoutStreetAndNumberFailed()
        {
            LocationMenu.LocationEdit.Click();

            LocationEdit.CompanyName = "SYR Sele Firma A";
            LocationEdit.StreetNo = "";
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

            LocationEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void EditLocationWithoutCityFailed()
        {
            LocationMenu.LocationEdit.Click();

            LocationEdit.CompanyName = "SYR Sele Firma A";
            LocationEdit.StreetNo = "Hardturmstr. 201";
            LocationEdit.Zip = "8021";
            LocationEdit.City = "";
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

            LocationEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void EditLocationWithoutZipFailed()
        {
            LocationMenu.LocationEdit.Click();

            LocationEdit.CompanyName = "SYR Sele Firma A";
            LocationEdit.StreetNo = "Hardturmstr. 201";
            LocationEdit.Zip = "";
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

            LocationEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void EditLocationAndSave()
        {
            string guid = LocationView.Guid;
            string ep2MerchantId = LocationView.Ep2MerchantId;
            string sbsDebitNumber = LocationView.SbsDebitNumber;
            string sbsAdressNumber = LocationView.SbsAdressNumber;

            LocationMenu.LocationEdit.Click();
            Assert.AreEqual(LocationEdit.Guid, guid);
            Assert.AreEqual(LocationEdit.Ep2MerchantId, ep2MerchantId);
            Assert.AreEqual(LocationEdit.SbsDebitNumber, sbsDebitNumber);
            Assert.AreEqual(LocationEdit.SbsAdressNumber, sbsAdressNumber);

            LocationEdit.CompanyName = "SYR Standort SELE B";
            LocationEdit.StreetNo = "Am Bärenplatz 2";
            LocationEdit.Zip = "8001";
            LocationEdit.City = "Kreuzlingen";
            LocationEdit.Po = "PO2-A";
            LocationEdit.AdressAddition = "Level2";
            LocationEdit.SapNumber = "1331";
            LocationEdit.Email = "marc.siegmund@six-group.com";
            LocationEdit.Telephone = "+41 58 399 6237";
            LocationEdit.Mobile = "+42 58 399 6237";
            LocationEdit.Fax = "+43 58 399 6237";
            LocationEdit.Web = "www.six-group.com";

            LocationEdit.Language = "Englisch [en]";
            LocationEdit.Country = "Schweiz [CH]";

            LocationCreate.SaveButton.Click();

            Assert.AreEqual(LocationView.Guid, guid);
            Assert.AreEqual(LocationView.Ep2MerchantId, ep2MerchantId);
            Assert.AreEqual("SYR Standort SELE B", LocationView.CompanyName);

            NavigationBar.Lobby.Click();
            RecentElements.MostRecent.Click();

            Assert.AreEqual(LocationView.Guid, guid);
            Assert.AreEqual(LocationView.Ep2MerchantId, ep2MerchantId);
            Assert.AreEqual("SYR Standort SELE B", LocationView.CompanyName);

            StringAssert.Matches(LocationView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(LocationView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(LocationView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual("Am Bärenplatz 2", LocationView.StreetNo);
            Assert.AreEqual("1331", LocationView.SapNumber);
            Assert.AreEqual("SYR Standort SELE B", LocationView.CompanyName);
            Assert.AreEqual("8001", LocationView.Zip);
            Assert.AreEqual("PO2-A", LocationView.Po);
            Assert.AreEqual("Level2", LocationView.AdressAddition);
            Assert.AreEqual("Kreuzlingen", LocationView.City);
            Assert.AreEqual("Englisch [en]", LocationView.Language);
            Assert.AreEqual("Schweiz [CH]", LocationView.Country);
            Assert.AreEqual("marc.siegmund@six-group.com", LocationView.Email);
            Assert.AreEqual("+41 58 399 6237", LocationView.Telephone);
            Assert.AreEqual("+42 58 399 6237", LocationView.Mobile);
            Assert.AreEqual("+43 58 399 6237", LocationView.Fax);
            Assert.AreEqual("www.six-group.com", LocationView.Web);
        }

        [TestMethod]
        public void EditLocationWithMinimalAndSave()
        {
            string guid = LocationView.Guid;
            string ep2MerchantId = LocationView.Ep2MerchantId;
            string sbsDebitNumber = LocationView.SbsDebitNumber;
            string sbsAdressNumber = LocationView.SbsAdressNumber;

            LocationMenu.LocationEdit.Click();
            Assert.AreEqual(LocationEdit.Guid, guid);
            Assert.AreEqual(LocationEdit.Ep2MerchantId, ep2MerchantId);
            Assert.AreEqual(LocationEdit.SbsDebitNumber, sbsDebitNumber);
            Assert.AreEqual(LocationEdit.SbsAdressNumber, sbsAdressNumber);

            LocationEdit.CompanyName = "SYR Standort SELE B";
            LocationEdit.StreetNo = "Am Bärenplatz 2";
            LocationEdit.Zip = "8001";
            LocationEdit.City = "Kreuzlingen";
            LocationEdit.Po = "";
            LocationEdit.AdressAddition = "";
            LocationEdit.SapNumber = "";
            LocationEdit.Email = "";
            LocationEdit.Telephone = "";
            LocationEdit.Mobile = "";
            LocationEdit.Fax = "";
            LocationEdit.Web = "";

            LocationEdit.Language = "en";
            LocationEdit.Country = "CH";

            LocationCreate.SaveButton.Click();

            Assert.AreEqual(LocationView.Guid, guid);
            Assert.AreEqual(LocationView.Ep2MerchantId, ep2MerchantId);
            Assert.AreEqual("SYR Standort SELE B", LocationView.CompanyName);

            NavigationBar.Lobby.Click();
            RecentElements.MostRecent.Click();

            Assert.AreEqual(LocationView.Guid, guid);
            Assert.AreEqual(LocationView.Ep2MerchantId, ep2MerchantId);
            Assert.AreEqual("SYR Standort SELE B", LocationView.CompanyName);

            StringAssert.Matches(LocationView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(LocationView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(LocationView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual("Am Bärenplatz 2", LocationView.StreetNo);
            Assert.AreEqual("", LocationView.SapNumber);
            Assert.AreEqual("SYR Standort SELE B", LocationView.CompanyName);
            Assert.AreEqual("8001", LocationView.Zip);
            Assert.AreEqual("", LocationView.Po);
            Assert.AreEqual("", LocationView.AdressAddition);
            Assert.AreEqual("Kreuzlingen", LocationView.City);
            StringAssert.Contains(LocationView.Language, "[en]");
            StringAssert.Contains(LocationView.Country, "[CH]");
            Assert.AreEqual("", LocationView.Email);
            Assert.AreEqual("", LocationView.Telephone);
            Assert.AreEqual("", LocationView.Mobile);
            Assert.AreEqual("", LocationView.Fax);
            Assert.AreEqual("", LocationView.Web);
        }

        [TestMethod]
        public void EditLocationCheckNavBar()
        {
            Assert.AreEqual("Standort", NavigationBar.Current.Text);
            LocationMenu.LocationEdit.Click();
            Assert.AreEqual("Standort", NavigationBar.Current.Text);
        }

        [TestMethod]
        public void EditLocationCheckHeadline()
        {
            StringAssert.Matches(LobbyView.Headline.Text, new Regex(@"\d+: .*"));
            LocationMenu.LocationEdit.Click();
            StringAssert.Matches(LobbyView.Headline.Text, new Regex(@"\d+: .*"));
        }
    }
}