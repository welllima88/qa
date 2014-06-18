using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Person
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
        }

        public static string Name
        {
            get { return WebDriver.FindElement(By.CssSelector(PersonViewRes.Name)).Text; }
        }

        public static string Salutation
        {
            get { return WebDriver.FindElement(By.CssSelector(PersonViewRes.Salutation)).Text; }
        }

        public static string Country
        {
            get { return WebDriver.FindElement(By.CssSelector(PersonViewRes.Country)).Text; }
        }

        public static string Language
        {
            get { return WebDriver.FindElement(By.CssSelector(PersonViewRes.Language)).Text; }
        }

        public static string Telephone
        {
            get { return WebDriver.FindElement(By.CssSelector(PersonViewRes.Telephone)).Text; }
        }

        public static string Mobile
        {
            get { return WebDriver.FindElement(By.CssSelector(PersonViewRes.Mobile)).Text; }
        }

        public static string Fax
        {
            get { return WebDriver.FindElement(By.CssSelector(PersonViewRes.Fax)).Text; }
        }

        public static string Email
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_Email")).Text; }
        }

        public static string Web
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_Web")).Text; }
        }

        public static string StreetNo
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_Street")).Text; }
        }

        public string AdressAddition { get; set; }

        public static string Po
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_PO")).Text; }
        }

        public static string Zip
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_ZIP")).Text; }
        }

        public static string City
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_City")).Text; }
        }

        public static string Region
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_Region")).Text; }
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