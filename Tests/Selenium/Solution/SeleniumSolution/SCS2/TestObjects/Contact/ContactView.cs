using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Contact
{
    public class ContactView : WebObject, IContact
    {
        public IWebElement EditButton
        {
            get { return WebDriver.FindElement(By.CssSelector("button[name='edit']")); }
        }

        #region IContactView Members

        public string AddressAddition
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector("#Address_AddressAddition")).Text;
            }
        }

        public string FirstName
        {
            get { return WebDriver.FindElement(By.CssSelector(ContactViewRes.FirstName)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Name
        {
            get { return WebDriver.FindElement(By.CssSelector(ContactViewRes.Name)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Salutation
        {
            get { return WebDriver.FindElement(By.CssSelector(ContactViewRes.Salutation)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Country
        {
            get { return WebDriver.FindElement(By.CssSelector(ContactViewRes.Country)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Language
        {
            get { return WebDriver.FindElement(By.CssSelector(ContactViewRes.Language)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Telephone
        {
            get { return WebDriver.FindElement(By.CssSelector(ContactViewRes.Telephone)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Mobile
        {
            get { return WebDriver.FindElement(By.CssSelector(ContactViewRes.Mobile)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Fax
        {
            get { return WebDriver.FindElement(By.CssSelector(ContactViewRes.Fax)).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Email
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_Email")).Text; }
            set { throw new NotSupportedException(); }
        }

        public string StreetNo
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_Street")).Text; }
            set { throw new NotSupportedException(); }
        }

        public string AdressAddition { get; set; }

        public string Po
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_PO")).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Zip
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_ZIP")).Text; }
            set { throw new NotSupportedException(); }
        }

        public string City
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_City")).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Region
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_Region")).Text; }
            set { throw new NotSupportedException(); }
        }

        public string CreateDate
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_inpCreateDate")).Text; }
        }

        #endregion
    }
}