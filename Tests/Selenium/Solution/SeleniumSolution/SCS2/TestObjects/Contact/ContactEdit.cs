using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

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

        public IWebElement ClickAdressFromLocation
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnFromLocation")); }
        }

        #region IContactEdit Members

        public string FirstName
        {
            set { _contactCreate.FirstName = value; }
            get { return _contactCreate.FirstName; }
        }

        public string Name
        {
            set { _contactCreate.Name = value; }
            get { return _contactCreate.Name; }
        }

        public string Salutation
        {
            set { _contactCreate.Salutation = value; }
            get { return _contactCreate.Salutation; }
        }

        public string Country
        {
            set { _contactCreate.Country = value; }
            get { return _contactCreate.Country; }
        }

        public string Language
        {
            set { _contactCreate.Language = value; }
            get { return _contactCreate.Language; }
        }

        public string Telephone
        {
            set { _contactCreate.Telephone = value; }
            get { return _contactCreate.Telephone; }
        }

        public string Mobile
        {
            set { _contactCreate.Mobile = value; }
            get { return _contactCreate.Mobile; }
        }

        public string Fax
        {
            set { _contactCreate.Fax = value; }
            get { return _contactCreate.Fax; }
        }

        public string Email
        {
            set { _contactCreate.Email = value; }
            get { return _contactCreate.Email; }
        }


        public string Street
        {
            set { _contactCreate.Street = value; }
            get { return _contactCreate.Street; }
        }

        public string Po
        {
            set { _contactCreate.Po = value; }
            get { return _contactCreate.Po; }
        }

        public string Zip
        {
            set { _contactCreate.Zip = value; }
            get { return _contactCreate.Zip; }
        }

        public string City
        {
            set { _contactCreate.City = value; }
            get { return _contactCreate.City; }
        }

        public string Region
        {
            set { _contactCreate.Region = value; }
            get { return _contactCreate.Region; }
        }

        public string CreateDate
        {
            get { return _contactView.CreateDate; }
        }

        public string Addition
        {
            set { _contactCreate.AddressAddition = value; }
            get { return _contactCreate.AddressAddition; }
        }

        #endregion
    }
}