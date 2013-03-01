using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location
{
    public class LocationCreate : WebObject, ILocationCreate
    {
        public LocationCreate(IWebDriverAdapter driver) : base(driver)
        {
        }

        #region ILocationCreate Members

        public string Country
        {
            set { Driver.FindAdaptedElement(By.CssSelector("#LocationData_CountryId")).Selector().SelectByText(value); }
            get
            {
                return
                    Driver.FindAdaptedElement(By.CssSelector("#LocationData_CountryId")).Selector().SelectedOption.Text;
            }
        }

        public string Zip
        {
            set
            {
                Driver.FindElement(By.CssSelector("#LocationData_ZIP")).Clear();
                Driver.FindElement(By.CssSelector("#LocationData_ZIP")).SendKeys(
                    value);
            }
        }

        public string City
        {
            set
            {
                Driver.FindElement(By.CssSelector("#LocationData_City")).Clear();
                Driver.FindElement(By.CssSelector("#LocationData_City")).SendKeys
                    (
                        value);
            }
        }

        public string AdressAddition
        {
            set
            {
                Driver.FindElement(By.CssSelector("#LocationData_AddressAddition"))
                    .
                    Clear();
                Driver.FindElement(By.CssSelector("#LocationData_AddressAddition"))
                    .
                    SendKeys(
                        value);
            }
        }

        public string Po
        {
            set
            {
                Driver.FindElement(By.CssSelector("#LocationData_PO")).Clear();
                Driver.FindElement(By.CssSelector("#LocationData_PO")).SendKeys(
                    value);
            }
        }

        public string Region
        {
            set
            {
                Driver.FindElement(By.CssSelector("#LocationData_Region")).Clear();
                Driver.FindElement(By.CssSelector("#LocationData_Region")).
                    SendKeys(
                        value);
            }
        }

        public string Telephone
        {
            set
            {
                Driver.FindElement(By.CssSelector("#LocationData_Telephone")).
                    Clear();
                Driver.FindElement(By.CssSelector("#LocationData_Telephone")).
                    SendKeys(
                        value);
            }
        }

        public string Mobile
        {
            set
            {
                Driver.FindElement(By.CssSelector("#LocationData_Mobile")).
                    Clear();
                Driver.FindElement(By.CssSelector("#LocationData_Mobile")).
                    SendKeys(
                        value);
            }
        }

        public string Fax
        {
            set
            {
                Driver.FindElement(By.CssSelector("#LocationData_Fax")).Clear();
                Driver.FindElement(By.CssSelector("#LocationData_Fax")).SendKeys(
                    value);
            }
        }

        public string Email
        {
            set
            {
                Driver.FindElement(By.CssSelector("#LocationData_Email")).Clear();
                Driver.FindElement(By.CssSelector("#LocationData_Email")).
                    SendKeys(value);
            }
        }


        public string SapNumber
        {
            set
            {
                Driver.FindElement(By.CssSelector("#LocationData_SapNumber")).Clear();
                Driver.FindElement(By.CssSelector("#LocationData_SapNumber")).SendKeys(value);
            }
        }

        public string CompanyName
        {
            set
            {
                Driver.FindElement(By.CssSelector("#LocationData_LocationName")).Clear();
                Driver.FindElement(By.CssSelector("#LocationData_LocationName")).SendKeys(value);
            }
        }


        public string StreetName
        {
            set
            {
                Driver.FindElement(By.CssSelector("#LocationData_Street")).
                    Clear();
                Driver.FindElement(By.CssSelector("#LocationData_Street")).
                    SendKeys(
                        value);
            }
        }

        public string Language
        {
            set { Driver.FindAdaptedElement(By.CssSelector("#LocationData_LanguageId")).Selector().SelectByText(value); }
            get
            {
                return
                    Driver.FindAdaptedElement(By.CssSelector("#LocationData_LanguageId")).Selector().SelectedOption.
                        Text;
            }
        }

        public string Web
        {
            set
            {
                Driver.FindElement(By.CssSelector("#LocationData_Web")).Clear();
                Driver.FindElement(By.CssSelector("#LocationData_Web")).SendKeys(
                    value);
            }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector("input.button[value='Speichern']")); }
        }

        #endregion
    }
}