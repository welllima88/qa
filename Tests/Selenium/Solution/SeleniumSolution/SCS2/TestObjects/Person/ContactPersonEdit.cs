using System;
using OpenQA.Selenium;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Definitions;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Person
{
    public class ContactPersonEdit : WebObject, IContactPerson
    {
        private readonly ContactPersonCreate _contactPersonCreate;
        private readonly ContactPersonView _contactPersonView;

        public ContactPersonEdit()
        {
            _contactPersonCreate = new ContactPersonCreate();
            _contactPersonView = new ContactPersonView();
        }

        public IWebElement CancelButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEdit")); }
        }

        public IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnSave")); }
        }

        public IWebElement ClickAdressFromLocation
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnFromLocation")); }
        }

        #region IContactEdit Members

        public string CreateDate
        {
            get { return _contactPersonView.CreateDate; }
        }

        public string FirstName
        {
            set { _contactPersonCreate.FirstName = value; }
            get { return _contactPersonCreate.FirstName; }
        }

        public string Name
        {
            set { _contactPersonCreate.Name = value; }
            get { return _contactPersonCreate.Name; }
        }

        public string Salutation
        {
            set { _contactPersonCreate.Salutation = value; }
            get { return _contactPersonCreate.Salutation; }
        }

        public string Country
        {
            set { _contactPersonCreate.Country = value; }
            get { return _contactPersonCreate.Country; }
        }

        public string Language
        {
            set { _contactPersonCreate.Language = value; }
            get { return _contactPersonCreate.Language; }
        }

        public string Telephone
        {
            set { _contactPersonCreate.Telephone = value; }
            get { return _contactPersonCreate.Telephone; }
        }

        public string Mobile
        {
            set { _contactPersonCreate.Mobile = value; }
            get { return _contactPersonCreate.Mobile; }
        }

        public string Fax
        {
            set { _contactPersonCreate.Fax = value; }
            get { return _contactPersonCreate.Fax; }
        }

        public string Email
        {
            set { _contactPersonCreate.Email = value; }
            get { return _contactPersonCreate.Email; }
        }

        public string Web
        {
            set { throw new NotSupportedException(); }
            get { throw new NotSupportedException(); }
        }

        public string StreetNo
        {
            set { _contactPersonCreate.StreetNo = value; }
            get { return _contactPersonCreate.StreetNo; }
        }

        public string Po
        {
            set { _contactPersonCreate.Po = value; }
            get { return _contactPersonCreate.Po; }
        }

        public string Zip
        {
            set { _contactPersonCreate.Zip = value; }
            get { return _contactPersonCreate.Zip; }
        }

        public string City
        {
            set { _contactPersonCreate.City = value; }
            get { return _contactPersonCreate.City; }
        }

        public string Region
        {
            set { _contactPersonCreate.Region = value; }
            get { return _contactPersonCreate.Region; }
        }

        public string AdressAddition
        {
            set { _contactPersonCreate.AddressAddition = value; }
            get { return _contactPersonCreate.AddressAddition; }
        }

        #endregion
    }
}