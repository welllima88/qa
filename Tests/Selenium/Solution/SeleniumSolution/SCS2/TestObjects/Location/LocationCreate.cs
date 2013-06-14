using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location
{
    public class LocationCreate : WebObject, ILocation
    {
        public LocationCreate(IWebDriverAdapter driver)
            : base(driver)
        {
        }

        public string Zip
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.Zip)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string City
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.City)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string AdressAddition
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.AdressAddition)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string Po
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.Po)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string Region
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.Region)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string Telephone
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.Telephone)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string Mobile
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.Mobile)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string Fax
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.Fax)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string Email
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.Email)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string SapNumber
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.SapNumber)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string CompanyName
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.CompanyName)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string StreetName
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.StreetName)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string Web
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Location.Web)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector("input.button[value='Speichern']")); }
        }

        #region ILocation Members

        public string Country
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Location.Country)).Selector().SelectByValue(value);
            }
            get
            {
                return
                    Driver.FindAdaptedElement(By.CssSelector(Location.Country)).Selector().
                        SelectedOption.Text;
            }
        }

        public string Ep2MerchantId
        {
            get { throw new NotSupportedException(); }
        }

        public string SbsDebitNumber
        {
            get { throw new NotSupportedException("will be generated"); }
        }

        public string SbsAdressNumber
        {
            get { throw new NotSupportedException("will be generated"); }
        }

        public string Guid
        {
            get { throw new NotSupportedException("will be generated"); }
        }


        public string Language
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Location.Language)).Selector().SelectByValue(value);
            }
            get
            {
                return
                    Driver.FindAdaptedElement(By.CssSelector(Location.Language)).Selector().
                        SelectedOption.Text;
            }
        }

        #endregion
    }
}