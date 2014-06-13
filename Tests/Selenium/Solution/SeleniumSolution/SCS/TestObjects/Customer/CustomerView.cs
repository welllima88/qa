using System;
using OpenQA.Selenium;
using SIX.SCS.Tests.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.Tests.Selenium.TestObjects.Customer
{
    public class CustomerView : WebObject
    {
        public string Segment
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_customerSegment")).Text; }
            set { throw new NotImplementedException(); }
        }

        #region ICustomerView Members

        public IWebElement EditButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEdit")); }
        }

        public string CompanyName
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_inpCompanyName")).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Guid
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_customerGUIDLabel")).Text; }
            set { throw new NotImplementedException(); }
        }

        public string CustomerName
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_customerNameTextBox")).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string Supplier
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_supplierDropDown_dnSupplier")).
                              Text;
            }
            set { throw new NotImplementedException(); }
        }

        public static string SbsBillingTenant
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_customerSbsBillingTenantLabel"))
                             .
                              Text;
            }
            set { throw new NotImplementedException(); }
        }

        public string StreetNo
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_streetNameTextBox"))
                             .Text;
            }
            set { throw new NotImplementedException(); }
        }

        public string Zip
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_zipTextBox"))
                             .Text;
            }
            set { throw new NotImplementedException(); }
        }

        public string City
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_cityTextBox"))
                             .Text;
            }
            set { throw new NotImplementedException(); }
        }

        public static string SbsCurrency
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_customerSbsCurrency")).Text; }
            set { throw new NotImplementedException(); }
        }

        public static String CustomerNumber
        {
            get { return WebDriver.FindElement(By.CssSelector("span[id$='customerNumberInput']")).Text; }
        }

        public static String SbsDebitNumber
        {
            get { return WebDriver.FindElement(By.CssSelector("span[id$='customerSbsLabel']")).Text; }
        }

        public static String SbsAdressNumber
        {
            get { return WebDriver.FindElement(By.CssSelector("span[id$='_customerSbsAddressLabel']")).Text; }
        }

        public String Agency
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_rowAgency_sugAgency")).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Language
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_sugLanguage"))
                             .Text;
            }
            set { throw new NotImplementedException(); }
        }

        public string Country
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_sugCountry"))
                             .Text;
            }
            set { throw new NotImplementedException(); }
        }

        public string Ep2MerchantId
        {
            get { return WebDriver.FindElement(By.CssSelector("span[id$='ep2numberTextBox']")).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Po
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_poTextBox")).Text;
            }
            set { throw new NotImplementedException(); }
        }

        public string AdressAddition
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_addressAdditionTextBox")).Text;
            }
            set { throw new NotImplementedException(); }
        }

        public string SapNumber
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_sapNumberInput")).Text; }
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
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_telephoneTextBox"))
                             .Text;
            }
            set { throw new NotImplementedException(); }
        }

        public string Mobile
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_telephone2TextBox"))
                             .Text;
            }
            set { throw new NotImplementedException(); }
        }

        public string Fax
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_faxTextBox"))
                             .Text;
            }
            set { throw new NotImplementedException(); }
        }

        public string Web
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_webLink")).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Region
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_regionTextBox")).
                              Text;
            }
            set { throw new NotImplementedException(); }
        }

        public string CategoryCode
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_rowCategoryCode_sugDropDown"))
                             .Text;
            }
            set { throw new NotImplementedException(); }
        }

        public string SupportContract
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector("#ctl00_bodyContentPlaceHolder_rowSupportContract_ddSupportContract"))
                             .Text;
            }
            set { throw new NotImplementedException(); }
        }

        public string CashIntegrator
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector("#ctl00_bodyContentPlaceHolder_rowCashIntegrator_sugCashIntegrator"))
                             .Text;
            }
            set { throw new NotImplementedException(); }
        }

        #endregion
    }
}