using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location
{
    [TestClass]
    public class BillingAddressEditTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate(
                "/BillingAddress?CustomerId=404840&BillingAddressId=1ef8d828-44ec-4304-8385-df0088cb0fc7");
        }

        [TestMethod]
        public void EditBillingAddressAndCancel()
        {
            string companyName = BillingAddressView.CompanyName;
            string po = BillingAddressView.Po;
            string adressAddition = BillingAddressView.AdressAddition;
            string streetName = BillingAddressView.StreetName;
            string zip = BillingAddressView.Zip;
            string city = BillingAddressView.City;
            string language = BillingAddressView.Language;
            string country = BillingAddressView.Country;
            string email = BillingAddressView.Email;
            string telephone = BillingAddressView.Telephone;
            string mobile = BillingAddressView.Mobile;
            string fax = BillingAddressView.Fax;
            string web = BillingAddressView.Web;

            CustomerMenu.BillingAddressEdit.Click();

            BillingAddressEdit.CompanyName = "SYR Sele Firma AAA";
            BillingAddressEdit.StreetName = "Hardturmstr. 2011";
            BillingAddressEdit.Zip = "80222";
            BillingAddressEdit.City = "Zürichhh";
            BillingAddressEdit.Po = "PFO111";
            BillingAddressEdit.AdressAddition = "Etage 333";
            BillingAddressEdit.Region = "Reggg";
            BillingAddressEdit.Language = "Croatian [hr]";
            BillingAddressEdit.Country = "Albanien [AL]";
            BillingAddressEdit.Email = "marc.siegmund@six-group.commmm";
            BillingAddressEdit.Telephone = "0031 58 399 623777";
            BillingAddressEdit.Mobile = "0032 58 399 623777";
            BillingAddressEdit.Fax = "0033 58 399 623777";
            BillingAddressEdit.Web = "www.six-group.com/de-internnnn";

            BillingAddressEdit.CancelButton.Click();

            Assert.AreEqual(companyName, BillingAddressView.CompanyName);
            Assert.AreEqual(po, BillingAddressView.Po);
            Assert.AreEqual(adressAddition, BillingAddressView.AdressAddition);
            Assert.AreEqual(streetName, BillingAddressView.StreetName);
            Assert.AreEqual(zip, BillingAddressView.Zip);
            Assert.AreEqual(city, BillingAddressView.City);
            Assert.AreEqual(language, BillingAddressView.Language);
            Assert.AreEqual(country, BillingAddressView.Country);
            Assert.AreEqual(email, BillingAddressView.Email);
            Assert.AreEqual(telephone, BillingAddressView.Telephone);
            Assert.AreEqual(mobile, BillingAddressView.Mobile);
            Assert.AreEqual(fax, BillingAddressView.Fax);
            Assert.AreEqual(web, BillingAddressView.Web);
        }

        [TestMethod]
        public void EditBillingAddressWithInvalidDataFailed()
        {
            CustomerMenu.BillingAddressEdit.Click();

            BillingAddressEdit.CompanyName = "SYR Sele Firma A$°";
            BillingAddressEdit.StreetName = "Hardturmstr. 201$°";
            BillingAddressEdit.Zip = "802$°";
            BillingAddressEdit.City = "Zürich$°";
            BillingAddressEdit.Po = "PFO1$°";
            BillingAddressEdit.AdressAddition = "Etage 3$°";
            BillingAddressEdit.Region = "Reg 3[]$°";
            BillingAddressEdit.Language = "Deutsch [de]";
            BillingAddressEdit.Country = "Schweiz [CH]";
            BillingAddressEdit.Email = "marc.siegmund@six-grou$°p.com";
            BillingAddressEdit.Telephone = "0031 58 399 6237$";
            BillingAddressEdit.Mobile = "0032 58 399 6237$";
            BillingAddressEdit.Fax = "0033 58 399 6237$";
            BillingAddressEdit.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            BillingAddressEdit.SaveButton.Click();

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
        public void EditBillingAddressWithoutCompanyNameFailed()
        {
            CustomerMenu.BillingAddressEdit.Click();

            BillingAddressEdit.StreetName = "Hardturmstr. 201";
            BillingAddressEdit.Zip = "8021";
            BillingAddressEdit.City = "Zürich";
            BillingAddressEdit.Po = "PFO1";
            BillingAddressEdit.AdressAddition = "Etage 3";
            BillingAddressEdit.Language = "Deutsch [de]";
            BillingAddressEdit.Country = "Schweiz [CH]";
            BillingAddressEdit.Email = "marc.siegmund@six-group.com";
            BillingAddressEdit.Telephone = "0031 58 399 6237";
            BillingAddressEdit.Mobile = "0032 58 399 6237";
            BillingAddressEdit.Fax = "0033 58 399 6237";
            BillingAddressEdit.Web = "www.six-group.com/de-intern";

            BillingAddressEdit.CompanyName = "";
            BillingAddressEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
            BillingAddressEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditBillingAddressWithIncompleteDataFailed()
        {
            CustomerMenu.BillingAddressEdit.Click();

            BillingAddressEdit.CompanyName = "";
            BillingAddressEdit.StreetName = "";
            BillingAddressEdit.Zip = "";
            BillingAddressEdit.City = "";
            BillingAddressEdit.Po = "";
            BillingAddressEdit.AdressAddition = "";
            BillingAddressEdit.Region = "";

            BillingAddressEdit.Email = "";
            BillingAddressEdit.Telephone = "";
            BillingAddressEdit.Mobile = "";
            BillingAddressEdit.Fax = "";
            BillingAddressEdit.Web = "";

            BillingAddressEdit.SaveButton.Click();

            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
            Assert.AreEqual(4, FormAlert.FormAlertList.Count);

            BillingAddressEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditBillingAddressWithoutStreetAndNumberFailed()
        {
            CustomerMenu.BillingAddressEdit.Click();

            BillingAddressEdit.CompanyName = "SYR Sele Firma A";
            BillingAddressEdit.StreetName = "";
            BillingAddressEdit.Zip = "8021";
            BillingAddressEdit.City = "Zürich";
            BillingAddressEdit.Po = "PFO1";
            BillingAddressEdit.AdressAddition = "Etage 3";
            BillingAddressEdit.Language = "Deutsch [de]";
            BillingAddressEdit.Country = "Schweiz [CH]";
            BillingAddressEdit.Email = "marc.siegmund@six-group.com";
            BillingAddressEdit.Telephone = "0031 58 399 6237";
            BillingAddressEdit.Mobile = "0032 58 399 6237";
            BillingAddressEdit.Fax = "0033 58 399 6237";
            BillingAddressEdit.Web = "www.six-group.com/de-intern";

            BillingAddressEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
            BillingAddressEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditBillingAddressWithoutCityFailed()
        {
            CustomerMenu.BillingAddressEdit.Click();

            BillingAddressEdit.CompanyName = "SYR Sele Firma A";
            BillingAddressEdit.StreetName = "Hardturmstr. 201";
            BillingAddressEdit.Zip = "8021";
            BillingAddressEdit.City = "";
            BillingAddressEdit.Po = "PFO1";
            BillingAddressEdit.AdressAddition = "Etage 3";
            BillingAddressEdit.Language = "Deutsch [de]";
            BillingAddressEdit.Country = "Schweiz [CH]";
            BillingAddressEdit.Email = "marc.siegmund@six-group.com";
            BillingAddressEdit.Telephone = "0031 58 399 6237";
            BillingAddressEdit.Mobile = "0032 58 399 6237";
            BillingAddressEdit.Fax = "0033 58 399 6237";
            BillingAddressEdit.Web = "www.six-group.com/de-intern";

            BillingAddressEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
            BillingAddressEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditBillingAddressWithoutZipFailed()
        {
            CustomerMenu.BillingAddressEdit.Click();

            BillingAddressEdit.CompanyName = "SYR Sele Firma A";
            BillingAddressEdit.StreetName = "Hardturmstr. 201";
            BillingAddressEdit.Zip = "";
            BillingAddressEdit.City = "Zürich";
            BillingAddressEdit.Po = "PFO1";
            BillingAddressEdit.AdressAddition = "Etage 3";
            BillingAddressEdit.Language = "Deutsch [de]";
            BillingAddressEdit.Country = "Schweiz [CH]";
            BillingAddressEdit.Email = "marc.siegmund@six-group.com";
            BillingAddressEdit.Telephone = "0031 58 399 6237";
            BillingAddressEdit.Mobile = "0032 58 399 6237";
            BillingAddressEdit.Fax = "0033 58 399 6237";
            BillingAddressEdit.Web = "www.six-group.com/de-intern";

            BillingAddressEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void EditBillingAddressAndSave()
        {
            CustomerMenu.BillingAddressEdit.Click();

            BillingAddressEdit.CompanyName = "SYR Standort SELE B";
            BillingAddressEdit.StreetName = "Am Bärenplatz 2";
            BillingAddressEdit.Zip = "8001";
            BillingAddressEdit.City = "Kreuzlingen";
            BillingAddressEdit.Po = "PO2-A";
            BillingAddressEdit.AdressAddition = "Level2";
            BillingAddressEdit.Email = "marc.siegmund@six-group.com/scs";
            BillingAddressEdit.Telephone = "+41 58 399 6237";
            BillingAddressEdit.Mobile = "+42 58 399 6237";
            BillingAddressEdit.Fax = "+43 58 399 6237";
            BillingAddressEdit.Web = "www.six-group.com";
            BillingAddressEdit.Language = "English [en]";
            BillingAddressEdit.Country = "Schweiz [CH]";

            BillingAddressCreate.SaveButton.Click();

            Assert.AreEqual("SYR Standort SELE B", BillingAddressView.CompanyName);
            NavigationBar.Lobby.Click();
            RecentElements.MostRecent.Click();

            Assert.AreEqual("SYR Standort SELE B", BillingAddressView.CompanyName);
            Assert.AreEqual("Am Bärenplatz 2", BillingAddressView.StreetName);
            Assert.AreEqual("SYR Standort SELE B", BillingAddressView.CompanyName);
            Assert.AreEqual("8001", BillingAddressView.Zip);
            Assert.AreEqual("PO2-A", BillingAddressView.Po);
            Assert.AreEqual("Level2", BillingAddressView.AdressAddition);
            Assert.AreEqual("Kreuzlingen", BillingAddressView.City);
            Assert.AreEqual("English [en]", BillingAddressView.Language);
            Assert.AreEqual("Switzerland [CH]", BillingAddressView.Country);
            Assert.AreEqual("marc.siegmund@six-group.com/scs", BillingAddressView.Email);
            Assert.AreEqual("+41 58 399 6237", BillingAddressView.Telephone);
            Assert.AreEqual("+42 58 399 6237", BillingAddressView.Mobile);
            Assert.AreEqual("+43 58 399 6237", BillingAddressView.Fax);
            Assert.AreEqual("www.six-group.com", BillingAddressView.Web);
        }
    }
}