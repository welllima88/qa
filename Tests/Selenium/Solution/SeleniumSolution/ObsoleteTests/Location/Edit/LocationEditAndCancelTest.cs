﻿using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Location;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Location.Edit
{
    [TestClass]
    public class LocationEditAndCancelTest
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

        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Location/?LOCATIONID=071b90c2-c8c5-42c5-87c5-d816b26b0a1a");
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

            Selenium.Location.Edit.CompanyName = "SYR Sele Firma AAA";
            Selenium.Location.Edit.StreetNo = "Hardturmstr. 2011";
            Selenium.Location.Edit.Zip = "80222";
            Selenium.Location.Edit.City = "Zürichhh";
            Selenium.Location.Edit.Po = "PFO111";
            Selenium.Location.Edit.AdressAddition = "Etage 333";
            Selenium.Location.Edit.Region = "Reggg";
            Selenium.Location.Edit.SapNumber = "4449";

            Selenium.Location.Edit.Language = "Kroatisch [hr]";
            Selenium.Location.Edit.Country = "Albanien [AL]";
            Selenium.Location.Edit.Email = "marc.siegmund@six-group.com";
            Selenium.Location.Edit.Telephone = "0031 58 399 623777";
            Selenium.Location.Edit.Mobile = "0032 58 399 623777";
            Selenium.Location.Edit.Fax = "0033 58 399 623777";
            Selenium.Location.Edit.Web = "www.six-group.com/de-internnnn";

            Selenium.Location.Edit.CancelButton.Click();
        }

        [TestMethod]
        public void Guid()
        {
            Assert.AreEqual(_guid, View.Guid);
        }

        [TestMethod]
        public void SapNumber()
        {
            Assert.AreEqual(_sapNumber, View.SapNumber);
        }

        [TestMethod]
        public void SbsDebitNumberPattern()
        {
            StringAssert.Matches(View.SbsDebitNumber, new Regex(TestRegExpPatterns.SbsDebitorNo));
        }

        [TestMethod]
        public void SbsAdressNumberPattern()
        {
            StringAssert.Matches(View.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNoOpt));
        }

        [TestMethod]
        public void Ep2MerchantIdPattern()
        {
            StringAssert.Matches(View.Ep2MerchantId, new Regex(TestRegExpPatterns.Ep2MerchantId));
        }

        [TestMethod]
        public void SbsDebitNumber()
        {
            Assert.AreEqual(_sbsDebitNumber, View.SbsDebitNumber);
        }

        [TestMethod]
        public void SbsAdressNumber()
        {
            Assert.AreEqual(_sbsAdressNumber, View.SbsAdressNumber);
        }

        [TestMethod]
        public void Ep2MerchantId()
        {
            Assert.AreEqual(_ep2MerchantId, View.Ep2MerchantId);
        }

        [TestMethod]
        public void CompanyName()
        {
            Assert.AreEqual(_companyName, View.CompanyName);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual(_po, View.Po);
        }

        [TestMethod]
        public void AdressAddition()
        {
            Assert.AreEqual(_adressAddition, View.AdressAddition);
        }

        [TestMethod]
        public void StreetNo()
        {
            Assert.AreEqual(_streetName, View.StreetNo);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual(_zip, View.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual(_city, View.City);
        }

        [TestMethod]
        public void Language()
        {
            Assert.AreEqual(_language, View.Language);
        }

        [TestMethod]
        public void Country()
        {
            Assert.AreEqual(_country, View.Country);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual(_email, View.Email);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual(_telephone, View.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual(_mobile, View.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual(_fax, View.Fax);
        }

        [TestMethod]
        public void Web()
        {
            Assert.AreEqual(_web, View.Web);
        }
    }
}