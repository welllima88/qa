using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Menu;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Edit
{
    [TestClass]
    public class EditContactAndCancelTest
    {
        private static string ContactId;
        private static string _city;
        private static string _country;
        private static string _email;
        private static string _fax;
        private static string _firstName;
        private static string _language;
        private static string _mobile;
        private static string _name;
        private static string _po;
        private static string _region;
        private static string _salutation;
        private static string _streetNo;
        private static string _telephone;
        private static string _zip;

        public EditContactAndCancelTest()
        {
            ContactId = "1";
        }

        public EditContactAndCancelTest(string contactId)
        {
            ContactId = contactId;
        }

        [ClassInitialize]
        public static void TestInit(TestContext testContext)
        {
            TestDirector.Navigate("Person/?PERSONID=" + ContactId);
            
            _salutation = ContactPersonView.Salutation;
            _firstName = ContactPersonView.FirstName;
            _name = ContactPersonView.Name;
            _language = ContactPersonView.Language;
            _telephone = ContactPersonView.Telephone;
            _mobile = ContactPersonView.Mobile;
            _fax = ContactPersonView.Fax;
            _email = ContactPersonView.Email;
            _po = ContactPersonView.Po;
            _streetNo = ContactPersonView.StreetNo;
            _zip = ContactPersonView.Zip;
            _city = ContactPersonView.City;
            _region = ContactPersonView.Region;
            _country = ContactPersonView.Country;

            MenusTest.ContactMenuCheck();

            ContactMenu.ContactEdit.Click();

            ContactPersonEdit.Salutation = "Herr";
            ContactPersonEdit.FirstName = "Marc";
            ContactPersonEdit.Name = "Siegmund";
            ContactPersonEdit.Language = "Italienisch [it]";
            ContactPersonEdit.Telephone = "0123456789";
            ContactPersonEdit.Mobile = "1234567890";
            ContactPersonEdit.Fax = "2345678901";
            ContactPersonEdit.Email = "tksyr_contact@six-group.com";
            ContactPersonEdit.Po = "Pof";
            ContactPersonEdit.StreetNo = "Strasse 1";
            ContactPersonEdit.Zip = "2351";
            ContactPersonEdit.City = "City";
            ContactPersonEdit.Region = "Reg";
            ContactPersonEdit.Country = "Frankreich [FR]";
            ContactPersonEdit.AdressAddition = "Addr-Add";

            ContactPersonEdit.CancelButton.Click();
        }

        [TestMethod]
        public void ContactMenuCheck()
        {
            MenusTest.ContactMenuCheck();
        }

        [TestMethod]
        public void Salutation()
        {
            Assert.AreEqual(_salutation, ContactPersonView.Salutation);
        }

        [TestMethod]
        public void FirstName()
        {
            Assert.AreEqual(_firstName, ContactPersonView.FirstName);
        }

        [TestMethod]
        public void Name()
        {
            Assert.AreEqual(_name, ContactPersonView.Name);
        }

        [TestMethod]
        public void Language()
        {
            Assert.AreEqual(_language, ContactPersonView.Language);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual(_telephone, ContactPersonView.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual(_mobile, ContactPersonView.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual(_fax, ContactPersonView.Fax);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual(_email, ContactPersonView.Email);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual(_po, ContactPersonView.Po);
        }

        [TestMethod]
        public void StreetNo()
        {
            Assert.AreEqual(_streetNo, ContactPersonView.StreetNo);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual(_zip, ContactPersonView.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual(_city, ContactPersonView.City);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual(_region, ContactPersonView.Region);
        }

        [TestMethod]
        public void Country()
        {
            Assert.AreEqual(_country, ContactPersonView.Country);
        }
    }
}