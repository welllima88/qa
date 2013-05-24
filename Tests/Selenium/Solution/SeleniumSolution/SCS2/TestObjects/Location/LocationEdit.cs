using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location
{
    public class LocationEdit : WebObject, ILocationEdit
    {
        private readonly LocationCreate _locationCreate;
        private readonly LocationView _locationView;

        public LocationEdit(IWebDriverAdapter driver) : base(driver)
        {
            _locationCreate = new LocationCreate(Driver);
            _locationView = new LocationView(Driver);
        }

        #region ILocationEdit Members

        public string SapNumber
        {
            set { _locationCreate.SapNumber = value; }
        }

        public string CompanyName
        {
            set { _locationCreate.CompanyName = value; }
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
        }

        public string Language
        {
            set { _locationCreate.Language = value; }
        }

        public string Country
        {
            set { _locationCreate.Country = value; }
        }

        public string Zip
        {
            set { _locationCreate.Zip = value; }
        }

        public string City
        {
            set { _locationCreate.City = value; }
        }

        public string AdressAddition
        {
            set { _locationCreate.AdressAddition = value; }
        }

        public string Po
        {
            set { _locationCreate.Po = value; }
        }

        public string Region
        {
            set { _locationCreate.Region = value; }
        }

        public string Telephone
        {
            set { _locationCreate.Telephone = value; }
        }

        public string Mobile
        {
            set { _locationCreate.Mobile = value; }
        }

        public string Fax
        {
            set { _locationCreate.Fax = value; }
        }

        public string Email
        {
            set { _locationCreate.Email = value; }
        }

        public string Web
        {
            set { _locationCreate.Web = value; }
        }

        public IWebElement SaveButton
        {
            get { return _locationCreate.SaveButton; }
        }

        public IWebElement CancelButton
        {
            get { return Driver.FindElement(By.CssSelector("button[name='cancel']")); }
        }

        public string Guid
        {
            get { return Driver.FindElement(By.CssSelector(Location.GUID)).Text; }
        }

        #endregion
    }
}