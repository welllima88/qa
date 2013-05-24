using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer
{
    public class CustomerView : WebObject, ICustomerView
    {
        public CustomerView(IWebDriverAdapter driver) : base(driver)
        {
        }

        #region ICustomerView Members

        public string CompanyName
        {
            get { return Driver.FindElement(By.CssSelector(Customer.CompanyName)).Text; }
        }

        public string Guid
        {
            get { return Driver.FindElement(By.CssSelector(Customer.GUID)).Text; }
        }

        public string CustomerName
        {
            get { return Driver.FindElement(By.CssSelector(Customer.CustomerName)).Text; }
        }

        public string Supplier
        {
            get { return Driver.FindElement(By.CssSelector(Customer.Supplier)).Text; }
        }

        public string SbsBillingTenant
        {
            get { return Driver.FindElement(By.CssSelector(Customer.SbsBillingTenant)).Text; }
        }

        public string StreetNo
        {
            get { return Driver.FindElement(By.CssSelector(Customer.StreetName)).Text; }
        }

        public string Zip
        {
            get { return Driver.FindElement(By.CssSelector(Customer.Zip)).Text; }
        }

        public string City
        {
            get { return Driver.FindElement(By.CssSelector(Customer.City)).Text; }
        }

        public string SbsCurrency
        {
            get { return Driver.FindElement(By.CssSelector(Customer.SbsCurrency)).Text; }
        }

        //todo to verify this locators:
        public String CustomerNumber
        {
            get { return Driver.FindElement(By.CssSelector("span[id$='customerNumberInput']")).Text; }
        }

        public String SbsDebitNumber
        {
            get { return Driver.FindElement(By.CssSelector("span[id$='customerSbsLabel']")).Text; }
        }

        public string Ep2MerchantId
        {
            get { return Driver.FindElement(By.CssSelector("span[id$='ep2numberTextBox']")).Text; }
        }

        public String SbsAdressNumber
        {
            get { return Driver.FindElement(By.CssSelector("span[id$='_customerSbsAddressLabel']")).Text; }
        }

        public String Agency
        {
            get { return Driver.FindElement(By.CssSelector(Customer.Agency)).Text; }
        }


        public string Language
        {
            get { return Driver.FindElement(By.CssSelector(Customer.LanguageView)).Text; }
        }

        public string Country
        {
            get { return Driver.FindElement(By.CssSelector(Customer.CountryView)).Text; }
        }


        public string Po
        {
            get { return Driver.FindElement(By.CssSelector(Customer.Po)).Text; }
        }

        public string AdressAddition
        {
            get { return Driver.FindElement(By.CssSelector(Customer.AdressAddition)).Text; }
        }

        public string SapNumber
        {
            get { return Driver.FindElement(By.CssSelector(Customer.SapNumber)).Text; }
        }

        public string Email
        {
            // ":not(label)" is necessary because rendering tag is a span if no email and a if it is set
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("[id^='ctl00_bodyContentPlaceHolder_addressControl_email']:not(label)")).Text;
            }
        }

        public string Telephone
        {
            get { return Driver.FindElement(By.CssSelector(Customer.Telephone)).Text; }
        }

        public string Mobile
        {
            get { return Driver.FindElement(By.CssSelector(Customer.Mobile)).Text; }
        }

        public string Fax
        {
            get { return Driver.FindElement(By.CssSelector(Customer.Fax)).Text; }
        }

        public string Web
        {
            get { return Driver.FindElement(By.CssSelector(Customer.WebView)).Text; }
        }

        public IWebElement EditButton
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEdit")); }
        }

        public string Region
        {
            get { return Driver.FindElement(By.CssSelector(Customer.Region)).Text; }
        }

        public string CategoryCode
        {
            get { return Driver.FindElement(By.CssSelector(Customer.CategoryCodeView)).Text; }
        }

        public string SupportContract
        {
            get { return Driver.FindElement(By.CssSelector(Customer.SupportContract)).Text; }
        }

        public string CashIntegrator
        {
            get { return Driver.FindElement(By.CssSelector(Customer.CashIntegrator)).Text; }
        }

        public string Segment
        {
            get { return Driver.FindElement(By.CssSelector(Customer.Segment)).Text; }
        }

        #endregion
    }
}