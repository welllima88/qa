using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Location.BillingAddress;
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

            Selenium.Location.BillingAddress.Create.CompanyName = "SYR Sele Firma A$°";
            Selenium.Location.BillingAddress.Create.StreetNo = "Hardturmstr. 201$°";
            Selenium.Location.BillingAddress.Create.Zip = "802$°";
            Selenium.Location.BillingAddress.Create.City = "Zürich$°";
            Selenium.Location.BillingAddress.Create.Po = "PFO1$°";
            Selenium.Location.BillingAddress.Create.AdressAddition = "Etage 3$°";
            Selenium.Location.BillingAddress.Create.Region = "Reg 3[]$°";

            Selenium.Location.BillingAddress.Create.Language = "Deutsch [de]";
            Selenium.Location.BillingAddress.Create.Country = "Schweiz [CH]";
            Selenium.Location.BillingAddress.Create.Email = "marc.siegmund@six-grou$°p.com";
            Selenium.Location.BillingAddress.Create.Telephone = "0031 58 399 6237$";
            Selenium.Location.BillingAddress.Create.Mobile = "0032 58 399 6237$";
            Selenium.Location.BillingAddress.Create.Fax = "0033 58 399 6237$";
            Selenium.Location.BillingAddress.Create.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            Selenium.Location.BillingAddress.Create.SaveButton.Click();

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

            Selenium.Location.BillingAddress.Create.SaveButton.Click();

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

            Selenium.Location.BillingAddress.Create.CompanyName = "";
            Selenium.Location.BillingAddress.Create.StreetNo = "Hardturmstr. 201";
            Selenium.Location.BillingAddress.Create.Zip = "8021";
            Selenium.Location.BillingAddress.Create.City = "Zürich";
            Selenium.Location.BillingAddress.Create.Po = "PFO1";
            Selenium.Location.BillingAddress.Create.AdressAddition = "Etage 3";
            Selenium.Location.BillingAddress.Create.Region = "Reg 55";
            Selenium.Location.BillingAddress.Create.Language = "Deutsch [de]";
            Selenium.Location.BillingAddress.Create.Country = "Schweiz [CH]";
            Selenium.Location.BillingAddress.Create.Email = "marc.siegmund@six-group.com";
            Selenium.Location.BillingAddress.Create.Telephone = "0031 58 399 6237";
            Selenium.Location.BillingAddress.Create.Mobile = "0032 58 399 6237";
            Selenium.Location.BillingAddress.Create.Fax = "0033 58 399 6237";
            Selenium.Location.BillingAddress.Create.Web = "www.six-group.com/de-intern";

            Selenium.Location.BillingAddress.Create.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateBillingAddressWithoutStreetAndNumberFailed()
        {
            CustomerMenu.LocationCreate.Click();

            Selenium.Location.BillingAddress.Create.CompanyName = "SYR Sele Firma A";
            Selenium.Location.BillingAddress.Create.StreetNo = "";
            Selenium.Location.BillingAddress.Create.Zip = "8021";
            Selenium.Location.BillingAddress.Create.City = "Zürich";
            Selenium.Location.BillingAddress.Create.Po = "PFO1";
            Selenium.Location.BillingAddress.Create.AdressAddition = "Etage 3";
            Selenium.Location.BillingAddress.Create.Region = "Reg 55";
            Selenium.Location.BillingAddress.Create.Language = "Deutsch [de]";
            Selenium.Location.BillingAddress.Create.Country = "Schweiz [CH]";
            Selenium.Location.BillingAddress.Create.Email = "marc.siegmund@six-group.com";
            Selenium.Location.BillingAddress.Create.Telephone = "0031 58 399 6237";
            Selenium.Location.BillingAddress.Create.Mobile = "0032 58 399 6237";
            Selenium.Location.BillingAddress.Create.Fax = "0033 58 399 6237";
            Selenium.Location.BillingAddress.Create.Web = "www.six-group.com/de-intern";

            Selenium.Location.BillingAddress.Create.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateBillingAddressWithoutCityFailed()
        {
            CustomerMenu.LocationCreate.Click();

            Selenium.Location.BillingAddress.Create.CompanyName = "SYR Sele Firma A";
            Selenium.Location.BillingAddress.Create.StreetNo = "Hardturmstr. 201";
            Selenium.Location.BillingAddress.Create.Zip = "8021";
            Selenium.Location.BillingAddress.Create.City = "";
            Selenium.Location.BillingAddress.Create.Po = "PFO1";
            Selenium.Location.BillingAddress.Create.AdressAddition = "Etage 3";
            Selenium.Location.BillingAddress.Create.Region = "Reg 55";
            Selenium.Location.BillingAddress.Create.Language = "Deutsch [de]";
            Selenium.Location.BillingAddress.Create.Country = "Schweiz [CH]";
            Selenium.Location.BillingAddress.Create.Email = "marc.siegmund@six-group.com";
            Selenium.Location.BillingAddress.Create.Telephone = "0031 58 399 6237";
            Selenium.Location.BillingAddress.Create.Mobile = "0032 58 399 6237";
            Selenium.Location.BillingAddress.Create.Fax = "0033 58 399 6237";
            Selenium.Location.BillingAddress.Create.Web = "www.six-group.com/de-intern";

            Selenium.Location.BillingAddress.Create.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateBillingAddressWithoutZipFailed()
        {
            CustomerMenu.LocationCreate.Click();

            Selenium.Location.BillingAddress.Create.CompanyName = "SYR Sele Firma A";
            Selenium.Location.BillingAddress.Create.StreetNo = "Hardturmstr. 201";
            Selenium.Location.BillingAddress.Create.Zip = "";
            Selenium.Location.BillingAddress.Create.City = "Zürich";
            Selenium.Location.BillingAddress.Create.Po = "PFO1";
            Selenium.Location.BillingAddress.Create.AdressAddition = "Etage 3";
            Selenium.Location.BillingAddress.Create.Region = "Reg 55";
            Selenium.Location.BillingAddress.Create.Language = "Deutsch [de]";
            Selenium.Location.BillingAddress.Create.Country = "Schweiz [CH]";
            Selenium.Location.BillingAddress.Create.Email = "marc.siegmund@six-group.com";
            Selenium.Location.BillingAddress.Create.Telephone = "0031 58 399 6237";
            Selenium.Location.BillingAddress.Create.Mobile = "0032 58 399 6237";
            Selenium.Location.BillingAddress.Create.Fax = "0033 58 399 6237";
            Selenium.Location.BillingAddress.Create.Web = "www.six-group.com/de-intern";

            Selenium.Location.BillingAddress.Create.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateBillingAddressAndSave()
        {
            MenusTest.CustomerMenuCheck();
            CustomerMenu.BillingAdressCreate.Click();

            Selenium.Location.BillingAddress.Create.CompanyName = "SYR ReAd SELE A";
            Selenium.Location.BillingAddress.Create.StreetNo = "Rechnungsallee 112";
            Selenium.Location.BillingAddress.Create.Zip = "10010";
            Selenium.Location.BillingAddress.Create.City = "Stuttgart";
            Selenium.Location.BillingAddress.Create.Po = "PO1";

            Selenium.Location.BillingAddress.Create.Language = "Swedish [sv]";
            Selenium.Location.BillingAddress.Create.Country = "Schweden [SE]";
            Selenium.Location.BillingAddress.Create.Email = "marc.siegmund@six-group.com";
            Selenium.Location.BillingAddress.Create.Telephone = "0031 58 399 6237";
            Selenium.Location.BillingAddress.Create.Mobile = "0032 58 399 6237";
            Selenium.Location.BillingAddress.Create.Fax = "0033 58 399 6237";
            Selenium.Location.BillingAddress.Create.Web = "www.six-group.com/de" + _dt;

            Selenium.Location.BillingAddress.Create.SaveButton.Click();

            MenusTest.CustomerMenuCheck();

            Assert.AreEqual("SYR ReAd SELE A", View.CompanyName);
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            //Assert.AreEqual(locId, BillingAddressView.Guid);
            Assert.AreEqual("SYR ReAd SELE A", View.CompanyName);

            Assert.AreEqual("Rechnungsallee 112", View.StreetName);
            Assert.AreEqual("SYR ReAd SELE A", View.CompanyName);
            Assert.AreEqual("10010", View.Zip);
            Assert.AreEqual("Stuttgart", View.City);
            Assert.AreEqual("Swedish [sv]", View.Language);
            Assert.AreEqual("Sweden [SE]", View.Country);
            Assert.AreEqual("marc.siegmund@six-group.com", View.Email);
            Assert.AreEqual("0031 58 399 6237", View.Telephone);
            Assert.AreEqual("0032 58 399 6237", View.Mobile);
            Assert.AreEqual("0033 58 399 6237", View.Fax);
            Assert.AreEqual("www.six-group.com/de" + _dt, View.Web);
        }

        [TestMethod]
        public void CreateBillingAddressWithMinimalAndSave()
        {
            CustomerMenu.BillingAdressCreate.Click();

            Selenium.Location.BillingAddress.Create.CompanyName = "SYR ReAd SELE A";
            Selenium.Location.BillingAddress.Create.StreetNo = "Rechnungsallee 112";
            Selenium.Location.BillingAddress.Create.Zip = "10010";
            Selenium.Location.BillingAddress.Create.City = "Stuttgart";
            Selenium.Location.BillingAddress.Create.Po = "PO1";

            Selenium.Location.BillingAddress.Create.Language = "Swedish [sv]";
            Selenium.Location.BillingAddress.Create.Country = "Schweden [SE]";
            Selenium.Location.BillingAddress.Create.Email = "marc.siegmund@six-group.com";
            Selenium.Location.BillingAddress.Create.Telephone = "0031 58 399 6237";
            Selenium.Location.BillingAddress.Create.Mobile = "0032 58 399 6237";
            Selenium.Location.BillingAddress.Create.Fax = "0033 58 399 6237";
            Selenium.Location.BillingAddress.Create.Web = "www.six-group.com/de" + _dt;

            Selenium.Location.BillingAddress.Create.SaveButton.Click();

            //var locId = _driver.PageSource.;
            Assert.AreEqual("SYR ReAd SELE A", View.CompanyName);
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            //Assert.AreEqual(locId, BillingAddressView.Guid);
            Assert.AreEqual("SYR ReAd SELE A", View.CompanyName);

            Assert.AreEqual("Rechnungsallee 112", View.StreetName);
            Assert.AreEqual("SYR ReAd SELE A", View.CompanyName);
            Assert.AreEqual("10010", View.Zip);
            Assert.AreEqual("Stuttgart", View.City);
            Assert.AreEqual("Swedish [sv]", View.Language);
            Assert.AreEqual("Sweden [SE]", View.Country);
            Assert.AreEqual("marc.siegmund@six-group.com", View.Email);
            Assert.AreEqual("0031 58 399 6237", View.Telephone);
            Assert.AreEqual("0032 58 399 6237", View.Mobile);
            Assert.AreEqual("0033 58 399 6237", View.Fax);
            Assert.AreEqual("www.six-group.com/de" + _dt, View.Web);
        }
    }
}