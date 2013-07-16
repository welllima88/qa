using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location
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
        }

        public string Guid
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.GUID)).Text; }
        }

        public string StreetName
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.StreetName)).Text; }
        }

        public string Zip
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Zip)).Text; }
        }

        public string City
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.City)).Text; }
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
        }

        public string Country
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Country)).Text; }
        }

        public string Ep2MerchantId
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Ep2MerchantId)).Text; }
        }

        public string SapNumber
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.SapNumber)).Text; }
        }

        public string Po
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Po)).Text; }
        }

        public string AdressAddition
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.AdressAddition)).Text; }
        }

        public string Email
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Email)).Text; }
        }

        public string Web
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Web)).Text; }
        }

        public string Telephone
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Telephone)).Text; }
        }

        public string Mobile
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Mobile)).Text; }
        }

        public string Fax
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Fax)).Text; }
        }

        public string Region
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Region)).Text; }
        }

        #endregion
    }
}