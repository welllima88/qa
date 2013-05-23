using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.TestObjects;

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
            get { return _customerCreate.CustomerName; }
        }

        public string SapNumber
        {
            set { _customerCreate.SapNumber = value; }
            get { return _customerCreate.SapNumber; }
        }

        public string CompanyName
        {
            set { _customerCreate.CompanyName = value; }
            get { return _customerCreate.CompanyName; }
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
            get { return _customerCreate.CategoryCode; }
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

        public string StreetName
        {
            set { _customerCreate.StreetName = value; }
            get { return _customerCreate.StreetName; }
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
            get { return _customerCreate.Zip; }
        }

        public string City
        {
            set { _customerCreate.City = value; }
            get { return _customerCreate.City; }
        }

        public string AdressAddition
        {
            set { _customerCreate.AdressAddition = value; }
            get { return _customerCreate.AdressAddition; }
        }

        public string Po
        {
            set { _customerCreate.Po = value; }
            get { return _customerCreate.Po; }
        }

        public string Region
        {
            set { _customerCreate.Region = value; }
            get { return _customerCreate.Region; }
        }

        public string Telephone
        {
            set { _customerCreate.Telephone = value; }
            get { return _customerCreate.Telephone; }
        }

        public string Mobile
        {
            set { _customerCreate.Mobile = value; }
            get { return _customerCreate.Mobile; }
        }

        public string Fax
        {
            set { _customerCreate.Fax = value; }
            get { return _customerCreate.Fax; }
        }

        public string Email
        {
            set { _customerCreate.Email = value; }
            get { return _customerCreate.Email; }
        }

        public string Web
        {
            set { _customerCreate.Web = value; }
            get { return _customerCreate.Web; }
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
            get { return _customerCreate.CashIntegrator; }
        }

        #endregion
    }
}