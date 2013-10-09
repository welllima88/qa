using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Location
{
    public class BillingAddressEdit : WebObject
    {
        private readonly BillingAddressCreate _billingAddressCreate;

        public BillingAddressEdit()
        {
            _billingAddressCreate = new BillingAddressCreate();
        }

        public string CompanyName
        {
            set { _billingAddressCreate.CompanyName = value; }
        }

        public string StreetName
        {
            set { _billingAddressCreate.StreetName = value; }
        }

        public string Language
        {
            set { _billingAddressCreate.Language = value; }
        }

        public string Country
        {
            set { _billingAddressCreate.Country = value; }
        }

        public string Zip
        {
            set { _billingAddressCreate.Zip = value; }
        }

        public string City
        {
            set { _billingAddressCreate.City = value; }
        }

        public string AdressAddition
        {
            set { _billingAddressCreate.AdressAddition = value; }
        }

        public string Po
        {
            set { _billingAddressCreate.Po = value; }
        }

        public string Region
        {
            set { _billingAddressCreate.Region = value; }
        }

        public string Telephone
        {
            set { _billingAddressCreate.Telephone = value; }
        }

        public string Mobile
        {
            set { _billingAddressCreate.Mobile = value; }
        }

        public string Fax
        {
            set { _billingAddressCreate.Fax = value; }
        }

        public string Email
        {
            set { _billingAddressCreate.Email = value; }
        }

        public string Web
        {
            set { _billingAddressCreate.Web = value; }
        }

        public IWebElement SaveButton
        {
            get { return _billingAddressCreate.SaveButton; }
        }

        public IWebElement CancelButton
        {
            get { return WebDriver.FindElement(By.CssSelector("button[name='cancel']")); }
        }
    }
}