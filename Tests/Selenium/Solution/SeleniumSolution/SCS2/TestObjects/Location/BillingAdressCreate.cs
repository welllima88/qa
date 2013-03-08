using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location
{
    public class BillingAddressCreate : WebObject
    {
        public BillingAddressCreate(IWebDriverAdapter driver) : base(driver)
        {
            Prefix = "#BillingAddress";
        }

        public string Country
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Prefix + "_CountryId")).Selector().SelectByText(value); }
        }

        public string Zip
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix + "_ZIP")).Clear();
                Driver.FindElement(By.CssSelector(Prefix + "_ZIP")).SendKeys(
                    value);
            }
        }

        public string City
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix + "_City")).Clear();
                Driver.FindElement(By.CssSelector(Prefix + "_City")).SendKeys
                    (
                        value);
            }
        }

        public string AdressAddition
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix + "_AddressAddition"))
                    .
                    Clear();
                Driver.FindElement(By.CssSelector(Prefix + "_AddressAddition"))
                    .
                    SendKeys(
                        value);
            }
        }

        public string Po
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix + "_PO")).Clear();
                Driver.FindElement(By.CssSelector(Prefix + "_PO")).SendKeys(
                    value);
            }
        }

        public string Region
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix + "_Region")).Clear();
                Driver.FindElement(By.CssSelector(Prefix + "_Region")).
                    SendKeys(
                        value);
            }
        }

        public string Telephone
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix + "_Telephone")).
                    Clear();
                Driver.FindElement(By.CssSelector(Prefix + "_Telephone")).
                    SendKeys(
                        value);
            }
        }

        public string Mobile
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix + "_Mobile")).
                    Clear();
                Driver.FindElement(By.CssSelector(Prefix + "_Mobile")).
                    SendKeys(
                        value);
            }
        }

        public string Fax
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix + "_Fax")).Clear();
                Driver.FindElement(By.CssSelector(Prefix + "_Fax")).SendKeys(
                    value);
            }
        }

        public string Email
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix + "_Email")).Clear();
                Driver.FindElement(By.CssSelector(Prefix + "_Email")).
                    SendKeys(value);
            }
        }


        public string CompanyName
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix + "_LocationName")).Clear();
                Driver.FindElement(By.CssSelector(Prefix + "_LocationName")).SendKeys(value);
            }
        }


        public string StreetName
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix + "_Street")).
                    Clear();
                Driver.FindElement(By.CssSelector(Prefix + "_Street")).
                    SendKeys(
                        value);
            }
        }

        public string Language
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Prefix + "_LanguageId")).Selector().SelectByText(value); }
        }

        public string Web
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix + "_Web")).Clear();
                Driver.FindElement(By.CssSelector(Prefix + "_Web")).SendKeys(
                    value);
            }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector("input[value=\"Speichern\"]")); }
        }
    }
}