using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Customer.Edit
{
    [TestClass]
    public class EditCustomerWithInvalidData
    {
        private static CustomerEdit _customerEdit;
        private static FormAlert _formAlert;
        private static CustomerMenu _customerMenu;

        private static List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _customerEdit = new CustomerEdit();
            _formAlert = new FormAlert();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=401152");

            _customerMenu.CustomerEdit.Click();

            _customerEdit.CustomerName = "SYR Sele Kunde A$°";

            _customerEdit.CompanyName = "SYR Sele Firma A$°";
            _customerEdit.StreetName = "Hardturmstr. 201$°";
            _customerEdit.Zip = "802$°";
            _customerEdit.City = "Zürich$°";
            _customerEdit.Po = "PFO1$°";
            _customerEdit.AdressAddition = "Etage 3$°";
            _customerEdit.Region = "Reg 3[]$°";
            _customerEdit.SapNumber = "4}$°";

            _customerEdit.Agency = "SIX Payment Services (Europe)";
            _customerEdit.Language = "Deutsch [de]";
            _customerEdit.Country = "Schweiz [CH]";
            _customerEdit.Email = "marc.siegmund@six-grou$°p.com";
            _customerEdit.Telephone = "0031 58 399 6237}$°";
            _customerEdit.Mobile = "0032 58 399 6237}$°";
            _customerEdit.Fax = "0033 58 399 6237}$°";
            _customerEdit.Web = "www.six-^°@}$.com/de-inte[]rn$°";

            _customerEdit.SaveButton.Click();
            _formAlerts = _formAlert.FormAlertList;
        }

        [TestMethod]
        public void CustomerNameError()
        {
            CollectionAssert.Contains(_formAlerts, "Kundenname: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void CompanyNameError()
        {
            CollectionAssert.Contains(_formAlerts, "Firmenname: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void AdditionNameError()
        {
            CollectionAssert.Contains(_formAlerts, "Zusatz: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void PhoneNumberError()
        {
            CollectionAssert.Contains(_formAlerts, "Telefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void MobileNumberError()
        {
            CollectionAssert.Contains(_formAlerts, "Mobiltelefon: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void FaxNumberError()
        {
            CollectionAssert.Contains(_formAlerts, "Fax: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void StreetAndNumberError()
        {
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void ZipError()
        {
            CollectionAssert.Contains(_formAlerts, "PLZ: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void PoError()
        {
            CollectionAssert.Contains(_formAlerts, "Postfach: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void CityError()
        {
            CollectionAssert.Contains(_formAlerts, "Ort: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void RegionError()
        {
            CollectionAssert.Contains(_formAlerts, "Region (Kurzzeichen): Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void EmailError()
        {
            CollectionAssert.Contains(_formAlerts, "Email: Dies ist keine gültige E-Mail Adresse!");
        }

        [TestMethod]
        public void WebAddressError()
        {
            CollectionAssert.Contains(_formAlerts, "Web: Dies ist keine gültige Web Adresse!",
                                      "web adress not validated");
        }

        [TestMethod]
        public void NumberOfFormAlerts()
        {
            Assert.AreEqual(13, _formAlerts.Count);
        }
    }
}