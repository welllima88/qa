using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer
{
    public class CustomerView : WebObject, ICustomerView
    {
        public CustomerView(IWebDriverAdapter driver) : base(driver)
        {
            Prefix = "#ctl00_bodyContentPlaceHolder";
        }

        #region ICustomerView Members

        public string CompanyName
        {
            get { return Driver.FindElement(By.CssSelector(Prefix +"_inpCompanyName")).Text; }
        }

        public string Guid
        {
            get { return Driver.FindElement(By.CssSelector(Prefix +"_customerGUIDLabel")).Text; }
        }

        public string CustomerName
        {
            get { return Driver.FindElement(By.CssSelector(Prefix +"_customerNameTextBox")).Text; }
        }

        public string Supplier
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Prefix +"_supplierDropDown_dnSupplier")).
                        Text;
            }
        }

        public string SbsBillingTenant
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Prefix +"_customerSbsBillingTenantLabel")).
                        Text;
            }
        }

        public string StreetName
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Prefix +"_addressControl_streetNameTextBox"))
                        .Text;
            }
        }

        public string Zip
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Prefix +"_addressControl_zipTextBox")).Text;
            }
        }

        public string City
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Prefix +"_addressControl_cityTextBox")).Text;
            }
        }

        public string SbsCurrency
        {
            get { return Driver.FindElement(By.CssSelector(Prefix +"_customerSbsCurrency")).Text; }
        }

        public String CustomerNumber
        {
            get { return Driver.FindElement(By.CssSelector("span[id$='customerNumberInput']")).Text; }
        }

        public String SbsDebitNumber
        {
            get { return Driver.FindElement(By.CssSelector("span[id$='customerSbsLabel']")).Text; }
        }

        public String SbsAdressNumber
        {
            get { return Driver.FindElement(By.CssSelector("span[id$='_customerSbsAddressLabel']")).Text; }
        }

        public String Agency
        {
            get { return Driver.FindElement(By.CssSelector(Prefix +"_rowAgency_sugAgency")).Text; }
        }


        public string Language
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Prefix +"_addressControl_sugLanguage")).Text;
            }
        }

        public string Country
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Prefix +"_addressControl_sugCountry")).Text;
            }
        }

        public string Ep2MerchantId
        {
            get { return Driver.FindElement(By.CssSelector("span[id$='ep2numberTextBox']")).Text; }
        }

        public string Po
        {
            get { return Driver.FindElement(By.CssSelector(Prefix +"_addressControl_poTextBox")).Text; }
        }

        public string AdressAddition
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(Prefix +"_addressControl_addressAdditionTextBox")).Text;
            }
        }

        public string SapNumber
        {
            get { return Driver.FindElement(By.CssSelector(Prefix +"_sapNumberInput")).Text; }
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
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Prefix +"_addressControl_telephoneTextBox"))
                        .Text;
            }
        }

        public string Mobile
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Prefix +"_addressControl_telephone2TextBox"))
                        .Text;
            }
        }

        public string Fax
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Prefix +"_addressControl_faxTextBox")).Text;
            }
        }

        public string Web
        {
            get { return Driver.FindElement(By.CssSelector(Prefix +"_addressControl_webLink")).Text; }
        }

        public IWebElement EditButton
        {
            get { return Driver.FindElement(By.CssSelector(Prefix +"_btnEdit")); }
        }

        public string Region
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Prefix +"_addressControl_regionTextBox")).
                        Text;
            }
        }

        public string CategoryCode
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Prefix +"_rowCategoryCode_sugDropDown"))
                        .Text;
            }
        }

        public string SupportContract
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(Prefix +"_rowSupportContract_ddSupportContract"))
                        .Text;
            }
        }

        public string CashIntegrator
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(Prefix +"_rowCashIntegrator_sugCashIntegrator"))
                        .Text;
            }
        }

        public string CustomerSegment
        {
            get { return Driver.FindElement(By.CssSelector(Prefix +"_customerSegment")).Text; }
        }

        #endregion
    }
}