using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location
{
    public class BillingAddressCreate : WebObject
    {
        public BillingAddressCreate(IWebDriverAdapter driver) : base(driver)
        {
        }

        public string Country
        {
            set { Driver.FindAdaptedElement(By.CssSelector("#BillingAddress_CountryId")).Selector().SelectByText(value); }
        }

        public string Zip
        {
            set
            {
                Driver.FindElement(By.CssSelector("#BillingAddress_ZIP")).Clear();
                Driver.FindElement(By.CssSelector("#BillingAddress_ZIP")).SendKeys(
                    value);
            }
        }

        public string City
        {
            set
            {
                Driver.FindElement(By.CssSelector("#BillingAddress_City")).Clear();
                Driver.FindElement(By.CssSelector("#BillingAddress_City")).SendKeys
                    (
                        value);
            }
        }

        public string AdressAddition
        {
            set
            {
                Driver.FindElement(By.CssSelector("#BillingAddress_AddressAddition"))
                    .
                    Clear();
                Driver.FindElement(By.CssSelector("#BillingAddress_AddressAddition"))
                    .
                    SendKeys(
                        value);
            }
        }

        public string Po
        {
            set
            {
                Driver.FindElement(By.CssSelector("#BillingAddress_PO")).Clear();
                Driver.FindElement(By.CssSelector("#BillingAddress_PO")).SendKeys(
                    value);
            }
        }

        public string Region
        {
            set
            {
                Driver.FindElement(By.CssSelector("#BillingAddress_Region")).Clear();
                Driver.FindElement(By.CssSelector("#BillingAddress_Region")).
                    SendKeys(
                        value);
            }
        }

        public string Telephone
        {
            set
            {
                Driver.FindElement(By.CssSelector("#BillingAddress_Telephone")).
                    Clear();
                Driver.FindElement(By.CssSelector("#BillingAddress_Telephone")).
                    SendKeys(
                        value);
            }
        }

        public string Mobile
        {
            set
            {
                Driver.FindElement(By.CssSelector("#BillingAddress_Mobile")).
                    Clear();
                Driver.FindElement(By.CssSelector("#BillingAddress_Mobile")).
                    SendKeys(
                        value);
            }
        }

        public string Fax
        {
            set
            {
                Driver.FindElement(By.CssSelector("#BillingAddress_Fax")).Clear();
                Driver.FindElement(By.CssSelector("#BillingAddress_Fax")).SendKeys(
                    value);
            }
        }

        public string Email
        {
            set
            {
                Driver.FindElement(By.CssSelector("#BillingAddress_Email")).Clear();
                Driver.FindElement(By.CssSelector("#BillingAddress_Email")).
                    SendKeys(value);
            }
        }


        public string CompanyName
        {
            set
            {
                Driver.FindElement(By.CssSelector("#BillingAddress_LocationName")).Clear();
                Driver.FindElement(By.CssSelector("#BillingAddress_LocationName")).SendKeys(value);
            }
        }


        public string StreetName
        {
            set
            {
                Driver.FindElement(By.CssSelector("#BillingAddress_Street")).
                    Clear();
                Driver.FindElement(By.CssSelector("#BillingAddress_Street")).
                    SendKeys(
                        value);
            }
        }

        public string Language
        {
            set { Driver.FindAdaptedElement(By.CssSelector("#BillingAddress_LanguageId")).Selector().SelectByText(value); }
        }

        public string Web
        {
            set
            {
                Driver.FindElement(By.CssSelector("#BillingAddress_Web")).Clear();
                Driver.FindElement(By.CssSelector("#BillingAddress_Web")).SendKeys(
                    value);
            }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector("input[value=\"Speichern\"]")); }
        }
    }
}