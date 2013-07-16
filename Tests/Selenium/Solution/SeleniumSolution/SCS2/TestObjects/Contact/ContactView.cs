using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Contact
{
    public class ContactView : WebObject, IContactView
    {
        public IWebElement EditButton
        {
            get { return WebDriver.FindElement(By.CssSelector("button[name='edit']")); }
        }

        #region IContactView Members

        public string FirstName
        {
            get { return WebDriver.FindElement(By.CssSelector(ContactViewRes.FirstName)).Text; }
        }

        public string Name
        {
            get { return WebDriver.FindElement(By.CssSelector(ContactViewRes.Name)).Text; }
        }

        public string Salutation
        {
            get { return WebDriver.FindElement(By.CssSelector(ContactViewRes.Salutation)).Text; }
        }

        public string Country
        {
            get { return WebDriver.FindElement(By.CssSelector(ContactViewRes.Country)).Text; }
        }

        public string Language
        {
            get { return WebDriver.FindElement(By.CssSelector(ContactViewRes.Language)).Text; }
        }

        public string Telephone
        {
            get { return WebDriver.FindElement(By.CssSelector(ContactViewRes.Telephone)).Text; }
        }

        public string Mobile
        {
            get { return WebDriver.FindElement(By.CssSelector(ContactViewRes.Mobile)).Text; }
        }

        public string Fax
        {
            get { return WebDriver.FindElement(By.CssSelector(ContactViewRes.Fax)).Text; }
        }

        public string Email
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_Email")).Text; }
        }


        public string Street
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_Street")).Text; }
        }

        public string Po
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_PO")).Text; }
        }

        public string Zip
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_ZIP")).Text; }
        }

        public string City
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_City")).Text; }
        }

        public string Region
        {
            get { return WebDriver.FindElement(By.CssSelector("#Address_Region")).Text; }
        }

        public string CreateDate
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_inpCreateDate")).Text; }
        }

        public string AddressAddition
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector("#Address_AddressAddition")).Text;
            }
        }

        #endregion
    }
}