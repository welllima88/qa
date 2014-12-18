using NUnit.Framework;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Person;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Contact.Edit
{
    [TestFixture]
    public class EditContactAndCancelTest
    {
        private static string _contactId;
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
        //private static string _web;
        private static string _addressAddition;
        private static string _web;

        [TestFixtureSetUp]
        public static void TestInit()
        {
            _contactId = "31432";
            TestDirector.Navigate("Person/?PERSONID=" + _contactId);

            _salutation = View.Salutation;
            _firstName = View.FirstName;
            _name = View.Name;
            _language = View.Language;
            _telephone = View.Telephone;
            _mobile = View.Mobile;
            _fax = View.Fax;
            _email = View.Email;
            _po = View.Po;
            _streetNo = View.StreetNo;
            _zip = View.Zip;
            _city = View.City;
            _region = View.Region;
            _country = View.Country;
            _web = View.Web;
            // _web = ContactPersonView.Web;
            _addressAddition = View.AddressAddition;

            ContactMenu.ContactEdit.Click();

            Person.Edit.Salutation = "Herr";
            Person.Edit.FirstName = "Marc";
            Person.Edit.Name = "Siegmund";
            Person.Edit.Language = "it";
            Person.Edit.Telephone = "0123456789";
            Person.Edit.Mobile = "1234567890";
            Person.Edit.Fax = "2345678901";
            Person.Edit.Email = "tksyr_contact@six-group.com";
            Person.Edit.Po = "Pof";
            Person.Edit.StreetNo = "Strasse 1";
            Person.Edit.Zip = "2351";
            Person.Edit.City = "City";
            Person.Edit.Region = "Reg";
            Person.Edit.Country = "IT";
            Person.Edit.AdressAddition = "Addr-Add";

            Person.Edit.CancelButton.Click();
        }

        [Test]
        public void Salutation()
        {
            Assert.AreEqual(_salutation, View.Salutation);
        }

        [Test]
        public void FirstName()
        {
            Assert.AreEqual(_firstName, View.FirstName);
        }

        [Test]
        public void Name()
        {
            Assert.AreEqual(_name, View.Name);
        }

        [Test]
        public void Language()
        {
            Assert.AreEqual(_language, View.Language);
        }

        [Test]
        public void Telephone()
        {
            Assert.AreEqual(_telephone, View.Telephone);
        }

        [Test]
        public void Mobile()
        {
            Assert.AreEqual(_mobile, View.Mobile);
        }

        [Test]
        public void Fax()
        {
            Assert.AreEqual(_fax, View.Fax);
        }

        [Test]
        public void Email()
        {
            Assert.AreEqual(_email, View.Email);
        }

        [Test]
        public void Po()
        {
            Assert.AreEqual(_po, View.Po);
        }

        [Test]
        public void StreetNo()
        {
            Assert.AreEqual(_streetNo, View.StreetNo);
        }

        [Test]
        public void Zip()
        {
            Assert.AreEqual(_zip, View.Zip);
        }

        [Test]
        public void City()
        {
            Assert.AreEqual(_city, View.City);
        }

        [Test]
        public void Region()
        {
            Assert.AreEqual(_region, View.Region);
        }

        [Test]
        public void Country()
        {
            Assert.AreEqual(_country, View.Country);
        }

        [Test]
        public void Web()
        {
            Assert.AreEqual(_web, View.Web);
        }

        [Test]
        public void AddressAddition()
        {
            Assert.AreEqual(_addressAddition, View.AddressAddition);
        }
    }
}