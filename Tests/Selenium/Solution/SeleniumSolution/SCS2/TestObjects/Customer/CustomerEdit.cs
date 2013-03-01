using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer
{
    public class CustomerEdit : WebObject, ICustomerEdit
    {
        private readonly CustomerCreate _customerCreate;
        private readonly CustomerView _customerView;
        
        public CustomerEdit(IWebDriverAdapter driver) : base(driver)
        {
            _customerView = new CustomerView(Driver);
            _customerCreate = new CustomerCreate(Driver);
        }

        #region ICustomerEdit Members

        public string CustomerName
        {
            set { _customerCreate.CustomerName = value; }
        }

        public string SapNumber
        {
            set { _customerCreate.SapNumber = value; }
        }

        public string CompanyName
        {
            set { _customerCreate.CompanyName = value; }
        }


        public string Supplier
        {
            get { return _customerView.Supplier; }
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
        }

        public String SbsBillingTenant
        {
            get { return _customerView.SbsBillingTenant; }
        }

        public String Ep2MerchantId
        {
            get { return Driver.FindElement(By.CssSelector("input[id$='ep2numberTextBox']")).GetAttribute("value"); }
        }

        public string CategoryCode
        {
            set { _customerCreate.CategoryCode = value; }
        }

        public string Agency
        {
            set { _customerCreate.Agency = value; }
        }

        public string SupportContract
        {
            set { _customerCreate.SupportContract = value; }
        }

        public string StreetName
        {
            set { _customerCreate.StreetName = value; }
        }

        public string Language
        {
            set { _customerCreate.Language = value; }
        }

        public string Country
        {
            set { _customerCreate.Country = value; }
        }

        public string Zip
        {
            set { _customerCreate.Zip = value; }
        }

        public string City
        {
            set { _customerCreate.City = value; }
        }

        public string AdressAddition
        {
            set { _customerCreate.AdressAddition = value; }
        }

        public string Po
        {
            set { _customerCreate.Po = value; }
        }

        public string Region
        {
            set { _customerCreate.Region = value; }
        }

        public string Telephone
        {
            set { _customerCreate.Telephone = value; }
        }

        public string Mobile
        {
            set { _customerCreate.Mobile = value; }
        }

        public string Fax
        {
            set { _customerCreate.Fax = value; }
        }

        public string Email
        {
            set { _customerCreate.Email = value; }
        }

        public string Web
        {
            set { _customerCreate.Web = value; }
        }

        public IWebElement SaveButton
        {
            get { return _customerCreate.SaveButton; }
        }

        public IWebElement CancelButton
        {
            get { return _customerCreate.CancelButton; }
        }

        public string CashIntegrator
        {
            set { _customerCreate.CashIntegrator = value; }
        }

        #endregion
    }
}