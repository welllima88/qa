using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Location
{
    public class BillingAddressEdit : WebObject
    {
        public static string CompanyName
        {
            set { BillingAddressCreate.CompanyName = value; }
        }

        public static string StreetName
        {
            set { BillingAddressCreate.StreetName = value; }
        }

        public static string Language
        {
            set { BillingAddressCreate.Language = value; }
        }

        public static string Country
        {
            set { BillingAddressCreate.Country = value; }
        }

        public static string Zip
        {
            set { BillingAddressCreate.Zip = value; }
        }

        public static string City
        {
            set { BillingAddressCreate.City = value; }
        }

        public static string AdressAddition
        {
            set { BillingAddressCreate.AdressAddition = value; }
        }

        public static string Po
        {
            set { BillingAddressCreate.Po = value; }
        }

        public static string Region
        {
            set { BillingAddressCreate.Region = value; }
        }

        public static string Telephone
        {
            set { BillingAddressCreate.Telephone = value; }
        }

        public static string Mobile
        {
            set { BillingAddressCreate.Mobile = value; }
        }

        public static string Fax
        {
            set { BillingAddressCreate.Fax = value; }
        }

        public static string Email
        {
            set { BillingAddressCreate.Email = value; }
        }

        public static string Web
        {
            set { BillingAddressCreate.Web = value; }
        }

        public static IWebElement SaveButton
        {
            get { return BillingAddressCreate.SaveButton; }
        }

        public static IWebElement CancelButton
        {
            get { return WebDriver.FindElement(By.CssSelector("button[name='cancel']")); }
        }
    }
}