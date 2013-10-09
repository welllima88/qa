using System;
using OpenQA.Selenium;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Definitions;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Location
{
    public class LocationView : WebObject, ILocation
    {
        #region ILocationView Members

        public IWebElement EditButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEdit")); }
        }

        public string CompanyName
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.CompanyName)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Guid
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.GUID)).Text; }
        }

        public string StreetNo
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.StreetName)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Zip
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Zip)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string City
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.City)).Text; }
            set { throw new NotSupportedException(); }
        }

        public String SbsDebitNumber
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.SbsDebitNumber)).Text; }
        }

        public String SbsAdressNumber
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.SbsAdressNumber)).Text; }
        }

        public string Language
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Language)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Country
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Country)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Ep2MerchantId
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Ep2MerchantId)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string SapNumber
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.SapNumber)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Po
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Po)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string AdressAddition
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.AdressAddition)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Email
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Email)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Web
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Web)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Telephone
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Telephone)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Mobile
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Mobile)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Fax
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Fax)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Region
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Region)).Text; }
            set { throw new NotSupportedException(); }
        }

        #endregion
    }
}