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
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_ZIP")).TypeText(
                    value);
            }
        }

        public string City
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_City")).TypeText(value);
            }
        }

        public string AdressAddition
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_AddressAddition"))
                    .TypeText(value);
            }
        }

        public string Po
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_PO")).TypeText(value);
            }
        }

        public string Region
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_Region")).TypeText(value);
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
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_Mobile")).
                    TypeText(
                        value);
            }
        }

        public string Fax
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_Fax")).TypeText(value);
            }
        }

        public string Email
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_Email")).TypeText(value);
            }
        }


        public string CompanyName
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_LocationName")).TypeText(value);
            }
        }


        public string StreetName
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_Street")).TypeText(value);
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
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_Web")).TypeText(value);
            }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector("input[value=\"Speichern\"]")); }
        }
    }
}