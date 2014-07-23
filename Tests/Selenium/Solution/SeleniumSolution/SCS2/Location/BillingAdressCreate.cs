using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Location
{
    public class BillingAddressCreate : WebObject
    {
        public static string Country
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_CountryId")).Selector().SelectByText(value);
            }
        }

        public static string Zip
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_ZIP")).TextField().TypeText(value); }
        }

        public static string City
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_City")).TextField().TypeText(value); }
        }

        public static string AdressAddition
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_AddressAddition"))
                    .TextField().TypeText(value);
            }
        }

        public static string Po
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_PO")).TextField().TypeText(value); }
        }

        public static string Region
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Region")).TextField().TypeText(value); }
        }

        public static string Telephone
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Telephone")).TextField().TypeText(value);
            }
        }

        public static string Mobile
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Mobile")).TextField().TypeText(value); }
        }

        public static string Fax
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Fax")).TextField().TypeText(value); }
        }

        public static string Email
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Email")).TextField().TypeText(value); }
        }

        public static string CompanyName
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_LocationName")).TextField().TypeText(value);
            }
        }

        public static string StreetName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Street")).TextField().TypeText(value); }
        }

        public static string Language
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_LanguageId")).Selector().SelectByText(value);
            }
        }

        public static string Web
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Web")).TextField().TypeText(value); }
        }

        public static IWebElementAdapter SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input[value=\"Speichern\"]")); }
        }
    }
}