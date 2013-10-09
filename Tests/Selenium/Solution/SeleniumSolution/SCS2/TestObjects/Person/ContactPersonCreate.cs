using System;
using OpenQA.Selenium;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Definitions;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Person
{
    public class ContactPersonCreate : WebObject, IContactPerson
    {
        #region IContactCreate Members

        public string AddressAddition
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.AddressAddition)).
                          TypeText(
                              value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.AddressAddition)).Text; }
        }

        public IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input.button[type='submit']")); }
        }

        public string CreateDate { get; private set; }

        public string FirstName
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.FirstName)).TypeText(
                    value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.FirstName)).Text; }
        }

        public string Name
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Name)).TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Name)).Text; }
        }

        public string Salutation
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Salutation)).TypeText(
                    value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Salutation)).Text; }
        }

        public string Country
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(
                    PersonCreateRes.Country)).Selector().SelectByValue(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(
                    PersonCreateRes.Country)).Selector().SelectedOption.Text;
            }
        }

        public string Language
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        PersonCreateRes.Language)).Selector().SelectByValue(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        PersonCreateRes.Language)).Selector().SelectedOption.Text;
            }
        }

        public string Telephone
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Telephone)).TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Telephone)).Text; }
        }

        public string Mobile
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Mobile)).TypeText(
                    value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Mobile)).Text; }
        }

        public string Fax
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Fax)).TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Fax)).Text; }
        }

        public string Email
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Email)).TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Email)).Text; }
        }

        public string Web
        {
            get { throw new NotSupportedException(); }
            set { throw new NotSupportedException(); }
        }

        public string StreetNo
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Street)).TypeText(
                    value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Street)).Text; }
        }

        public string AdressAddition { get; set; }

        public string Po
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Po)).TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Po)).Text; }
        }

        public string Zip
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Zip)).TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Zip)).Text; }
        }

        public string City
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.City)).TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.City)).Text; }
        }

        public string Region
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Region)).TypeText(
                    value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Region)).Text; }
        }

        #endregion
    }
}