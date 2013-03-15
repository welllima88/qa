using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location
{
    public class BillingAddressView : WebObject
    {
        public BillingAddressView(IWebDriverAdapter driver) : base(driver)
        {
            Prefix = "#LocationData";
        }

        public string CompanyName
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "_LocationName")).Text; }
        }

        public string StreetName
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Prefix + "_Street"))
                        .Text;
            }
        }

        public string Zip
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Prefix + "_ZIP")).Text;
            }
        }

        public string City
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Prefix + "_City")).Text;
            }
        }


        public string Language
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Prefix + "_LanguageId")).Text;
            }
        }

        public string Country
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Prefix + "_CountryId")).Text;
            }
        }


        public string Po
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "_PO")).Text; }
        }

        public string AdressAddition
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "_AddressAddition")).Text; }
        }

        public string Email
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "_Email")).Text; }
        }

        public string Web
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "_Web")).Text; }
        }

        public string Telephone
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "_Telephone")).Text; }
        }

        public string Mobile
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "_Mobile")).Text; }
        }

        public string Fax
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "_Fax")).Text; }
        }

        public IWebElement EditButton
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEdit")); }
        }
    }
}