using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Location;
using Six.Scs.QA.Selenium.ObsoleteTests.Menu;
using Six.Scs.QA.TestData.Factory;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Location
{
    [TestClass]
    public class BillingAddressCreateTest
    {
        private string _dt;

        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?CustomerId=404871");
            _dt = Factory.GenerateTestId();
        }

        [TestMethod]
        public void CreateBillingAddressWithInvalidDataFailed()
        {
            CustomerMenu.LocationCreate.Click();

            BillingAddressCreate.CompanyName = "SYR Sele Firma A$°";
            BillingAddressCreate.StreetName = "Hardturmstr. 201$°";
            BillingAddressCreate.Zip = "802$°";
            BillingAddressCreate.City = "Zürich$°";
            BillingAddressCreate.Po = "PFO1$°";
            BillingAddressCreate.AdressAddition = "Etage 3$°";
            BillingAddressCreate.Region = "Reg 3[]$°";

            BillingAddressCreate.Language = "Deutsch [de]";
            BillingAddressCreate.Country = "Schweiz [CH]";
            BillingAddressCreate.Email = "marc.siegmund@six-grou$°p.com";
            BillingAddressCreate.Telephone = "0031 58 399 6237$";
            BillingAddressCreate.Mobile = "0032 58 399 6237$";
            BillingAddressCreate.Fax = "0033 58 399 6237$";
            BillingAddressCreate.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            BillingAddressCreate.SaveButton.Click();

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
            Assert.AreEqual(12, FormAlert.FormAlertList.Count);
        }

        [TestMethod]
        public void CreateBillingAddressWithIncompleteDataFailed()
        {
            CustomerMenu.BillingAdressCreate.Click();

            BillingAddressCreate.SaveButton.Click();

            Assert.AreEqual(5, FormAlert.FormAlertElements.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Land: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateBillingAddressrWithoutCompanyNameFailed()
        {
            CustomerMenu.LocationCreate.Click();

            BillingAddressCreate.CompanyName = "";
            BillingAddressCreate.StreetName = "Hardturmstr. 201";
            BillingAddressCreate.Zip = "8021";
            BillingAddressCreate.City = "Zürich";
            BillingAddressCreate.Po = "PFO1";
            BillingAddressCreate.AdressAddition = "Etage 3";
            BillingAddressCreate.Region = "Reg 55";
            BillingAddressCreate.Language = "Deutsch [de]";
            BillingAddressCreate.Country = "Schweiz [CH]";
            BillingAddressCreate.Email = "marc.siegmund@six-group.com";
            BillingAddressCreate.Telephone = "0031 58 399 6237";
            BillingAddressCreate.Mobile = "0032 58 399 6237";
            BillingAddressCreate.Fax = "0033 58 399 6237";
            BillingAddressCreate.Web = "www.six-group.com/de-intern";

            BillingAddressCreate.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateBillingAddressWithoutStreetAndNumberFailed()
        {
            CustomerMenu.LocationCreate.Click();

            BillingAddressCreate.CompanyName = "SYR Sele Firma A";
            BillingAddressCreate.StreetName = "";
            BillingAddressCreate.Zip = "8021";
            BillingAddressCreate.City = "Zürich";
            BillingAddressCreate.Po = "PFO1";
            BillingAddressCreate.AdressAddition = "Etage 3";
            BillingAddressCreate.Region = "Reg 55";
            BillingAddressCreate.Language = "Deutsch [de]";
            BillingAddressCreate.Country = "Schweiz [CH]";
            BillingAddressCreate.Email = "marc.siegmund@six-group.com";
            BillingAddressCreate.Telephone = "0031 58 399 6237";
            BillingAddressCreate.Mobile = "0032 58 399 6237";
            BillingAddressCreate.Fax = "0033 58 399 6237";
            BillingAddressCreate.Web = "www.six-group.com/de-intern";

            BillingAddressCreate.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateBillingAddressWithoutCityFailed()
        {
            CustomerMenu.LocationCreate.Click();

            BillingAddressCreate.CompanyName = "SYR Sele Firma A";
            BillingAddressCreate.StreetName = "Hardturmstr. 201";
            BillingAddressCreate.Zip = "8021";
            BillingAddressCreate.City = "";
            BillingAddressCreate.Po = "PFO1";
            BillingAddressCreate.AdressAddition = "Etage 3";
            BillingAddressCreate.Region = "Reg 55";
            BillingAddressCreate.Language = "Deutsch [de]";
            BillingAddressCreate.Country = "Schweiz [CH]";
            BillingAddressCreate.Email = "marc.siegmund@six-group.com";
            BillingAddressCreate.Telephone = "0031 58 399 6237";
            BillingAddressCreate.Mobile = "0032 58 399 6237";
            BillingAddressCreate.Fax = "0033 58 399 6237";
            BillingAddressCreate.Web = "www.six-group.com/de-intern";

            BillingAddressCreate.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateBillingAddressWithoutZipFailed()
        {
            CustomerMenu.LocationCreate.Click();

            BillingAddressCreate.CompanyName = "SYR Sele Firma A";
            BillingAddressCreate.StreetName = "Hardturmstr. 201";
            BillingAddressCreate.Zip = "";
            BillingAddressCreate.City = "Zürich";
            BillingAddressCreate.Po = "PFO1";
            BillingAddressCreate.AdressAddition = "Etage 3";
            BillingAddressCreate.Region = "Reg 55";
            BillingAddressCreate.Language = "Deutsch [de]";
            BillingAddressCreate.Country = "Schweiz [CH]";
            BillingAddressCreate.Email = "marc.siegmund@six-group.com";
            BillingAddressCreate.Telephone = "0031 58 399 6237";
            BillingAddressCreate.Mobile = "0032 58 399 6237";
            BillingAddressCreate.Fax = "0033 58 399 6237";
            BillingAddressCreate.Web = "www.six-group.com/de-intern";

            BillingAddressCreate.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateBillingAddressAndSave()
        {
            MenusTest.CustomerMenuCheck();
            CustomerMenu.BillingAdressCreate.Click();

            BillingAddressCreate.CompanyName = "SYR ReAd SELE A";
            BillingAddressCreate.StreetName = "Rechnungsallee 112";
            BillingAddressCreate.Zip = "10010";
            BillingAddressCreate.City = "Stuttgart";
            BillingAddressCreate.Po = "PO1";

            BillingAddressCreate.Language = "Swedish [sv]";
            BillingAddressCreate.Country = "Schweden [SE]";
            BillingAddressCreate.Email = "marc.siegmund@six-group.com";
            BillingAddressCreate.Telephone = "0031 58 399 6237";
            BillingAddressCreate.Mobile = "0032 58 399 6237";
            BillingAddressCreate.Fax = "0033 58 399 6237";
            BillingAddressCreate.Web = "www.six-group.com/de" + _dt;

            BillingAddressCreate.SaveButton.Click();

            MenusTest.CustomerMenuCheck();

            Assert.AreEqual("SYR ReAd SELE A", BillingAddressView.CompanyName);
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            //Assert.AreEqual(locId, BillingAddressView.Guid);
            Assert.AreEqual("SYR ReAd SELE A", BillingAddressView.CompanyName);

            Assert.AreEqual("Rechnungsallee 112", BillingAddressView.StreetName);
            Assert.AreEqual("SYR ReAd SELE A", BillingAddressView.CompanyName);
            Assert.AreEqual("10010", BillingAddressView.Zip);
            Assert.AreEqual("Stuttgart", BillingAddressView.City);
            Assert.AreEqual("Swedish [sv]", BillingAddressView.Language);
            Assert.AreEqual("Sweden [SE]", BillingAddressView.Country);
            Assert.AreEqual("marc.siegmund@six-group.com", BillingAddressView.Email);
            Assert.AreEqual("0031 58 399 6237", BillingAddressView.Telephone);
            Assert.AreEqual("0032 58 399 6237", BillingAddressView.Mobile);
            Assert.AreEqual("0033 58 399 6237", BillingAddressView.Fax);
            Assert.AreEqual("www.six-group.com/de" + _dt, BillingAddressView.Web);
        }

        [TestMethod]
        public void CreateBillingAddressWithMinimalAndSave()
        {
            CustomerMenu.BillingAdressCreate.Click();

            BillingAddressCreate.CompanyName = "SYR ReAd SELE A";
            BillingAddressCreate.StreetName = "Rechnungsallee 112";
            BillingAddressCreate.Zip = "10010";
            BillingAddressCreate.City = "Stuttgart";
            BillingAddressCreate.Po = "PO1";

            BillingAddressCreate.Language = "Swedish [sv]";
            BillingAddressCreate.Country = "Schweden [SE]";
            BillingAddressCreate.Email = "marc.siegmund@six-group.com";
            BillingAddressCreate.Telephone = "0031 58 399 6237";
            BillingAddressCreate.Mobile = "0032 58 399 6237";
            BillingAddressCreate.Fax = "0033 58 399 6237";
            BillingAddressCreate.Web = "www.six-group.com/de" + _dt;

            BillingAddressCreate.SaveButton.Click();

            //var locId = _driver.PageSource.;
            Assert.AreEqual("SYR ReAd SELE A", BillingAddressView.CompanyName);
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            //Assert.AreEqual(locId, BillingAddressView.Guid);
            Assert.AreEqual("SYR ReAd SELE A", BillingAddressView.CompanyName);

            Assert.AreEqual("Rechnungsallee 112", BillingAddressView.StreetName);
            Assert.AreEqual("SYR ReAd SELE A", BillingAddressView.CompanyName);
            Assert.AreEqual("10010", BillingAddressView.Zip);
            Assert.AreEqual("Stuttgart", BillingAddressView.City);
            Assert.AreEqual("Swedish [sv]", BillingAddressView.Language);
            Assert.AreEqual("Sweden [SE]", BillingAddressView.Country);
            Assert.AreEqual("marc.siegmund@six-group.com", BillingAddressView.Email);
            Assert.AreEqual("0031 58 399 6237", BillingAddressView.Telephone);
            Assert.AreEqual("0032 58 399 6237", BillingAddressView.Mobile);
            Assert.AreEqual("0033 58 399 6237", BillingAddressView.Fax);
            Assert.AreEqual("www.six-group.com/de" + _dt, BillingAddressView.Web);
        }
    }
}