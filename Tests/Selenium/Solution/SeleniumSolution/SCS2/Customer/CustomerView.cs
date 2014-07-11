using System;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Customer
{
    public class CustomerView : WebObject
    {
        public static IWebElementAdapter EditCustomerButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerEdit")); }
        }

        public static IWebElementAdapter EditDefaultConfigButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerDefaultEdit")); }
        }

        public static string CustomerName
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_CustomerName")).Text; }
        }

        public static string CashIntegrator
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerPref_CashIntegrator")).Text; }
        }

        public static string CompanyName
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_CompanyName")).Text; }
        }

        public static string SapNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_SapNumber")).Text; }
        }

        public static string StreetNo
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_Street")).Text; }
        }

        public static string Zip
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_Zip")).Text; }
        }

        public static string City
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_City")).Text; }
        }

        public static String Agency
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_AgencyName")).Text; }
        }

        public static string Language
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_Language")).Text; }
        }

        public static string Country
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_Country")).Text; }
        }

        public static string Po
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_PO")).Text; }
        }

        public static string AdressAddition
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_AddressAddition")).Text; }
        }

        public static string Email
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_EMail")).Text; }
        }

        public static string Telephone
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_Telephone")).Text; }
        }

        public static string Mobile
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_Mobile")).Text; }
        }

        public static string Fax
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_Fax")).Text; }
        }

        public static string Web
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_Web")).Text; }
        }

        public static string Region
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_Region")).Text; }
        }

        public static string CategoryCode
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerPref_CategoryCode")).Text; }
        }

        public static string SupportContract
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerPref_SupportContract")).Text; }
        }

        public static string Segment
        {
            get { return WebDriver.FindAdaptedElement(By.Id("SBSConfig_CustomerSegment")).Text; }
        }

        public static string Supplier
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_SupplierMandant")).Text; }
        }

        public static string SbsBillingTenant
        {
            get { return WebDriver.FindAdaptedElement(By.Id("SBSConfig_BillingTenant")).Text; }
        }

        public static string SbsCurrency
        {
            get { return WebDriver.FindAdaptedElement(By.Id("SBSConfig_Currency")).Text; }
        }

        public static String CustomerNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_CustomerId")).Text; }
        }

        public static String SbsDebitNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("SBSConfig_DebitNumber")).Text; }
        }

        public static string Ep2MerchantId
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_Ep2MerchantId")).Text; }
        }

        public static String SbsAdressNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("SBSConfig_AddressNumber")).Text; }
        }
    }
}