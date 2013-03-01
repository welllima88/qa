using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Contact
{
    public class ContactView : WebObject
    {
        public ContactView(IWebDriverAdapter driver) : base(driver)
        {
        }

        public string FirstName
        {
            get { return Driver.FindElement(By.CssSelector("#Person_FirstName")).Text; }
        }

        public string Name
        {
            get { return Driver.FindElement(By.CssSelector("#Person_LastName")).Text; }
        }

        public string Salutation
        {
            get { return Driver.FindElement(By.CssSelector("#Person_Title")).Text; }
        }

        public string Country
        {
            get { return Driver.FindElement(By.CssSelector("#Address_Country")).Text; }
        }

        public string Language
        {
            get { return Driver.FindElement(By.CssSelector("#Address_Language")).Text; }
        }

        public string Telephone
        {
            get { return Driver.FindElement(By.CssSelector("#Address_Telephone")).Text; }
        }

        public string Mobile
        {
            get { return Driver.FindElement(By.CssSelector("#Address_Telephone2")).Text; }
        }

        public string Fax
        {
            get { return Driver.FindElement(By.CssSelector("#Address_Fax")).Text; }
        }

        public string Email
        {
            get { return Driver.FindElement(By.CssSelector("#Address_Email")).Text; }
        }


        public string Street
        {
            get { return Driver.FindElement(By.CssSelector("#Address_Street")).Text; }
        }

        public string Po
        {
            get { return Driver.FindElement(By.CssSelector("#Address_PO")).Text; }
        }

        public string Zip
        {
            get { return Driver.FindElement(By.CssSelector("#Address_ZIP")).Text; }
        }

        public string City
        {
            get { return Driver.FindElement(By.CssSelector("#Address_City")).Text; }
        }

        public string Region
        {
            get { return Driver.FindElement(By.CssSelector("#Address_Region")).Text; }
        }

        public string CreateDate
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_inpCreateDate")).Text; }
        }

        public string AddressAddition
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("#Address_AddressAddition")).Text;
            }
        }

        public IWebElement EditButton
        {
            get { return Driver.FindElement(By.CssSelector("button[name='edit']")); }
        }
    }
}