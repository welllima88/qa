using System;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Customer
{
    public class CustomerView : WebObject
    {
        #region ICustomerView Members

        public static IWebElement EditButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEdit")); }
        }

        public static string CustomerName
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.CustomerName)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string Guid
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.GUID)).Text; }
        }

        public static string CashIntegrator
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.CashIntegrator)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string CompanyName
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.CompanyName)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string SapNumber
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.SapNumber)).Text; }
            set { throw new NotSupportedException("Not available in create mode"); }
        }

        public static string StreetNo
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.StreetName)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string Zip
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.Zip)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string City
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.City)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static String Agency
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.Agency)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string Language
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.LanguageView)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string Country
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.CountryView)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string Po
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.Po)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string AdressAddition
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.AdressAddition)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string Email
        {
            // ":not(label)" is necessary because rendering tag is a span if no email and a if it is set
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector("[id^='ctl00_bodyContentPlaceHolder_addressControl_email']:not(label)")).Text;
            }
            set { throw new NotImplementedException(); }
        }

        public static string Telephone
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.Telephone)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string Mobile
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.Mobile)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string Fax
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.Fax)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string Web
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.WebView)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string Region
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.Region)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string CategoryCode
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.CategoryCodeView)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string SupportContract
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.SupportContract)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string Segment
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.SegmentView)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string Supplier
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.Supplier)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string SbsBillingTenant
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.SbsBillingTenant)).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string SbsCurrency
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.SbsCurrency)).Text; }
            set { throw new NotImplementedException(); }
        }

        //todo to verify this locators:
        public static String CustomerNumber
        {
            get { return WebDriver.FindElement(By.CssSelector("span[id$='customerNumberInput']")).Text; }
        }

        public static String SbsDebitNumber
        {
            get { return WebDriver.FindElement(By.CssSelector("span[id$='customerSbsLabel']")).Text; }
        }

        public static string Ep2MerchantId
        {
            get { return WebDriver.FindElement(By.CssSelector("span[id$='ep2numberTextBox']")).Text; }
            set { throw new NotImplementedException(); }
        }

        public static String SbsAdressNumber
        {
            get { return WebDriver.FindElement(By.CssSelector("span[id$='_customerSbsAddressLabel']")).Text; }
        }

        #endregion
    }
}