using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Edit
{
    [TestClass]
    public class InvalidData
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?PageMode=edit&CUSTOMERID=401858");

            Selenium.Customer.Edit.CustomerName = "SYR Sele Kunde A$°";

            Selenium.Customer.Edit.CompanyName = "SYR Sele Firma A$°";
            Selenium.Customer.Edit.StreetNo = "Hardturmstr. 201$°";
            Selenium.Customer.Edit.Zip = "802$°";
            Selenium.Customer.Edit.City = "Zürich$°";
            Selenium.Customer.Edit.Po = "PFO1$°";
            Selenium.Customer.Edit.AdressAddition = "Etage 3$°";
            Selenium.Customer.Edit.Region = "Reg 3[]$°";
            Selenium.Customer.Edit.SapNumber = "4}$°";

            Selenium.Customer.Edit.Agency = "SIX Payment Services (Europe)";
            Selenium.Customer.Edit.Language = "Deutsch [de]";
            Selenium.Customer.Edit.Country = "Schweiz [CH]";
            Selenium.Customer.Edit.Email = "marc.siegmund@six-grou$°p.com";
            Selenium.Customer.Edit.Telephone = "0031 58 399 6237}$°";
            Selenium.Customer.Edit.Mobile = "0032 58 399 6237}$°";
            Selenium.Customer.Edit.Fax = "0033 58 399 6237}$°";
            Selenium.Customer.Edit.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            Selenium.Customer.Edit.SaveButton.Click();
        }

        [TestMethod]
        public void CustomerNameError()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Kundenname: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void CompanyNameError()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void AdditionNameError()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Zusatz: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void PhoneNumberError()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Telefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void MobileNumberError()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Mobiltelefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void FaxNumberError()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Fax: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void StreetAndNumberError()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void ZipError()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void PoError()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Postfach: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void CityError()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void RegionError()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Region (Kurzzeichen): Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void EmailError()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Email: Dies ist keine gültige E-Mail Adresse!");
        }

        [TestMethod]
        public void WebAddressError()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Web: Dies ist keine gültige Web Adresse!",
                "web adress not validated");
        }

        [TestMethod]
        public void NumberOfFormAlerts()
        {
            Assert.AreEqual(13, FormAlert.FormAlertList.Count);
        }
    }
}