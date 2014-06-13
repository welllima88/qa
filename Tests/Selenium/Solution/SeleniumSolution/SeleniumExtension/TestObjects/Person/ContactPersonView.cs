using System;
using OpenQA.Selenium;
using SIX.SCS.Tests.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.Tests.Selenium.Extension.TestObjects.Person
{
    public class ContactPersonView : WebObject
    {
        public static IWebElement EditButton
        {
            get { return WebDriver.FindElement(By.CssSelector("button[name='edit']")); }
        }

        public static string AddressAddition
        {
            get { return WebDriver.FindElement(By.Id("Address_AddressAddition")).Text; }
        }

        public static string FirstName
        {
            get { return WebDriver.FindElement(By.CssSelector(PersonViewRes.FirstName)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Name
        {
            get { return WebDriver.FindElement(By.CssSelector(PersonViewRes.Name)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Salutation
        {
            get { return WebDriver.FindElement(By.CssSelector(PersonViewRes.Salutation)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Country
        {
            get { return WebDriver.FindElement(By.CssSelector(PersonViewRes.Country)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Language
        {
            get { return WebDriver.FindElement(By.CssSelector(PersonViewRes.Language)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Telephone
        {
            get { return WebDriver.FindElement(By.CssSelector(PersonViewRes.Telephone)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Mobile
        {
            get { return WebDriver.FindElement(By.CssSelector(PersonViewRes.Mobile)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Fax
        {
            get { return WebDriver.FindElement(By.CssSelector(PersonViewRes.Fax)).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Email
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_Email")).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Web
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_Web")).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string StreetNo
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_Street")).Text; }
            set { throw new NotSupportedException(); }
        }

        public string AdressAddition { get; set; }

        public static string Po
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_PO")).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Zip
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_ZIP")).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string City
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_City")).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string Region
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_Region")).Text; }
            set { throw new NotSupportedException(); }
        }

        public static IWebElement DeleteButton
        {
            get { return WebDriver.FindElement(By.CssSelector("button#delete")); }
        }

        public static void DeleteConfirm()
        {
            WebDriver.SwitchTo().Alert().Accept();
        }
    }
}