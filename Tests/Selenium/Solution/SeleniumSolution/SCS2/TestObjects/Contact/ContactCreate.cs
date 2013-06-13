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
                Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.FirstName)).TypeText(
                    value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.FirstName)).Text; }
        }

        public string Name
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Name)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Name)).Text; }
        }

        public string Salutation
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Salutation)).TypeText(
                    value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Salutation)).Text; }
        }

        public string Country
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(
                    ContactEditRes.Country)).Selector().SelectByText(value);
            }
            get
            {
                return Driver.FindAdaptedElement(By.CssSelector(
                    ContactEditRes.Country)).Selector().SelectedOption.Text;
            }
        }

        public string Language
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector(
                        ContactEditRes.Language)).Selector().SelectByValue(value);
            }
            get
            {
                return Driver.FindAdaptedElement(
                    By.CssSelector(
                        ContactEditRes.Language)).Selector().SelectedOption.Text;
            }
        }

        public string Telephone
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Telephone)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Telephone)).Text; }
        }

        public string Mobile
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Mobile)).TypeText(
                    value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Mobile)).Text; }
        }

        public string Fax
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Fax)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Fax)).Text; }
        }

        public string Email
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Email)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Email)).Text; }
        }


        public string Street
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Street)).TypeText(
                    value);
            }
            get
            {
                return Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Street)).Text;
                ;
            }
        }

        public string Po
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Po)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Po)).Text; }
        }

        public string Zip
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Zip)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Zip)).Text; }
        }

        public string City
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.City)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.City)).Text; }
        }

        public string Region
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Region)).TypeText(
                    value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.Region)).Text; }
        }

        public string AddressAddition
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.AddressAddition)).
                    TypeText(
                        value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactEditRes.AddressAddition)).Text; }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector("input.button[value='Speichern']")); }
        }

        #endregion
    }
}