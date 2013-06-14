using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location
{
    public class LocationEdit : WebObject, ILocation
    {
        private readonly LocationCreate _locationCreate;
        private readonly LocationView _locationView;

        public LocationEdit(IWebDriverAdapter driver) : base(driver)
        {
            _locationCreate = new LocationCreate(Driver);
            _locationView = new LocationView(Driver);
        }

        public IWebElement SaveButton
        {
            get { return _locationCreate.SaveButton; }
        }

        public IWebElement CancelButton
        {
            get { return Driver.FindElement(By.CssSelector("button[name='cancel']")); }
        }

        #region ILocation Members

        public string SapNumber
        {
            set { _locationCreate.SapNumber = value; }
            get { return _locationCreate.SapNumber; }
        }

        public string CompanyName
        {
            set { _locationCreate.CompanyName = value; }
            get { return _locationCreate.CompanyName; }
        }

        public String SbsDebitNumber
        {
            get { return _locationView.SbsDebitNumber; }
        }

        public String SbsAdressNumber
        {
            get { return _locationView.SbsAdressNumber; }
        }


        public String Ep2MerchantId
        {
            get { return _locationView.Ep2MerchantId; }
        }

        public string StreetName
        {
            set { _locationCreate.StreetName = value; }
            get { return _locationCreate.StreetName; }
        }

        public string Language
        {
            set { _locationCreate.Language = value; }
            get { return _locationCreate.Language; }
        }

        public string Country
        {
            set { _locationCreate.Country = value; }
            get { return _locationCreate.Country; }
        }

        public string Zip
        {
            set { _locationCreate.Zip = value; }
            get { return _locationCreate.Zip; }
        }

        public string City
        {
            set { _locationCreate.City = value; }
            get { return _locationCreate.City; }
        }

        public string AdressAddition
        {
            set { _locationCreate.AdressAddition = value; }
            get { return _locationCreate.AdressAddition; }
        }

        public string Po
        {
            set { _locationCreate.Po = value; }
            get { return _locationCreate.Po; }
        }

        public string Region
        {
            set { _locationCreate.Region = value; }
            get { return _locationCreate.Region; }
        }

        public string Telephone
        {
            set { _locationCreate.Telephone = value; }
            get { return _locationCreate.Telephone; }
        }

        public string Mobile
        {
            set { _locationCreate.Mobile = value; }
            get { return _locationCreate.Mobile; }
        }

        public string Fax
        {
            set { _locationCreate.Fax = value; }
            get { return _locationCreate.Fax; }
        }

        public string Email
        {
            set { _locationCreate.Email = value; }
            get { return _locationCreate.Email; }
        }

        public string Web
        {
            set { _locationCreate.Web = value; }
            get { return _locationCreate.Web; }
        }

        public string Guid
        {
            get { return Driver.FindElement(By.CssSelector(Location.GUID)).Text; }
        }

        #endregion
    }
}