using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Location
{
    public class BillingAddressView : WebObject
    {
        public string CompanyName
        {
            get { return WebDriver.FindElement(By.CssSelector("#LocationData_LocationName")).Text; }
        }

        public string StreetName
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#LocationData_Street"))
                             .Text;
            }
        }

        public string Zip
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#LocationData_ZIP")).Text;
            }
        }

        public string City
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#LocationData_City")).Text;
            }
        }

        public string Language
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#LocationData_LanguageId")).Text;
            }
        }

        public string Country
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#LocationData_CountryId")).Text;
            }
        }

        public string Po
        {
            get { return WebDriver.FindElement(By.CssSelector("#LocationData_PO")).Text; }
        }

        public string AdressAddition
        {
            get { return WebDriver.FindElement(By.CssSelector("#LocationData_AddressAddition")).Text; }
        }

        public string Email
        {
            get { return WebDriver.FindElement(By.CssSelector("#LocationData_Email")).Text; }
        }

        public string Web
        {
            get { return WebDriver.FindElement(By.CssSelector("#LocationData_Web")).Text; }
        }

        public string Telephone
        {
            get { return WebDriver.FindElement(By.CssSelector("#LocationData_Telephone")).Text; }
        }

        public string Mobile
        {
            get { return WebDriver.FindElement(By.CssSelector("#LocationData_Mobile")).Text; }
        }

        public string Fax
        {
            get { return WebDriver.FindElement(By.CssSelector("#LocationData_Fax")).Text; }
        }

        public IWebElement EditButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEdit")); }
        }
    }
}