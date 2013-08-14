using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Person
{
    public class PersonEdit : WebObject, IPerson
    {
        private readonly PersonCreate _personCreate;
        private readonly PersonView _personView;

        public PersonEdit()
        {
            _personCreate = new PersonCreate();
            _personView = new PersonView();
        }

        public IWebElement CancelButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEdit")); }
        }

        public IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnSave")); }
        }

        public IWebElement ClickCancel
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnCancel")); }
        }

        public IWebElement ClickAdressFromLocation
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnFromLocation")); }
        }

        #region IContactEdit Members

        public string CreateDate
        {
            get { return _personView.CreateDate; }
        }

        public string FirstName
        {
            set { _personCreate.FirstName = value; }
            get { return _personCreate.FirstName; }
        }

        public string Name
        {
            set { _personCreate.Name = value; }
            get { return _personCreate.Name; }
        }

        public string Salutation
        {
            set { _personCreate.Salutation = value; }
            get { return _personCreate.Salutation; }
        }

        public string Country
        {
            set { _personCreate.Country = value; }
            get { return _personCreate.Country; }
        }

        public string Language
        {
            set { _personCreate.Language = value; }
            get { return _personCreate.Language; }
        }

        public string Telephone
        {
            set { _personCreate.Telephone = value; }
            get { return _personCreate.Telephone; }
        }

        public string Mobile
        {
            set { _personCreate.Mobile = value; }
            get { return _personCreate.Mobile; }
        }

        public string Fax
        {
            set { _personCreate.Fax = value; }
            get { return _personCreate.Fax; }
        }

        public string Email
        {
            set { _personCreate.Email = value; }
            get { return _personCreate.Email; }
        }

        public string Web
        {
            set { throw new NotSupportedException(); }
            get { throw new NotSupportedException(); }
        }

        public string StreetNo
        {
            set { _personCreate.StreetNo = value; }
            get { return _personCreate.StreetNo; }
        }

        public string Po
        {
            set { _personCreate.Po = value; }
            get { return _personCreate.Po; }
        }

        public string Zip
        {
            set { _personCreate.Zip = value; }
            get { return _personCreate.Zip; }
        }

        public string City
        {
            set { _personCreate.City = value; }
            get { return _personCreate.City; }
        }

        public string Region
        {
            set { _personCreate.Region = value; }
            get { return _personCreate.Region; }
        }

        public string AdressAddition
        {
            set { _personCreate.AddressAddition = value; }
            get { return _personCreate.AddressAddition; }
        }

        #endregion
    }
}