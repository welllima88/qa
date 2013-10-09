using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.Agency
{
    public class AgencyCreate : WebObject, IAgency
    {
        public IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button#save")); }
        }

        public string SbsAgentId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_SBSAgentId")).Text; }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_SBSAgentId")).TypeText(value); }
        }

        public string Telephone
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_PhoneNumber")).Text; }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_PhoneNumber")).TypeText(value); }
        }

        public string Language
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#Agency_LanguageId"))
                             .Selector()
                             .SelectedOption.Text;
            }
            set { WebDriver.FindAdaptedElement(By.CssSelector("select#Agency_LanguageId")).Selector().SelectByValue(value); }
        }

        public string StreetNo
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_Street")).Text; }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_Street")).TypeText(value); }
        }

        public string Country
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#Agency_CountryId"))
                             .Selector()
                             .SelectedOption.Text;
            }
            set { WebDriver.FindAdaptedElement(By.CssSelector("select#Agency_CountryId")).Selector().SelectByValue(value); }
        }

        public string Zip
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_ZIP")).Text; }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_ZIP")).TypeText(value); }
        }

        public string City
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_City")).Text; }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_City")).TypeText(value); }
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
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_AgencyName")).TypeText(value); }
        }

        public string DisplayName
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_AgencyUserDefinedName")).Text; }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_AgencyUserDefinedName")).TypeText(value); }
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
                         .SelectByText(value);
            }
        }
    }
}