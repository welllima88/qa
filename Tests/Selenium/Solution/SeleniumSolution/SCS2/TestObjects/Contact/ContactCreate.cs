using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Contact
{
    public class ContactCreate : WebObject, IContactCreate
    {
        public ContactCreate(IWebDriverAdapter driver) : base(driver)
        {
        }

        #region IContactCreate Members

        public string FirstName
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Contact.FirstName)).TypeText(
                    value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(Contact.FirstName)).Text; }
        }

        public string Name
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Contact.Name)).TypeText(value); }
        }

        public string Salutation
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Contact.Salutation)).TypeText(
                    value);
            }
        }

        public string Country
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(
                    Contact.Country)).Selector().SelectByText(value);
            }
        }

        public string Language
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector(
                        Contact.Language)).Selector().SelectByText(value);
            }
        }

        public string Telephone
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Contact.Telephone)).TypeText(value); }
        }

        public string Mobile
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Contact.Mobile)).TypeText(
                    value);
            }
        }

        public string Fax
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Contact.Fax)).TypeText(value); }
        }

        public string Email
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Contact.Email)).TypeText(value); }
        }


        public string Street
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Contact.Street)).TypeText(
                    value);
            }
        }

        public string Po
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Contact.Po)).TypeText(value); }
        }

        public string Zip
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Contact.Zip)).TypeText(value); }
        }

        public string City
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Contact.City)).TypeText(value); }
        }

        public string Region
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Contact.Region)).TypeText(
                    value);
            }
        }

        public string AddressAddition
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Contact.AddressAddition)).
                    TypeText(
                        value);
            }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnSave")); }
        }

        #endregion
    }
}