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
            get { return Driver.FindAdaptedElement(By.CssSelector(Contact.Name)).Text; }
        }

        public string Salutation
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Contact.Salutation)).TypeText(
                    value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(Contact.Salutation)).Text; }
        }

        public string Country
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(
                    Contact.Country)).Selector().SelectByText(value);
            }
            get
            {
                return Driver.FindAdaptedElement(By.CssSelector(
                    Contact.Country)).Selector().SelectedOption.Text;
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
            get
            {
                return Driver.FindAdaptedElement(
                    By.CssSelector(
                        Contact.Language)).Selector().SelectedOption.Text;
            }
        }

        public string Telephone
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Contact.Telephone)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(Contact.Telephone)).Text; }
        }

        public string Mobile
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Contact.Mobile)).TypeText(
                    value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(Contact.Mobile)).Text; }
        }

        public string Fax
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Contact.Fax)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(Contact.Fax)).Text; }
        }

        public string Email
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Contact.Email)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(Contact.Email)).Text; }
        }


        public string Street
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Contact.Street)).TypeText(
                    value);
            }
            get
            {
                return Driver.FindAdaptedElement(By.CssSelector(Contact.Street)).Text;
                ;
            }
        }

        public string Po
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Contact.Po)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(Contact.Po)).Text; }
        }

        public string Zip
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Contact.Zip)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(Contact.Zip)).Text; }
        }

        public string City
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Contact.City)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(Contact.City)).Text; }
        }

        public string Region
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Contact.Region)).TypeText(
                    value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(Contact.Region)).Text; }
        }

        public string AddressAddition
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Contact.AddressAddition)).
                    TypeText(
                        value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(Contact.AddressAddition)).Text; }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector("input.button[value='Speichern']")); }
        }

        #endregion
    }
}