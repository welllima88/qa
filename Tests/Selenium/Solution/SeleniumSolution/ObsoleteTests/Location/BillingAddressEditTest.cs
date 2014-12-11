using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Location.BillingAddress;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Location
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
            string companyName = View.CompanyName;
            string po = View.Po;
            string adressAddition = View.AdressAddition;
            string streetName = View.StreetNo;
            string zip = View.Zip;
            string city = View.City;
            string language = View.Language;
            string country = View.Country;
            string email = View.Email;
            string telephone = View.Telephone;
            string mobile = View.Mobile;
            string fax = View.Fax;
            string web = View.Web;

            CustomerMenu.BillingAddressEdit.Click();

            Selenium.Location.BillingAddress.Edit.CompanyName = "SYR Sele Firma AAA";
            Selenium.Location.BillingAddress.Edit.StreetNo = "Hardturmstr. 2011";
            Selenium.Location.BillingAddress.Edit.Zip = "80222";
            Selenium.Location.BillingAddress.Edit.City = "Zürichhh";
            Selenium.Location.BillingAddress.Edit.Po = "PFO111";
            Selenium.Location.BillingAddress.Edit.AdressAddition = "Etage 333";
            Selenium.Location.BillingAddress.Edit.Region = "Reggg";
            Selenium.Location.BillingAddress.Edit.Language = "Croatian [hr]";
            Selenium.Location.BillingAddress.Edit.Country = "Albanien [AL]";
            Selenium.Location.BillingAddress.Edit.Email = "marc.siegmund@six-group.commmm";
            Selenium.Location.BillingAddress.Edit.Telephone = "0031 58 399 623777";
            Selenium.Location.BillingAddress.Edit.Mobile = "0032 58 399 623777";
            Selenium.Location.BillingAddress.Edit.Fax = "0033 58 399 623777";
            Selenium.Location.BillingAddress.Edit.Web = "www.six-group.com/de-internnnn";

            Selenium.Location.BillingAddress.Edit.CancelButton.Click();

            Assert.AreEqual(companyName, View.CompanyName);
            Assert.AreEqual(po, View.Po);
            Assert.AreEqual(adressAddition, View.AdressAddition);
            Assert.AreEqual(streetName, View.StreetNo);
            Assert.AreEqual(zip, View.Zip);
            Assert.AreEqual(city, View.City);
            Assert.AreEqual(language, View.Language);
            Assert.AreEqual(country, View.Country);
            Assert.AreEqual(email, View.Email);
            Assert.AreEqual(telephone, View.Telephone);
            Assert.AreEqual(mobile, View.Mobile);
            Assert.AreEqual(fax, View.Fax);
            Assert.AreEqual(web, View.Web);
        }

        [TestMethod]
        public void EditBillingAddressWithInvalidDataFailed()
        {
            CustomerMenu.BillingAddressEdit.Click();

            Selenium.Location.BillingAddress.Edit.CompanyName = "SYR Sele Firma A$°";
            Selenium.Location.BillingAddress.Edit.StreetNo = "Hardturmstr. 201$°";
            Selenium.Location.BillingAddress.Edit.Zip = "802$°";
            Selenium.Location.BillingAddress.Edit.City = "Zürich$°";
            Selenium.Location.BillingAddress.Edit.Po = "PFO1$°";
            Selenium.Location.BillingAddress.Edit.AdressAddition = "Etage 3$°";
            Selenium.Location.BillingAddress.Edit.Region = "Reg 3[]$°";
            Selenium.Location.BillingAddress.Edit.Language = "Deutsch [de]";
            Selenium.Location.BillingAddress.Edit.Country = "Schweiz [CH]";
            Selenium.Location.BillingAddress.Edit.Email = "marc.siegmund@six-grou$°p.com";
            Selenium.Location.BillingAddress.Edit.Telephone = "0031 58 399 6237$";
            Selenium.Location.BillingAddress.Edit.Mobile = "0032 58 399 6237$";
            Selenium.Location.BillingAddress.Edit.Fax = "0033 58 399 6237$";
            Selenium.Location.BillingAddress.Edit.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            Selenium.Location.BillingAddress.Edit.SaveButton.Click();

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

            Selenium.Location.BillingAddress.Edit.StreetNo = "Hardturmstr. 201";
            Selenium.Location.BillingAddress.Edit.Zip = "8021";
            Selenium.Location.BillingAddress.Edit.City = "Zürich";
            Selenium.Location.BillingAddress.Edit.Po = "PFO1";
            Selenium.Location.BillingAddress.Edit.AdressAddition = "Etage 3";
            Selenium.Location.BillingAddress.Edit.Language = "Deutsch [de]";
            Selenium.Location.BillingAddress.Edit.Country = "Schweiz [CH]";
            Selenium.Location.BillingAddress.Edit.Email = "marc.siegmund@six-group.com";
            Selenium.Location.BillingAddress.Edit.Telephone = "0031 58 399 6237";
            Selenium.Location.BillingAddress.Edit.Mobile = "0032 58 399 6237";
            Selenium.Location.BillingAddress.Edit.Fax = "0033 58 399 6237";
            Selenium.Location.BillingAddress.Edit.Web = "www.six-group.com/de-intern";

            Selenium.Location.BillingAddress.Edit.CompanyName = "";
            Selenium.Location.BillingAddress.Edit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
            Selenium.Location.BillingAddress.Edit.CancelButton.Click();
        }

        [TestMethod]
        public void EditBillingAddressWithIncompleteDataFailed()
        {
            CustomerMenu.BillingAddressEdit.Click();

            Selenium.Location.BillingAddress.Edit.CompanyName = "";
            Selenium.Location.BillingAddress.Edit.StreetNo = "";
            Selenium.Location.BillingAddress.Edit.Zip = "";
            Selenium.Location.BillingAddress.Edit.City = "";
            Selenium.Location.BillingAddress.Edit.Po = "";
            Selenium.Location.BillingAddress.Edit.AdressAddition = "";
            Selenium.Location.BillingAddress.Edit.Region = "";

            Selenium.Location.BillingAddress.Edit.Email = "";
            Selenium.Location.BillingAddress.Edit.Telephone = "";
            Selenium.Location.BillingAddress.Edit.Mobile = "";
            Selenium.Location.BillingAddress.Edit.Fax = "";
            Selenium.Location.BillingAddress.Edit.Web = "";

            Selenium.Location.BillingAddress.Edit.SaveButton.Click();

            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
            Assert.AreEqual(4, FormAlert.FormAlertList.Count);

            Selenium.Location.BillingAddress.Edit.CancelButton.Click();
        }

        [TestMethod]
        public void EditBillingAddressWithoutStreetAndNumberFailed()
        {
            CustomerMenu.BillingAddressEdit.Click();

            Selenium.Location.BillingAddress.Edit.CompanyName = "SYR Sele Firma A";
            Selenium.Location.BillingAddress.Edit.StreetNo = "";
            Selenium.Location.BillingAddress.Edit.Zip = "8021";
            Selenium.Location.BillingAddress.Edit.City = "Zürich";
            Selenium.Location.BillingAddress.Edit.Po = "PFO1";
            Selenium.Location.BillingAddress.Edit.AdressAddition = "Etage 3";
            Selenium.Location.BillingAddress.Edit.Language = "Deutsch [de]";
            Selenium.Location.BillingAddress.Edit.Country = "Schweiz [CH]";
            Selenium.Location.BillingAddress.Edit.Email = "marc.siegmund@six-group.com";
            Selenium.Location.BillingAddress.Edit.Telephone = "0031 58 399 6237";
            Selenium.Location.BillingAddress.Edit.Mobile = "0032 58 399 6237";
            Selenium.Location.BillingAddress.Edit.Fax = "0033 58 399 6237";
            Selenium.Location.BillingAddress.Edit.Web = "www.six-group.com/de-intern";

            Selenium.Location.BillingAddress.Edit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
            Selenium.Location.BillingAddress.Edit.CancelButton.Click();
        }

        [TestMethod]
        public void EditBillingAddressWithoutCityFailed()
        {
            CustomerMenu.BillingAddressEdit.Click();

            Selenium.Location.BillingAddress.Edit.CompanyName = "SYR Sele Firma A";
            Selenium.Location.BillingAddress.Edit.StreetNo = "Hardturmstr. 201";
            Selenium.Location.BillingAddress.Edit.Zip = "8021";
            Selenium.Location.BillingAddress.Edit.City = "";
            Selenium.Location.BillingAddress.Edit.Po = "PFO1";
            Selenium.Location.BillingAddress.Edit.AdressAddition = "Etage 3";
            Selenium.Location.BillingAddress.Edit.Language = "Deutsch [de]";
            Selenium.Location.BillingAddress.Edit.Country = "Schweiz [CH]";
            Selenium.Location.BillingAddress.Edit.Email = "marc.siegmund@six-group.com";
            Selenium.Location.BillingAddress.Edit.Telephone = "0031 58 399 6237";
            Selenium.Location.BillingAddress.Edit.Mobile = "0032 58 399 6237";
            Selenium.Location.BillingAddress.Edit.Fax = "0033 58 399 6237";
            Selenium.Location.BillingAddress.Edit.Web = "www.six-group.com/de-intern";

            Selenium.Location.BillingAddress.Edit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
            Selenium.Location.BillingAddress.Edit.CancelButton.Click();
        }

        [TestMethod]
        public void EditBillingAddressWithoutZipFailed()
        {
            CustomerMenu.BillingAddressEdit.Click();

            Selenium.Location.BillingAddress.Edit.CompanyName = "SYR Sele Firma A";
            Selenium.Location.BillingAddress.Edit.StreetNo = "Hardturmstr. 201";
            Selenium.Location.BillingAddress.Edit.Zip = "";
            Selenium.Location.BillingAddress.Edit.City = "Zürich";
            Selenium.Location.BillingAddress.Edit.Po = "PFO1";
            Selenium.Location.BillingAddress.Edit.AdressAddition = "Etage 3";
            Selenium.Location.BillingAddress.Edit.Language = "Deutsch [de]";
            Selenium.Location.BillingAddress.Edit.Country = "Schweiz [CH]";
            Selenium.Location.BillingAddress.Edit.Email = "marc.siegmund@six-group.com";
            Selenium.Location.BillingAddress.Edit.Telephone = "0031 58 399 6237";
            Selenium.Location.BillingAddress.Edit.Mobile = "0032 58 399 6237";
            Selenium.Location.BillingAddress.Edit.Fax = "0033 58 399 6237";
            Selenium.Location.BillingAddress.Edit.Web = "www.six-group.com/de-intern";

            Selenium.Location.BillingAddress.Edit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void EditBillingAddressAndSave()
        {
            CustomerMenu.BillingAddressEdit.Click();

            Selenium.Location.BillingAddress.Edit.CompanyName = "SYR Standort SELE B";
            Selenium.Location.BillingAddress.Edit.StreetNo = "Am Bärenplatz 2";
            Selenium.Location.BillingAddress.Edit.Zip = "8001";
            Selenium.Location.BillingAddress.Edit.City = "Kreuzlingen";
            Selenium.Location.BillingAddress.Edit.Po = "PO2-A";
            Selenium.Location.BillingAddress.Edit.AdressAddition = "Level2";
            Selenium.Location.BillingAddress.Edit.Email = "marc.siegmund@six-group.com/scs";
            Selenium.Location.BillingAddress.Edit.Telephone = "+41 58 399 6237";
            Selenium.Location.BillingAddress.Edit.Mobile = "+42 58 399 6237";
            Selenium.Location.BillingAddress.Edit.Fax = "+43 58 399 6237";
            Selenium.Location.BillingAddress.Edit.Web = "www.six-group.com";
            Selenium.Location.BillingAddress.Edit.Language = "English [en]";
            Selenium.Location.BillingAddress.Edit.Country = "Schweiz [CH]";

            Selenium.Location.BillingAddress.Create.SaveButton.Click();

            Assert.AreEqual("SYR Standort SELE B", View.CompanyName);
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            Assert.AreEqual("SYR Standort SELE B", View.CompanyName);
            Assert.AreEqual("Am Bärenplatz 2", View.StreetNo);
            Assert.AreEqual("SYR Standort SELE B", View.CompanyName);
            Assert.AreEqual("8001", View.Zip);
            Assert.AreEqual("PO2-A", View.Po);
            Assert.AreEqual("Level2", View.AdressAddition);
            Assert.AreEqual("Kreuzlingen", View.City);
            Assert.AreEqual("English [en]", View.Language);
            Assert.AreEqual("Switzerland [CH]", View.Country);
            Assert.AreEqual("marc.siegmund@six-group.com/scs", View.Email);
            Assert.AreEqual("+41 58 399 6237", View.Telephone);
            Assert.AreEqual("+42 58 399 6237", View.Mobile);
            Assert.AreEqual("+43 58 399 6237", View.Fax);
            Assert.AreEqual("www.six-group.com", View.Web);
        }
    }
}