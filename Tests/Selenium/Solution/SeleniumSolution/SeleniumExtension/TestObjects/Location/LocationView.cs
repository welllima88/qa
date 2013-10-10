using System;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Location
{
    public class LocationView : WebObject
    {
        #region ILocationView Members

        public IWebElement EditButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEdit")); }
        }

        public static string CompanyName
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.CompanyName)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Guid
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.GUID)).Text; }
        }

        public static string StreetNo
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.StreetName)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Zip
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Zip)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string City
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.City)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static String SbsDebitNumber
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.SbsDebitNumber)).Text; }
        }

        public static String SbsAdressNumber
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.SbsAdressNumber)).Text; }
        }

        public static string Language
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Language)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Country
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Country)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Ep2MerchantId
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Ep2MerchantId)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string SapNumber
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.SapNumber)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Po
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Po)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string AdressAddition
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.AdressAddition)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Email
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Email)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Web
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Web)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Telephone
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Telephone)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Mobile
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Mobile)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Fax
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Fax)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Region
        {
            get { return WebDriver.FindElement(By.CssSelector(Location.Region)).Text; }
            set { throw new NotSupportedException(); }
        }

        #endregion
    }
}