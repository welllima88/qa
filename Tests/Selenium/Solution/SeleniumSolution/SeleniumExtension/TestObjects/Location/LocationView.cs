using System;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Location
{
    public class LocationView : WebObject
    {
        #region ILocationView Members

        public static IWebElement EditButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input#edit")); }
        }

        public static string CompanyName
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.CompanyName)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Guid
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.GUID)).Text; }
        }

        public static string StreetNo
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.StreetName)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Zip
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Zip)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string City
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.City)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static String SbsDebitNumber
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.SbsDebitNumber)).Text; }
        }

        public static String SbsAdressNumber
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.SbsAdressNumber)).Text; }
        }

        public static string Language
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Language)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Country
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Country)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Ep2MerchantId
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Ep2MerchantId)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string SapNumber
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.SapNumber)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Po
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Po)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string AdressAddition
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.AdressAddition)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Email
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Email)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Web
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Web)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Telephone
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Telephone)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Mobile
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Mobile)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Fax
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Fax)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Region
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Region)).Text; }
            set { throw new NotSupportedException(); }
        }

        #endregion
    }
}