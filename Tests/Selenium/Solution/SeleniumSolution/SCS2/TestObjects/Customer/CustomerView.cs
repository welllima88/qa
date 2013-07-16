using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer
{
    public class CustomerView : WebObject, ICustomerView
    {
        #region ICustomerView Members

        public string CompanyName
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.CompanyName)).Text; }
        }

        public string Guid
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.GUID)).Text; }
        }

        public string CustomerName
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.CustomerName)).Text; }
        }

        public string Supplier
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.Supplier)).Text; }
        }

        public string SbsBillingTenant
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.SbsBillingTenant)).Text; }
        }

        public string StreetNo
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.StreetName)).Text; }
        }

        public string Zip
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.Zip)).Text; }
        }

        public string City
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.City)).Text; }
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

        public String Agency
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.Agency)).Text; }
        }


        public string Language
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.LanguageView)).Text; }
        }

        public string Country
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.CountryView)).Text; }
        }


        public string Po
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.Po)).Text; }
        }

        public string AdressAddition
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.AdressAddition)).Text; }
        }

        public string SapNumber
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.SapNumber)).Text; }
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
        }

        public string Telephone
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.Telephone)).Text; }
        }

        public string Mobile
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.Mobile)).Text; }
        }

        public string Fax
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.Fax)).Text; }
        }

        public string Web
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.WebView)).Text; }
        }

        public IWebElement EditButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEdit")); }
        }

        public string Region
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.Region)).Text; }
        }

        public string CategoryCode
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.CategoryCodeView)).Text; }
        }

        public string SupportContract
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.SupportContract)).Text; }
        }

        public string CashIntegrator
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.CashIntegrator)).Text; }
        }

        public string Segment
        {
            get { return WebDriver.FindElement(By.CssSelector(Customer.SegmentView)).Text; }
        }

        #endregion
    }
}