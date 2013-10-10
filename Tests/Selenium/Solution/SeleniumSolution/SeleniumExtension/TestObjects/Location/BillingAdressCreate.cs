using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Location
{
    public class BillingAddressCreate : WebObject
    {
        public static string Country
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_CountryId")).Selector().SelectByText(value); }
        }

        public static string Zip
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_ZIP")).TypeText(
                    value);
            }
        }

        public static string City
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_City")).TypeText(value); }
        }

        public static string AdressAddition
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_AddressAddition"))
                         .TypeText(value);
            }
        }

        public static string Po
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_PO")).TypeText(value); }
        }

        public static string Region
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Region")).TypeText(value); }
        }

        public static string Telephone
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Telephone")).
                          TypeText(value);
            }
        }

        public static string Mobile
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Mobile")).
                          TypeText(
                              value);
            }
        }

        public static string Fax
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Fax")).TypeText(value); }
        }

        public static string Email
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Email")).TypeText(value); }
        }

        public static string CompanyName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_LocationName")).TypeText(value); }
        }

        public static string StreetName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Street")).TypeText(value); }
        }

        public static string Language
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_LanguageId")).Selector().SelectByText(value); }
        }

        public static string Web
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Web")).TypeText(value); }
        }

        public static IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input[value=\"Speichern\"]")); }
        }
    }
}