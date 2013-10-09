using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.Agency
{
    public class AgencyView : WebObject, IAgency
    {
        public IWebElement CreateAgencyButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button[name='create']")); }
        }

        public string SbsAgentId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_SBSAgentId")).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Telephone
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_PhoneNumber")).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Language
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_LanguageId")).Text; }
            set { throw new NotSupportedException(); }
        }

        public IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button#save")); }
        }

        public string StreetNo
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_Street")).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Country
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_CountryId")).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Zip
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_ZIP")).Text; }
            set { throw new NotSupportedException(); }
        }

        public string City
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_City")).Text; }
            set { throw new NotSupportedException(); }
        }

        public string AdressAddition
        {
            get { throw new NotSupportedException(); }
            set { throw new NotSupportedException(); }
        }

        public string Po
        {
            get { throw new NotSupportedException(); }
            set { throw new NotSupportedException(); }
        }

        public string Region
        {
            get { throw new NotSupportedException(); }
            set { throw new NotSupportedException(); }
        }

        public string Name
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_AgencyName")).Text; }
            set { throw new NotSupportedException(); }
        }

        public string DisplayName
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_AgencyUserDefinedName")).Text; }
            set { throw new NotSupportedException(); }
        }

        public string Supplier
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#Agency_SupplierMandantId"))
                             .Selector()
                             .SelectedOption.Text;
            }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#Agency_SupplierMandantId"))
                         .Selector()
                         .SelectByValue(value);
            }
        }
    }
}