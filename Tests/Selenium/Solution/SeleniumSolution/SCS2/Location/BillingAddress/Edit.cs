using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Location.BillingAddress
{
    public class Edit : WebObject
    {
        public static string CompanyName
        {
            set { BillingAddress.Create.CompanyName = value; }
        }

        public static string StreetName
        {
            set { BillingAddress.Create.StreetName = value; }
        }

        public static string Language
        {
            set { BillingAddress.Create.Language = value; }
        }

        public static string Country
        {
            set { BillingAddress.Create.Country = value; }
        }

        public static string Zip
        {
            set { BillingAddress.Create.Zip = value; }
        }

        public static string City
        {
            set { BillingAddress.Create.City = value; }
        }

        public static string AdressAddition
        {
            set { BillingAddress.Create.AdressAddition = value; }
        }

        public static string Po
        {
            set { BillingAddress.Create.Po = value; }
        }

        public static string Region
        {
            set { BillingAddress.Create.Region = value; }
        }

        public static string Telephone
        {
            set { BillingAddress.Create.Telephone = value; }
        }

        public static string Mobile
        {
            set { BillingAddress.Create.Mobile = value; }
        }

        public static string Fax
        {
            set { BillingAddress.Create.Fax = value; }
        }

        public static string Email
        {
            set { BillingAddress.Create.Email = value; }
        }

        public static string Web
        {
            set { BillingAddress.Create.Web = value; }
        }

        public static IWebElementAdapter SaveButton
        {
            get { return BillingAddress.Create.SaveButton; }
        }

        public static IWebElementAdapter CancelButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button[name='cancel']")); }
        }
    }
}