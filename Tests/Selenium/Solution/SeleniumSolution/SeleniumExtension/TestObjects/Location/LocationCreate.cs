using System;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Location
{
    public class LocationCreate : WebObject
    {
        public static IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input.button[type='submit']")); }
        }

        public static string Country
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

        public static string Language
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.Language)).Selector().SelectByValue(value); }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector(Location.Language)).Selector().
                              SelectedOption.Text;
            }
        }

        public static string Zip
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.Zip)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string City
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.City)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string AdressAddition
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.AdressAddition)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Po
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.Po)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Region
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.Region)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Telephone
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.Telephone)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Mobile
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.Mobile)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Fax
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.Fax)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Email
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.Email)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string SapNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.SapNumber)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string CompanyName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.CompanyName)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string StreetNo
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.StreetName)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Web
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(Location.Web)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }
    }
}