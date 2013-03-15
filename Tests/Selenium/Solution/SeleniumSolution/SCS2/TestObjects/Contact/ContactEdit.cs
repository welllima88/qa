using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Contact
{
    public class ContactEdit : WebObject, IContactEdit
    {
        private readonly ContactCreate _contactCreate;
        private readonly ContactView _contactView;

        public ContactEdit(IWebDriverAdapter driver) : base(driver)
        {
            _contactCreate = new ContactCreate(Driver);
            _contactView = new ContactView(Driver);
        }

        public IWebElement CancelButton
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEdit")); }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnSave")); }
        }

        public IWebElement ClickCancel
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnCancel")); }
        }

        #region IContactEdit Members

        public string FirstName
        {
            set { _contactCreate.FirstName = value; }
        }

        public string Name
        {
            set { _contactCreate.Name = value; }
        }

        public string Salutation
        {
            set { _contactCreate.Salutation = value; }
        }

        public string Country
        {
            set { _contactCreate.Country = value; }
        }

        public string Language
        {
            set { _contactCreate.Language = value; }
        }

        public string Telephone
        {
            set { _contactCreate.Telephone = value; }
        }

        public string Mobile
        {
            set { _contactCreate.Mobile = value; }
        }

        public string Fax
        {
            set { _contactCreate.Fax = value; }
        }

        public string Email
        {
            set { _contactCreate.Email = value; }
        }


        public string Street
        {
            set { _contactCreate.Street = value; }
        }

        public string Po
        {
            set { _contactCreate.Po = value; }
        }

        public string Zip
        {
            set { _contactCreate.Zip = value; }
        }

        public string City
        {
            set { _contactCreate.City = value; }
        }

        public string Region
        {
            set { _contactCreate.Region = value; }
        }

        public string CreateDate
        {
            get { return _contactView.CreateDate; }
        }

        public string Addition
        {
            set { _contactCreate.AddressAddition = value; }
        }

        public IWebElement ClickAdressFromLocation
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnFromLocation")); }
        }

        #endregion
    }
}