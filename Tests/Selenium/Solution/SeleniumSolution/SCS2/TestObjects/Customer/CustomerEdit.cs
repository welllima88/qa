using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer
{
    public class CustomerEdit : WebObject, ICustomer
    {
        private readonly CustomerCreate _customerCreate;
        private readonly CustomerView _customerView;

        public CustomerEdit()
        {
            _customerView = new CustomerView();
            _customerCreate = new CustomerCreate();
        }

        #region ICustomerEdit Members

        public IWebElement SaveButton
        {
            get { return _customerCreate.SaveButton; }
        }

        public IWebElement CancelButton
        {
            get { return _customerCreate.CancelButton; }
        }

        public string Segment
        {
            set { _customerCreate.Segment = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.SegmentView)).Text; }
        }

        public string Guid
        {
            get { throw new NotSupportedException("Not available in create mode"); }
            set { throw new NotSupportedException("Not available in create mode"); }
        }

        public string CustomerName
        {
            set { _customerCreate.CustomerName = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.CustomerName)).GetAttribute("value"); }
        }

        public string SapNumber
        {
            set { _customerCreate.SapNumber = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.SapNumber)).GetAttribute("value"); }
        }

        public string CompanyName
        {
            set { _customerCreate.CompanyName = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.CompanyName)).GetAttribute("value"); }
        }

        public string Supplier
        {
            get { return _customerView.Supplier; }
            set { throw new NotImplementedException(); }
        }

        public String CustomerNumber
        {
            get { return _customerView.CustomerNumber; }
        }

        public String SbsDebitNumber
        {
            get { return _customerView.SbsDebitNumber; }
        }

        public String SbsAdressNumber
        {
            get { return _customerView.SbsAdressNumber; }
        }

        public String SbsCurrency
        {
            get { return _customerView.SbsCurrency; }
            set { throw new NotImplementedException(); }
        }

        public String SbsBillingTenant
        {
            get { return _customerView.SbsBillingTenant; }
            set { throw new NotImplementedException(); }
        }

        public String Ep2MerchantId
        {
            get { return WebDriver.FindElement(By.CssSelector("input[id$='ep2numberTextBox']")).GetAttribute("value"); }
            set { throw new NotImplementedException(); }
        }

        public string CategoryCode
        {
            set { _customerCreate.CategoryCode = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.CategoryCode)).GetAttribute("value"); }
        }

        public string Agency
        {
            set { _customerCreate.Agency = value; }
            get { return _customerCreate.Agency; }
        }

        public string SupportContract
        {
            set { _customerCreate.SupportContract = value; }
            get { return _customerCreate.SupportContract; }
        }

        public string StreetNo
        {
            set { _customerCreate.StreetNo = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.StreetName)).GetAttribute("value"); }
        }

        public string Language
        {
            set { _customerCreate.Language = value; }
            get { return _customerCreate.Language; }
        }

        public string Country
        {
            set { _customerCreate.Country = value; }
            get { return _customerCreate.Country; }
        }

        public string Zip
        {
            set { _customerCreate.Zip = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Zip)).GetAttribute("value"); }
        }

        public string City
        {
            set { _customerCreate.City = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.City)).GetAttribute("value"); }
        }

        public string AdressAddition
        {
            set { _customerCreate.AdressAddition = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.AdressAddition)).GetAttribute("value"); }
        }

        public string Po
        {
            set { _customerCreate.Po = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Po)).GetAttribute("value"); }
        }

        public string Region
        {
            set { _customerCreate.Region = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Region)).GetAttribute("value"); }
        }

        public string Telephone
        {
            set { _customerCreate.Telephone = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Telephone)).GetAttribute("value"); }
        }

        public string Mobile
        {
            set { _customerCreate.Mobile = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Mobile)).GetAttribute("value"); }
        }

        public string Fax
        {
            set { _customerCreate.Fax = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Fax)).GetAttribute("value"); }
        }

        public string Email
        {
            set { _customerCreate.Email = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Email)).GetAttribute("value"); }
        }

        public string Web
        {
            set { _customerCreate.Web = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Web)).GetAttribute("value"); }
        }

        public string CashIntegrator
        {
            set { _customerCreate.CashIntegrator = value; }
            get { return _customerCreate.CashIntegrator; }
        }

        #endregion
    }
}