using System;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Location
{
    public class LocationView : WebObject
    {
        public static IWebElement EditButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input#edit")); }
        }

        public static string CompanyName
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.CompanyName)).Text; }
        }

        public static string Guid
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.GUID)).Text; }
        }

        public static string StreetNo
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.StreetName)).Text; }
        }

        public static string Zip
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Zip)).Text; }
        }

        public static string City
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.City)).Text; }
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
        }

        public static string Country
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Country)).Text; }
        }

        public static string Ep2MerchantId
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Ep2MerchantId)).Text; }
        }

        public static string SapNumber
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.SapNumber)).Text; }
        }

        public static string Po
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Po)).Text; }
        }

        public static string AdressAddition
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.AdressAddition)).Text; }
        }

        public static string Email
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Email)).Text; }
        }

        public static string Web
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Web)).Text; }
        }

        public static string Telephone
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Telephone)).Text; }
        }

        public static string Mobile
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Mobile)).Text; }
        }

        public static string Fax
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Fax)).Text; }
        }

        public static string Region
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.Region)).Text; }
        }
    }
}