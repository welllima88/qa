using System;
using OpenQA.Selenium;
using SIX.SCS.Tests.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.SCSClassics.Tests.Selenium.TestObjects.Customer
{
    public class CustomerEdit : WebObject
    {
        public string CustomerName
        {
            set { CustomerCreate.CustomerName = value; }
        }

        public string SapNumber
        {
            set { CustomerCreate.SapNumber = value; }
        }

        public string CompanyName
        {
            set { CustomerCreate.CompanyName = value; }
        }

        public string Supplier
        {
            get { return CustomerView.Supplier; }
        }

        public String CustomerNumber
        {
            get { return CustomerView.CustomerNumber; }
        }

        public String SbsDebitNumber
        {
            get { return CustomerView.SbsDebitNumber; }
        }

        public String SbsAdressNumber
        {
            get { return CustomerView.SbsAdressNumber; }
        }

        public String SbsCurrency
        {
            get { return CustomerView.SbsCurrency; }
        }

        public String SbsBillingTenant
        {
            get { return CustomerView.SbsBillingTenant; }
        }

        public String Ep2MerchantId
        {
            get { return WebDriver.FindElement(By.CssSelector("input[id$='ep2numberTextBox']")).GetAttribute("value"); }
        }

        public string CategoryCode
        {
            set { CustomerCreate.CategoryCode = value; }
        }

        public string Agency
        {
            set { CustomerCreate.Agency = value; }
        }

        public string SupportContract
        {
            set { CustomerCreate.SupportContract = value; }
        }

        public string StreetName
        {
            set { CustomerCreate.StreetName = value; }
        }

        public string Language
        {
            set { CustomerCreate.Language = value; }
        }

        public string Country
        {
            set { CustomerCreate.Country = value; }
        }

        public string Zip
        {
            set { CustomerCreate.Zip = value; }
        }

        public string City
        {
            set { CustomerCreate.City = value; }
        }

        public string AdressAddition
        {
            set { CustomerCreate.AdressAddition = value; }
        }

        public string Po
        {
            set { CustomerCreate.Po = value; }
        }

        public string Region
        {
            set { CustomerCreate.Region = value; }
        }

        public string Telephone
        {
            set { CustomerCreate.Telephone = value; }
        }

        public string Mobile
        {
            set { CustomerCreate.Mobile = value; }
        }

        public string Fax
        {
            set { CustomerCreate.Fax = value; }
        }

        public string Email
        {
            set { CustomerCreate.Email = value; }
        }

        public string Web
        {
            set { CustomerCreate.Web = value; }
        }

        public IWebElement SaveButton
        {
            get { return CustomerCreate.SaveButton; }
        }

        public IWebElement CancelButton
        {
            get { return CustomerCreate.CancelButton; }
        }

        public string CashIntegrator
        {
            set { CustomerCreate.CashIntegrator = value; }
        }
    }
}