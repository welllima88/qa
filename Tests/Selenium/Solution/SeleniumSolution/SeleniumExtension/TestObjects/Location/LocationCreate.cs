using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Location
{
    public class LocationCreate : WebObject, ILocation
    {
        public IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input.button[type='submit']")); }
        }

        #region ILocation Members

        public string Country
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.Country)).Selector().SelectByValue(value); }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector(Location.Country)).Selector().
                              SelectedOption.Text;
            }
        }

        public string Ep2MerchantId
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
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
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.Language)).Selector().SelectByValue(value); }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector(Location.Language)).Selector().
                              SelectedOption.Text;
            }
        }

        #endregion

        public string Zip
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.Zip)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string City
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.City)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string AdressAddition
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.AdressAddition)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string Po
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.Po)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string Region
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.Region)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string Telephone
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.Telephone)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string Mobile
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.Mobile)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string Fax
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.Fax)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string Email
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.Email)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string SapNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.SapNumber)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string CompanyName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.CompanyName)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string StreetNo
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.StreetName)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public string Web
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.Web)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }
    }
}