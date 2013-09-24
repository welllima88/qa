using System;
using OpenQA.Selenium;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Definitions;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Customer
{
    public class CustomerView : WebObject, ICustomer
    {
        #region ICustomerView Members

        public IWebElement EditButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEdit")); }
        }

        public string CustomerName
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.CustomerName)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Guid
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.GUID)).Text; }
        }

        public string CashIntegrator
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.CashIntegrator)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string CompanyName
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.CompanyName)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string SapNumber
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.SapNumber)).Text; }
            set { throw new NotSupportedException("Not available in create mode"); }
        }

        public string StreetNo
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.StreetName)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Zip
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.Zip)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string City
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.City)).Text; }
            set { throw new NotImplementedException(); }
        }

        public String Agency
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.Agency)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Language
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.LanguageView)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Country
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.CountryView)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Po
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.Po)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string AdressAddition
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.AdressAddition)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Email
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

        public string Telephone
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.Telephone)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Mobile
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.Mobile)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Fax
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.Fax)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Web
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.WebView)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Region
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.Region)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string CategoryCode
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.CategoryCodeView)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string SupportContract
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.SupportContract)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Segment
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.SegmentView)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Supplier
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.Supplier)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string SbsBillingTenant
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.SbsBillingTenant)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string SbsCurrency
        {
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.SbsCurrency)).Text; }
            set { throw new NotImplementedException(); }
        }

        //todo to verify this locators:
        public String CustomerNumber
        {
            get { return WebDriver.FindElement(By.CssSelector("span[id$='customerNumberInput']")).Text; }
        }

        public String SbsDebitNumber
        {
            get { return WebDriver.FindElement(By.CssSelector("span[id$='customerSbsLabel']")).Text; }
        }

        public string Ep2MerchantId
        {
            get { return WebDriver.FindElement(By.CssSelector("span[id$='ep2numberTextBox']")).Text; }
            set { throw new NotImplementedException(); }
        }

        public String SbsAdressNumber
        {
            get { return WebDriver.FindElement(By.CssSelector("span[id$='_customerSbsAddressLabel']")).Text; }
        }

        #endregion
    }
}