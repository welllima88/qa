using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Customer
{
    public class CustomerEdit : WebObject
    {
        public static IWebElement SaveButton
        {
            get { return CustomerCreate.SaveButton; }
        }

        public static IWebElement CancelButton
        {
            get { return CustomerCreate.CancelButton; }
        }

        public static string Segment
        {
            set { CustomerCreate.Segment = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.SegmentView)).Text; }
        }

        public string Guid
        {
            get { throw new NotSupportedException("Not available in create mode"); }
        }

        public static string CustomerName
        {
            set { CustomerCreate.CustomerName = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.CustomerName)).GetAttribute("value"); }
        }

        public static string SapNumber
        {
            set { CustomerCreate.SapNumber = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.SapNumber)).GetAttribute("value"); }
        }

        public static string CompanyName
        {
            set { CustomerCreate.CompanyName = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.CompanyName)).GetAttribute("value"); }
        }

        public static string Supplier
        {
            get { return CustomerView.Supplier; }
            set { throw new NotImplementedException(); }
        }

        public static String CustomerNumber
        {
            get { return CustomerView.CustomerNumber; }
        }

        public static String SbsDebitNumber
        {
            get { return CustomerView.SbsDebitNumber; }
        }

        public static String SbsAdressNumber
        {
            get { return CustomerView.SbsAdressNumber; }
        }

        public static String SbsCurrency
        {
            get { return CustomerView.SbsCurrency; }
            set { throw new NotImplementedException(); }
        }

        public static String SbsBillingTenant
        {
            get { return CustomerView.SbsBillingTenant; }
            set { throw new NotImplementedException(); }
        }

        public static String Ep2MerchantId
        {
            get { return WebDriver.FindElement(By.CssSelector("input[id$='ep2numberTextBox']")).GetAttribute("value"); }
            set { throw new NotSupportedException(); }
        }

        public static string CategoryCode
        {
            set { CustomerCreate.CategoryCode = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.CategoryCode)).GetAttribute("value"); }
        }

        public static string Agency
        {
            set { CustomerCreate.Agency = value; }
            get { return CustomerCreate.Agency; }
        }

        public static string SupportContract
        {
            set { CustomerCreate.SupportContract = value; }
            get { return CustomerCreate.SupportContract; }
        }

        public static string StreetNo
        {
            set { CustomerCreate.StreetNo = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.StreetName)).GetAttribute("value"); }
        }

        public static string Language
        {
            set { CustomerCreate.Language = value; }
            get { return CustomerCreate.Language; }
        }

        public static string Country
        {
            set { CustomerCreate.Country = value; }
            get { return CustomerCreate.Country; }
        }

        public static string Zip
        {
            set { CustomerCreate.Zip = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Zip)).GetAttribute("value"); }
        }

        public static string City
        {
            set { CustomerCreate.City = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.City)).GetAttribute("value"); }
        }

        public static string AdressAddition
        {
            set { CustomerCreate.AdressAddition = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.AdressAddition)).GetAttribute("value"); }
        }

        public static string Po
        {
            set { CustomerCreate.Po = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Po)).GetAttribute("value"); }
        }

        public static string Region
        {
            set { CustomerCreate.Region = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Region)).GetAttribute("value"); }
        }

        public static string Telephone
        {
            set { CustomerCreate.Telephone = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Telephone)).GetAttribute("value"); }
        }

        public static string Mobile
        {
            set { CustomerCreate.Mobile = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Mobile)).GetAttribute("value"); }
        }

        public static string Fax
        {
            set { CustomerCreate.Fax = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Fax)).GetAttribute("value"); }
        }

        public static string Email
        {
            set { CustomerCreate.Email = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Email)).GetAttribute("value"); }
        }

        public static string Web
        {
            set { CustomerCreate.Web = value; }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Web)).GetAttribute("value"); }
        }

        public static string CashIntegrator
        {
            set { CustomerCreate.CashIntegrator = value; }
            get { return CustomerCreate.CashIntegrator; }
        }
    }
}