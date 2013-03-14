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
                Driver.FindAdaptedElement(By.CssSelector("input#PersonData_FirstName")).TypeText(
                    value);
            }
        }

        public string Name
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input#PersonData_LastName")).TypeText(value); }
        }

        public string Salutation
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("input#PersonData_Title")).TypeText(
                    value);
            }
        }

        public string Country
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(
                    "select#PersonData_Contact_CountryId")).Selector().SelectByText(value);
            }
        }

        public string Language
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector(
                        "selector#PersonData_Contact_LanguageId")).Selector().SelectByText(value);
            }
        }

        public string Telephone
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Telephone")).TypeText(value); }
        }

        public string Mobile
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Mobile")).TypeText(
                    value);
            }
        }

        public string Fax
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Fax")).TypeText(value); }
        }

        public string Email
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Email")).TypeText(value); }
        }


        public string Street
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Street")).TypeText(
                    value);
            }
        }

        public string Po
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_PO")).TypeText(value); }
        }

        public string Zip
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_ZIP")).TypeText(value); }
        }

        public string City
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_City")).TypeText(value); }
        }

        public string Region
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Region")).TypeText(
                    value);
            }
        }

        public string AddressAddition
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_AddressAddition")).
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