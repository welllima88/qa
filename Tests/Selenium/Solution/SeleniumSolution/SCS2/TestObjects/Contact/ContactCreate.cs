using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

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
                Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.FirstName)).TypeText(
                    value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.FirstName)).Text; }
        }

        public string Name
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Name)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Name)).Text; }
        }

        public string Salutation
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Salutation)).TypeText(
                    value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Salutation)).Text; }
        }

        public string Country
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(
                    ContactCreateRes.Country)).Selector().SelectByText(value);
            }
            get
            {
                return Driver.FindAdaptedElement(By.CssSelector(
                    ContactCreateRes.Country)).Selector().SelectedOption.Text;
            }
        }

        public string Language
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector(
                        ContactCreateRes.Language)).Selector().SelectByValue(value);
            }
            get
            {
                return Driver.FindAdaptedElement(
                    By.CssSelector(
                        ContactCreateRes.Language)).Selector().SelectedOption.Text;
            }
        }

        public string Telephone
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Telephone)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Telephone)).Text; }
        }

        public string Mobile
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Mobile)).TypeText(
                    value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Mobile)).Text; }
        }

        public string Fax
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Fax)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Fax)).Text; }
        }

        public string Email
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Email)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Email)).Text; }
        }


        public string Street
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Street)).TypeText(
                    value);
            }
            get
            {
                return Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Street)).Text;
                ;
            }
        }

        public string Po
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Po)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Po)).Text; }
        }

        public string Zip
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Zip)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Zip)).Text; }
        }

        public string City
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.City)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.City)).Text; }
        }

        public string Region
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Region)).TypeText(
                    value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.Region)).Text; }
        }

        public string AddressAddition
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.AddressAddition)).
                    TypeText(
                        value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactCreateRes.AddressAddition)).Text; }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector("input.button[value='Speichern']")); }
        }

        #endregion
    }
}