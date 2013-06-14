using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location
{
    public class LocationView : WebObject, ILocation
    {
        public LocationView(IWebDriverAdapter driver) : base(driver)
        {
        }

        #region ILocationView Members

        public string CompanyName
        {
            get { return Driver.FindElement(By.CssSelector(Location.CompanyName)).Text; }
        }

        public string Guid
        {
            get { return Driver.FindElement(By.CssSelector(Location.GUID)).Text; }
        }

        public string StreetName
        {
            get { return Driver.FindElement(By.CssSelector(Location.StreetName)).Text; }
        }

        public string Zip
        {
            get { return Driver.FindElement(By.CssSelector(Location.Zip)).Text; }
        }

        public string City
        {
            get { return Driver.FindElement(By.CssSelector(Location.City)).Text; }
        }

        public String SbsDebitNumber
        {
            get { return Driver.FindElement(By.CssSelector(Location.SbsDebitNumber)).Text; }
        }

        public String SbsAdressNumber
        {
            get { return Driver.FindElement(By.CssSelector(Location.SbsAdressNumber)).Text; }
        }


        public string Language
        {
            get { return Driver.FindElement(By.CssSelector(Location.Language)).Text; }
        }

        public string Country
        {
            get { return Driver.FindElement(By.CssSelector(Location.Country)).Text; }
        }

        public string Ep2MerchantId
        {
            get { return Driver.FindElement(By.CssSelector(Location.Ep2MerchantId)).Text; }
        }

        public string SapNumber
        {
            get { return Driver.FindElement(By.CssSelector(Location.SapNumber)).Text; }
        }

        public string Po
        {
            get { return Driver.FindElement(By.CssSelector(Location.Po)).Text; }
        }

        public string AdressAddition
        {
            get { return Driver.FindElement(By.CssSelector(Location.AdressAddition)).Text; }
        }

        public string Email
        {
            get { return Driver.FindElement(By.CssSelector(Location.Email)).Text; }
        }

        public string Web
        {
            get { return Driver.FindElement(By.CssSelector(Location.Web)).Text; }
        }

        public string Telephone
        {
            get { return Driver.FindElement(By.CssSelector(Location.Telephone)).Text; }
        }

        public string Mobile
        {
            get { return Driver.FindElement(By.CssSelector(Location.Mobile)).Text; }
        }

        public string Fax
        {
            get { return Driver.FindElement(By.CssSelector(Location.Fax)).Text; }
        }

        public string Region
        {
            get { return Driver.FindElement(By.CssSelector(Location.Region)).Text; }
        }

        public IWebElement EditButton
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEdit")); }
        }

        #endregion
    }
}