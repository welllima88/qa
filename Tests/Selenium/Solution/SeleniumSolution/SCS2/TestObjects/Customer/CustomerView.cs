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
        }

        #region ICustomerView Members

        public string CompanyName
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_inpCompanyName")).Text; }
        }

        public string Guid
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_customerGUIDLabel")).Text; }
        }

        public string CustomerName
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_customerNameTextBox")).Text; }
        }

        public string Supplier
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_supplierDropDown_dnSupplier")).
                        Text;
            }
        }

        public string SbsBillingTenant
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_customerSbsBillingTenantLabel")).
                        Text;
            }
        }

        public string StreetName
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_streetNameTextBox"))
                        .Text;
            }
        }

        public string Zip
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_zipTextBox")).Text;
            }
        }

        public string City
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_cityTextBox")).Text;
            }
        }

        public string SbsCurrency
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_customerSbsCurrency")).Text; }
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
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_rowAgency_sugAgency")).Text; }
        }


        public string Language
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_sugLanguage")).Text;
            }
        }

        public string Country
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_sugCountry")).Text;
            }
        }

        public string Ep2MerchantId
        {
            get { return Driver.FindElement(By.CssSelector("span[id$='ep2numberTextBox']")).Text; }
        }

        public string Po
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_poTextBox")).Text; }
        }

        public string AdressAddition
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_addressAdditionTextBox")).Text;
            }
        }

        public string SapNumber
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_sapNumberInput")).Text; }
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
                    Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_telephoneTextBox"))
                        .Text;
            }
        }

        public string Mobile
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_telephone2TextBox"))
                        .Text;
            }
        }

        public string Fax
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_faxTextBox")).Text;
            }
        }

        public string Web
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_webLink")).Text; }
        }

        public IWebElement EditButton
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEdit")); }
        }

        public string Region
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_regionTextBox")).
                        Text;
            }
        }

        public string CategoryCode
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_rowCategoryCode_sugDropDown"))
                        .Text;
            }
        }

        public string SupportContract
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("#ctl00_bodyContentPlaceHolder_rowSupportContract_ddSupportContract"))
                        .Text;
            }
        }

        public string CashIntegrator
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("#ctl00_bodyContentPlaceHolder_rowCashIntegrator_sugCashIntegrator"))
                        .Text;
            }
        }

        public string CustomerSegment
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_customerSegment")).Text; }
        }

        #endregion
    }
}