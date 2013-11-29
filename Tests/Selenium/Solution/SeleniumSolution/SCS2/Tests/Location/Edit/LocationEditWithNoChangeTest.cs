﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Edit
{
    [TestClass]
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

        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Location?LocationId=4b77d4f2-d5db-4823-9d52-63c1534de457");
            _guid = LocationView.Guid;

            _sapNumber = LocationView.SapNumber;
            _sbsDebitNumber = LocationView.SbsDebitNumber;
            _sbsAdressNumber = LocationView.SbsAdressNumber;

            _ep2MerchantId = LocationView.Ep2MerchantId;

            _companyName = LocationView.CompanyName;
            _po = LocationView.Po;
            _adressAddition = LocationView.AdressAddition;
            _streetName = LocationView.StreetNo;
            _zip = LocationView.Zip;
            _city = LocationView.City;
            _language = LocationView.Language;
            _country = LocationView.Country;
            _email = LocationView.Email;
            _telephone = LocationView.Telephone;
            _mobile = LocationView.Mobile;
            _fax = LocationView.Fax;
            _web = LocationView.Web;

            LocationMenu.LocationEdit.Click();

            LocationEdit.SaveButton.Click();
        }

        [TestMethod]
        public void Guid()
        {
            Assert.AreEqual(_guid, LocationView.Guid);
        }

        [TestMethod]
        public void SapNumber()
        {
            Assert.AreEqual(_sapNumber, LocationView.SapNumber);
        }

        [TestMethod]
        public void SbsDebitNumberPattern()
        {
            StringAssert.Matches(LocationView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
        }

        [TestMethod]
        public void SbsAdressNumberPattern()
        {
            StringAssert.Matches(LocationView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
        }

        [TestMethod]
        public void Ep2MerchantIdPattern()
        {
            StringAssert.Matches(LocationView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);
        }

        [TestMethod]
        public void SbsDebitNumber()
        {
            Assert.AreEqual(_sbsDebitNumber, LocationView.SbsDebitNumber);
        }

        [TestMethod]
        public void SbsAdressNumber()
        {
            Assert.AreEqual(_sbsAdressNumber, LocationView.SbsAdressNumber);
        }

        [TestMethod]
        public void Ep2MerchantId()
        {
            Assert.AreEqual(_ep2MerchantId, LocationView.Ep2MerchantId);
        }

        [TestMethod]
        public void CompanyName()
        {
            Assert.AreEqual(_companyName, LocationView.CompanyName);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual(_po, LocationView.Po);
        }

        [TestMethod]
        public void AdressAddition()
        {
            Assert.AreEqual(_adressAddition, LocationView.AdressAddition);
        }

        [TestMethod]
        public void StreetNo()
        {
            Assert.AreEqual(_streetName, LocationView.StreetNo);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual(_zip, LocationView.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual(_city, LocationView.City);
        }

        [TestMethod]
        public void Language()
        {
            Assert.AreEqual(_language, LocationView.Language);
        }

        [TestMethod]
        public void Country()
        {
            Assert.AreEqual(_country, LocationView.Country);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual(_email, LocationView.Email);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual(_telephone, LocationView.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual(_mobile, LocationView.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual(_fax, LocationView.Fax);
        }

        [TestMethod]
        public void Web()
        {
            Assert.AreEqual(_web, LocationView.Web);
        }
    }
}