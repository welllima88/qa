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
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Zip)).TextBox().TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string City
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.City)).TextBox().TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string AdressAddition
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.AdressAddition)).TextBox().TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Po
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Po)).TextBox().TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Region
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Region)).TextBox().TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Telephone
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Telephone)).TextBox().TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Mobile
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Mobile)).TextBox().TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Fax
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Fax)).TextBox().TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Email
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Email)).TextBox().TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string SapNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.SapNumber)).TextBox().TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string CompanyName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.CompanyName)).TextBox().TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string StreetNo
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.StreetName)).TextBox().TypeText(value); }
            get { throw new NotSupportedException(); }
        }

        public static string Web
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.Web)).TextBox().TypeText(value); }
            get { throw new NotSupportedException(); }
        }
    }
}