using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

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
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Location.Country)).Selector().SelectByText(
                    value);
            }
            get
            {
                return
                    Driver.FindAdaptedElement(By.CssSelector(Location.Country)).Selector().
                        SelectedOption.Text;
            }
        }

        public string Zip
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.Zip)).TypeText(value); }
        }

        public string City
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.City)).TypeText(value); }
        }

        public string AdressAddition
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.AdressAddition)).TypeText(value); }
        }

        public string Po
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.Po)).TypeText(value); }
        }

        public string Region
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.Region)).TypeText(value); }
        }

        public string Telephone
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.Telephone)).TypeText(value); }
        }

        public string Mobile
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.Mobile)).TypeText(value); }
        }

        public string Fax
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.Fax)).TypeText(value); }
        }

        public string Email
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.Email)).TypeText(value); }
        }


        public string SapNumber
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.SapNumber)).TypeText(value); }
        }

        public string CompanyName
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.CompanyName)).TypeText(value); }
        }


        public string StreetName
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.StreetName)).TypeText(value); }
        }

        public string Language
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Location.Language)).Selector().SelectByText(
                    value);
            }
            get
            {
                return
                    Driver.FindAdaptedElement(By.CssSelector(Location.Language)).Selector().
                        SelectedOption.
                        Text;
            }
        }

        public string Web
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.Web)).TypeText(value); }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector("input.button[value='Speichern']")); }
        }

        #endregion
    }
}