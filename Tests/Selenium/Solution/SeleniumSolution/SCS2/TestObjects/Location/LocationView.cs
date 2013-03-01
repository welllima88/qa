using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location
{
    public class LocationView : WebObject, ILocationView
    {
        public LocationView(IWebDriverAdapter driver) : base(driver)
        {
        }

        #region ILocationView Members

        public string CompanyName
        {
            get { return Driver.FindElement(By.CssSelector("#LocationData_LocationName")).Text; }
        }

        public string Guid
        {
            get { return Driver.FindElement(By.CssSelector("#LocationData_LocationGUID")).Text; }
        }

        public string StreetName
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("#LocationData_Street"))
                        .Text;
            }
        }

        public string Zip
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("#LocationData_ZIP")).Text;
            }
        }

        public string City
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("#LocationData_City")).Text;
            }
        }

        public String SbsDebitNumber
        {
            get { return Driver.FindElement(By.CssSelector("#LocationData_Address_SBSDebitNumber")).Text; }
        }

        public String SbsAdressNumber
        {
            get { return Driver.FindElement(By.CssSelector("#LocationData_Address_SBSAddressNumber")).Text; }
        }


        public string Language
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("#LocationData_LanguageId")).Text;
            }
        }

        public string Country
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("#LocationData_CountryId")).Text;
            }
        }

        public string Ep2MerchantId
        {
            get { return Driver.FindElement(By.CssSelector("#Location_EP2MerchantId")).Text; }
        }

        public string SapNumber
        {
            get { return Driver.FindElement(By.CssSelector("#LocationData_SapNumber")).Text; }
        }

        public string Po
        {
            get { return Driver.FindElement(By.CssSelector("#LocationData_PO")).Text; }
        }

        public string AdressAddition
        {
            get { return Driver.FindElement(By.CssSelector("#LocationData_AddressAddition")).Text; }
        }

        public string Email
        {
            get { return Driver.FindElement(By.CssSelector("#LocationData_Email")).Text; }
        }

        public string Web
        {
            get { return Driver.FindElement(By.CssSelector("#LocationData_Web")).Text; }
        }

        public string Telephone
        {
            get { return Driver.FindElement(By.CssSelector("#LocationData_Telephone")).Text; }
        }

        public string Mobile
        {
            get { return Driver.FindElement(By.CssSelector("#LocationData_Mobile")).Text; }
        }

        public string Fax
        {
            get { return Driver.FindElement(By.CssSelector("#LocationData_Fax")).Text; }
        }

        public IWebElement EditButton
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEdit")); }
        }

        public string Region
        {
            get { return Driver.FindElement(By.CssSelector("#LocationData_Region")).Text; }
        }

        #endregion
    }
}