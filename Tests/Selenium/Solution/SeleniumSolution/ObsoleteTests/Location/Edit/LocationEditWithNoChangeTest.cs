using System.Text.RegularExpressions;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Location;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Location.Edit
{
    [TestFixture]
    public class LocationEditWithNoChangeTest
    {
        private string _adressAddition;
        private string _city;
        private string _companyName;
        private string _country;
        private string _email;
        private string _ep2MerchantId;
        private string _fax;
        private string _guid;
        private string _language;
        private string _mobile;
        private string _po;
        private string _sapNumber;
        private string _sbsAdressNumber;
        private string _sbsDebitNumber;
        private string _streetName;
        private string _telephone;
        private string _web;
        private string _zip;

        [SetUp]
        public void TestInit()
        {
            TestDirector.Navigate("Location?LocationId=4b77d4f2-d5db-4823-9d52-63c1534de457");
            _guid = View.Guid;

            _sapNumber = View.SapNumber;
            _sbsDebitNumber = View.SbsDebitNumber;
            _sbsAdressNumber = View.SbsAdressNumber;

            _ep2MerchantId = View.Ep2MerchantId;

            _companyName = View.CompanyName;
            _po = View.Po;
            _adressAddition = View.AdressAddition;
            _streetName = View.StreetNo;
            _zip = View.Zip;
            _city = View.City;
            _language = View.Language;
            _country = View.Country;
            _email = View.Email;
            _telephone = View.Telephone;
            _mobile = View.Mobile;
            _fax = View.Fax;
            _web = View.Web;

            LocationMenu.LocationEdit.Click();

            Selenium.Location.Edit.SaveButton.Click();
        }

        [Test]
        public void Guid()
        {
            Assert.AreEqual(_guid, View.Guid);
        }

        [Test]
        public void SapNumber()
        {
            Assert.AreEqual(_sapNumber, View.SapNumber);
        }

        [Test]
        public void SbsDebitNumberPattern()
        {
            StringAssert.IsMatch(View.SbsDebitNumber, new Regex(TestRegExpPatterns.SbsDebitorNo));
        }

        [Test]
        public void SbsAdressNumberPattern()
        {
            StringAssert.IsMatch(View.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNoOpt));
        }

        [Test]
        public void Ep2MerchantIdPattern()
        {
            StringAssert.IsMatch(View.Ep2MerchantId, new Regex(TestRegExpPatterns.Ep2MerchantId));
        }

        [Test]
        public void SbsDebitNumber()
        {
            Assert.AreEqual(_sbsDebitNumber, View.SbsDebitNumber);
        }

        [Test]
        public void SbsAdressNumber()
        {
            Assert.AreEqual(_sbsAdressNumber, View.SbsAdressNumber);
        }

        [Test]
        public void Ep2MerchantId()
        {
            Assert.AreEqual(_ep2MerchantId, View.Ep2MerchantId);
        }

        [Test]
        public void CompanyName()
        {
            Assert.AreEqual(_companyName, View.CompanyName);
        }

        [Test]
        public void Po()
        {
            Assert.AreEqual(_po, View.Po);
        }

        [Test]
        public void AdressAddition()
        {
            Assert.AreEqual(_adressAddition, View.AdressAddition);
        }

        [Test]
        public void StreetNo()
        {
            Assert.AreEqual(_streetName, View.StreetNo);
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
        public void Language()
        {
            Assert.AreEqual(_language, View.Language);
        }

        [Test]
        public void Country()
        {
            Assert.AreEqual(_country, View.Country);
        }

        [Test]
        public void Email()
        {
            Assert.AreEqual(_email, View.Email);
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
        public void Web()
        {
            Assert.AreEqual(_web, View.Web);
        }
    }
}