using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Edit
{
    [TestClass]
    public class EditCustomerWithInvalidData
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=401152");

            CustomerMenu.CustomerEdit.Click();

            CustomerEdit.CustomerName = "SYR Sele Kunde A$°";

            CustomerEdit.CompanyName = "SYR Sele Firma A$°";
            CustomerEdit.StreetNo = "Hardturmstr. 201$°";
            CustomerEdit.Zip = "802$°";
            CustomerEdit.City = "Zürich$°";
            CustomerEdit.Po = "PFO1$°";
            CustomerEdit.AdressAddition = "Etage 3$°";
            CustomerEdit.Region = "Reg 3[]$°";
            CustomerEdit.SapNumber = "4}$°";

            CustomerEdit.Agency = "SIX Payment Services (Europe)";
            CustomerEdit.Language = "Deutsch [de]";
            CustomerEdit.Country = "Schweiz [CH]";
            CustomerEdit.Email = "marc.siegmund@six-grou$°p.com";
            CustomerEdit.Telephone = "0031 58 399 6237}$°";
            CustomerEdit.Mobile = "0032 58 399 6237}$°";
            CustomerEdit.Fax = "0033 58 399 6237}$°";
            CustomerEdit.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            CustomerEdit.SaveButton.Click();
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