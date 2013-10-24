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
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Country)).Selector().SelectByValue(value); }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Country)).Selector().
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
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Language)).Selector().SelectByValue(value); }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Language)).Selector().
                              SelectedOption.Text;
            }
        }

        public static string Zip
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Zip)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string City
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.City)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string AdressAddition
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.AdressAddition)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Po
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Po)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Region
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Region)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Telephone
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Telephone)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Mobile
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Mobile)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Fax
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Fax)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Email
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Email)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string SapNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.SapNumber)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string CompanyName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.CompanyName)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string StreetNo
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.StreetName)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Web
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Web)).TypeText(value); }
            get { throw new NotSupportedException(); }
        }
    }
}