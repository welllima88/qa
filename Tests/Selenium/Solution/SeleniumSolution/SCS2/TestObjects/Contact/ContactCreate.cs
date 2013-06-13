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
                Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.FirstName)).TypeText(
                    value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.FirstName)).Text; }
        }

        public string Name
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Name)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Name)).Text; }
        }

        public string Salutation
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Salutation)).TypeText(
                    value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Salutation)).Text; }
        }

        public string Country
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(
                    ContactNewRes.Country)).Selector().SelectByText(value);
            }
            get
            {
                return Driver.FindAdaptedElement(By.CssSelector(
                    ContactNewRes.Country)).Selector().SelectedOption.Text;
            }
        }

        public string Language
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector(
                        ContactNewRes.Language)).Selector().SelectByValue(value);
            }
            get
            {
                return Driver.FindAdaptedElement(
                    By.CssSelector(
                        ContactNewRes.Language)).Selector().SelectedOption.Text;
            }
        }

        public string Telephone
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Telephone)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Telephone)).Text; }
        }

        public string Mobile
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Mobile)).TypeText(
                    value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Mobile)).Text; }
        }

        public string Fax
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Fax)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Fax)).Text; }
        }

        public string Email
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Email)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Email)).Text; }
        }


        public string Street
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Street)).TypeText(
                    value);
            }
            get
            {
                return Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Street)).Text;
                ;
            }
        }

        public string Po
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Po)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Po)).Text; }
        }

        public string Zip
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Zip)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Zip)).Text; }
        }

        public string City
        {
            set { Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.City)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.City)).Text; }
        }

        public string Region
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Region)).TypeText(
                    value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.Region)).Text; }
        }

        public string AddressAddition
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.AddressAddition)).
                    TypeText(
                        value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(ContactNewRes.AddressAddition)).Text; }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector("input.button[value='Speichern']")); }
        }

        #endregion
    }
}