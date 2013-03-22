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
                Driver.FindAdaptedElement(By.CssSelector("#BillingAddress_ZIP")).TypeText(
                    value);
            }
        }

        public string City
        {
            set { Driver.FindAdaptedElement(By.CssSelector("#BillingAddress_City")).TypeText(value); }
        }

        public string AdressAddition
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("#BillingAddress_AddressAddition"))
                    .TypeText(value);
            }
        }

        public string Po
        {
            set { Driver.FindAdaptedElement(By.CssSelector("#BillingAddress_PO")).TypeText(value); }
        }

        public string Region
        {
            set { Driver.FindAdaptedElement(By.CssSelector("#BillingAddress_Region")).TypeText(value); }
        }

        public string Telephone
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("#BillingAddress_Telephone")).
                    TypeText(value);
            }
        }

        public string Mobile
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("#BillingAddress_Mobile")).
                    TypeText(
                        value);
            }
        }

        public string Fax
        {
            set { Driver.FindAdaptedElement(By.CssSelector("#BillingAddress_Fax")).TypeText(value); }
        }

        public string Email
        {
            set { Driver.FindAdaptedElement(By.CssSelector("#BillingAddress_Email")).TypeText(value); }
        }


        public string CompanyName
        {
            set { Driver.FindAdaptedElement(By.CssSelector("#BillingAddress_LocationName")).TypeText(value); }
        }


        public string StreetName
        {
            set { Driver.FindAdaptedElement(By.CssSelector("#BillingAddress_Street")).TypeText(value); }
        }

        public string Language
        {
            set { Driver.FindAdaptedElement(By.CssSelector("#BillingAddress_LanguageId")).Selector().SelectByText(value); }
        }

        public string Web
        {
            set { Driver.FindAdaptedElement(By.CssSelector("#BillingAddress_Web")).TypeText(value); }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector("input[value=\"Speichern\"]")); }
        }
    }
}