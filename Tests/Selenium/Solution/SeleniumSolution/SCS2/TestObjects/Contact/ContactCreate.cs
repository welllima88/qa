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
                Driver.FindAdaptedElement(By.CssSelector("input#ctl00_bodyContentPlaceHolder_inpFirstName")).TypeText(
                    value);
            }
        }

        public string Name
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input#ctl00_bodyContentPlaceHolder_inpName")).TypeText(value); }
        }

        public string Salutation
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("input#ctl00_bodyContentPlaceHolder_inpSalutation")).TypeText(
                    value);
            }
        }

        public string Country
        {
            set
            {
                Driver.FindSuggesterElement(By.CssSelector(
                    "#ctl00_bodyContentPlaceHolder_sugCountrytbx")).Suggestor(value);
            }
        }

        public string Language
        {
            set
            {
                Driver.FindSuggesterElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_sugLanguagetbx")).Suggestor(value);
            }
        }

        public string Telephone
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input#ctl00_bodyContentPlaceHolder_inpPhone")).TypeText(value); }
        }

        public string Mobile
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("input#ctl00_bodyContentPlaceHolder_inpMobile")).TypeText(
                    value);
            }
        }

        public string Fax
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input#ctl00_bodyContentPlaceHolder_inpFax")).TypeText(value); }
        }

        public string Email
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input#ctl00_bodyContentPlaceHolder_inpMail")).TypeText(value); }
        }


        public string Street
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("input#ctl00_bodyContentPlaceHolder_inpStreet")).TypeText(
                    value);
            }
        }

        public string Po
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input#ctl00_bodyContentPlaceHolder_inpPOBox")).TypeText(value); }
        }

        public string Zip
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input#ctl00_bodyContentPlaceHolder_inpZIP")).TypeText(value); }
        }

        public string City
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input#ctl00_bodyContentPlaceHolder_inpCity")).TypeText(value); }
        }

        public string Region
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("input#ctl00_bodyContentPlaceHolder_inpRegion")).TypeText(
                    value);
            }
        }

        public string AddressAddition
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("input#ctl00_bodyContentPlaceHolder_inpAddressAddition")).
                    TypeText(
                        value);
            }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnSave")); }
        }

        public IWebElement AdressFromLocationButton
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnFromLocation")); }
        }

        public IWebElement CancelButton
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnCancel")); }
        }

        #endregion
    }
}