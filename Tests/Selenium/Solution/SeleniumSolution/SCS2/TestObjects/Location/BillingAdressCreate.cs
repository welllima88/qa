using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Location
{
    public class BillingAddressCreate : WebObject
    {
        public string Country
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_CountryId")).Selector().SelectByText(value); }
        }

        public string Zip
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_ZIP")).TypeText(
                    value);
            }
        }

        public string City
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_City")).TypeText(value); }
        }

        public string AdressAddition
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_AddressAddition"))
                         .TypeText(value);
            }
        }

        public string Po
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_PO")).TypeText(value); }
        }

        public string Region
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Region")).TypeText(value); }
        }

        public string Telephone
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Telephone")).
                          TypeText(value);
            }
        }

        public string Mobile
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Mobile")).
                          TypeText(
                              value);
            }
        }

        public string Fax
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Fax")).TypeText(value); }
        }

        public string Email
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Email")).TypeText(value); }
        }

        public string CompanyName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_LocationName")).TypeText(value); }
        }

        public string StreetName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Street")).TypeText(value); }
        }

        public string Language
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_LanguageId")).Selector().SelectByText(value); }
        }

        public string Web
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#BillingAddress_Web")).TypeText(value); }
        }

        public IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input[value=\"Speichern\"]")); }
        }
    }
}