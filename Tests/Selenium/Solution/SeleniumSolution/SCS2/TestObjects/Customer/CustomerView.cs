using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer
{
    public class CustomerView : WebObject, ICustomer
    {
        #region ICustomerView Members

        public string CustomerName
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.CustomerName)).Text; }
            set { throw new NotImplementedException(); }
        }

        public IWebElement EditButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEdit")); }
        }

        public string Guid
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.GUID)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string CashIntegrator
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.CashIntegrator)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string CompanyName
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.CompanyName)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string SapNumber
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.SapNumber)).Text; }
            set { throw new NotSupportedException("Not available in create mode"); }
        }

        public string StreetNo
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.StreetName)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Zip
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.Zip)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string City
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.City)).Text; }
            set { throw new NotImplementedException(); }
        }

        public String Agency
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.Agency)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Language
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.LanguageView)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Country
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.CountryView)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Po
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.Po)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string AdressAddition
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.AdressAddition)).Text; }
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
            get { return WebDriver.FindElement(By.CssSelector(Customer.Telephone)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Mobile
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.Mobile)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Fax
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.Fax)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Web
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.WebView)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Region
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.Region)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string CategoryCode
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.CategoryCodeView)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string SupportContract
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.SupportContract)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Segment
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.SegmentView)).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Supplier
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.Supplier)).Text; }
        }

        public string SbsBillingTenant
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.SbsBillingTenant)).Text; }
        }

        public string SbsCurrency
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.SbsCurrency)).Text; }
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
        }

        public String SbsAdressNumber
        {
            get { return WebDriver.FindElement(By.CssSelector("span[id$='_customerSbsAddressLabel']")).Text; }
        }

        string ICustomer.CustomerName { get; set; }

        #endregion
    }
}