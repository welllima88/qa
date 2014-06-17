using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Location
{
    public class BillingAddressView : WebObject
    {
        public static string CompanyName
        {
            get { return WebDriver.FindElement(By.CssSelector("#LocationData_LocationName")).Text; }
        }

        public static string StreetName
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#LocationData_Street"))
                        .Text;
            }
        }

        public static string Zip
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#LocationData_ZIP")).Text;
            }
        }

        public static string City
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#LocationData_City")).Text;
            }
        }

        public static string Language
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#LocationData_LanguageId")).Text;
            }
        }

        public static string Country
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#LocationData_CountryId")).Text;
            }
        }

        public static string Po
        {
            get { return WebDriver.FindElement(By.CssSelector("#LocationData_PO")).Text; }
        }

        public static string AdressAddition
        {
            get { return WebDriver.FindElement(By.CssSelector("#LocationData_AddressAddition")).Text; }
        }

        public static string Email
        {
            get { return WebDriver.FindElement(By.CssSelector("#LocationData_Email")).Text; }
        }

        public static string Web
        {
            get { return WebDriver.FindElement(By.CssSelector("#LocationData_Web")).Text; }
        }

        public static string Telephone
        {
            get { return WebDriver.FindElement(By.CssSelector("#LocationData_Telephone")).Text; }
        }

        public static string Mobile
        {
            get { return WebDriver.FindElement(By.CssSelector("#LocationData_Mobile")).Text; }
        }

        public static string Fax
        {
            get { return WebDriver.FindElement(By.CssSelector("#LocationData_Fax")).Text; }
        }

        public static IWebElement EditButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEdit")); }
        }
    }
}