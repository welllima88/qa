using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Create
{
    [TestFixture]
    public class InvalidData : Selenium.Customer.Create
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();

            SetInvalidData();
        }

        private static void SetInvalidData()
        {
            Supplier = "SIX Payment Services AG";
            SbsCurrency = "EUR";
            SbsBillingTenant = "SIX Payment Services (Europe)";
            CustomerName = "SYR Sele Kunde A$°";
            CompanyName = "SYR Sele Firma A$°";
            StreetNo = "Hardturmstr. 201$°";
            Zip = "802$°";
            City = "Zürich$°";
            Po = "PFO1$°";
            AdressAddition = "Etage 3$°";
            Region = "Reg 3[]$°";
            SapNumber = "444$°";
            Ep2MerchantId = "12D$F_3-3";
            Agency = "Albert Brun & Partner";
            Language = "Deutsch [de]";
            Country = "Schweiz [CH]";
            Email = "marc.siegmund@six-grou$°p.com";
            Telephone = "0031 58 399 6237$";
            Mobile = "0032 58 399 6237$";
            Fax = "0033 58 399 6237$";
            Web = "www.six-^°@}$.com/de-inte[]rn$°";

            SaveButton.Click();
        }

        [Test]
        [Category("Customer"), Category("Create"), Category("Invalid")]
        public void CreateCustomerWithInvalidCustomerNameFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Kundenname: Ungültige Zeichen gefunden!");
        }

        [Test]
        [Category("Customer"), Category("Create"), Category("Invalid")]
        public void CreateCustomerWithInvalidCustomerNumberFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Kundennummer: Ihre Eingabe ist ungültig!");
        }

        [Test]
        [Category("Customer"), Category("Create"), Category("Invalid")]
        public void CreateCustomerWithInvalidCompanyNameFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Ungültige Zeichen gefunden!");
        }

        [Test]
        [Category("Customer"), Category("Create"), Category("Invalid")]
        public void CreateCustomerWithInvalidAdressAdditionFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Zusatz: Ungültige Zeichen gefunden!");
        }

        [Test]
        [Category("Customer"), Category("Create"), Category("Invalid")]
        public void CreateCustomerWithInvalidTelephoneFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Telefon: Ungültige Zeichen gefunden!");
        }

        [Test]
        [Category("Customer"), Category("Create"), Category("Invalid")]
        public void CreateCustomerWithInvalidMobileFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Mobiltelefon: Ungültige Zeichen gefunden!");
        }

        [Test]
        [Category("Customer"), Category("Create"), Category("Invalid")]
        public void CreateCustomerWithInvalidFaxFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Fax: Ungültige Zeichen gefunden!");
        }

        [Test]
        [Category("Customer"), Category("Create"), Category("Invalid")]
        public void CreateCustomerWithInvalidStreetNumberFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Ungültige Zeichen gefunden!");
        }

        [Test]
        [Category("Customer"), Category("Create"), Category("Invalid")]
        public void CreateCustomerWithInvalidZipFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Ungültige Zeichen gefunden!");
        }

        [Test]
        [Category("Customer"), Category("Create"), Category("Invalid")]
        public void CreateCustomerWithInvalidPoFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Postfach: Ungültige Zeichen gefunden!");
        }

        [Test]
        [Category("Customer"), Category("Create"), Category("Invalid")]
        public void CreateCustomerWithInvalidCityFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Ungültige Zeichen gefunden!");
        }

        [Test]
        [Category("Customer"), Category("Create"), Category("Invalid")]
        public void CreateCustomerWithInvalidRegionFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Region (Kurzzeichen): Ungültige Zeichen gefunden!");
        }

        [Test]
        [Category("Customer"), Category("Create"), Category("Invalid")]
        public void CreateCustomerWithInvalidEmailFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Email: Dies ist keine gültige E-Mail Adresse!");
        }

        [Test]
        [Category("Customer"), Category("Create"), Category("Invalid")]
        public void CreateCustomerWithInvalidWebFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Web: Dies ist keine gültige Web Adresse!");
        }

        [Test]
        [Category("Customer"), Category("Create"), Category("Invalid")]
        public void CreateCustomerWithInvalidEp2MerchantIdFailed()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Dies ist keine gültige EP2 Händlernummer.");
        }
    }
}