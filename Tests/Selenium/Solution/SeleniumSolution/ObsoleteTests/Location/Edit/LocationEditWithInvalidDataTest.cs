using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Location;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Location.Edit
{
    [TestClass]
    public class LocationEditWithInvalidDataTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Location/Edit?LOCATIONID=071b90c2-c8c5-42c5-87c5-d816b26b0a1a");
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
        }

        [TestMethod]
        public void CompanyName()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void AdressAddition()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Zusatz: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void Telephone()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Telefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void Mobile()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Mobiltelefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void EditLocationWithInvalidDataFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Fax: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void StreetNo()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void Zip()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void Po()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Postfach: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void City()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void Region()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Region (Kurzzeichen): Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void Email()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Email: Dies ist keine gültige E-Mail Adresse!");
        }

        [TestMethod]
        public void Web()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Web: Dies ist keine gültige Web Adresse!");
        }

        [TestMethod]
        public void NumberOfAlerts()
        {
            Assert.AreEqual(12, FormAlert.FormAlertList.Count, "Wrong number of form alerts");
        }
    }
}