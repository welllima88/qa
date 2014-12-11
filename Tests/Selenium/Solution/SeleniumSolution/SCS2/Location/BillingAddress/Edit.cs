using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Location.BillingAddress
{
    public class Edit : WebObject
    {
        public static string CompanyName
        {
            set { Create.CompanyName = value; }
        }

        public static string StreetNo
        {
            set { Create.StreetNo = value; }
        }

        public static string Language
        {
            set { Create.Language = value; }
        }

        public static string Country
        {
            set { Create.Country = value; }
        }

        public static string Zip
        {
            set { Create.Zip = value; }
        }

        public static string City
        {
            set { Create.City = value; }
        }

        public static string AdressAddition
        {
            set { Create.AdressAddition = value; }
        }

        public static string Po
        {
            set { Create.Po = value; }
        }

        public static string Region
        {
            set { Create.Region = value; }
        }

        public static string Telephone
        {
            set { Create.Telephone = value; }
        }

        public static string Mobile
        {
            set { Create.Mobile = value; }
        }

        public static string Fax
        {
            set { Create.Fax = value; }
        }

        public static string Email
        {
            set { Create.Email = value; }
        }

        public static string Web
        {
            set { Create.Web = value; }
        }

        public static IWebElementAdapter SaveButton
        {
            get { return Create.SaveButton; }
        }

        public static IWebElementAdapter CancelButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button[name='cancel']")); }
        }
    }
}