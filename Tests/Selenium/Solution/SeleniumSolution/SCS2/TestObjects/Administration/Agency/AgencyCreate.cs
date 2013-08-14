using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Administration.Agency
{
    public class AgencyCreate : WebObject, IAgency
    {
        public IWebElement CreateAgencyButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button[name='create']")); }
        }

        public string StreetNo
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_Street")).Text; }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_Street")).TypeText(value); }
        }

        public string Country
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_CountryId")).Text; }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_CountryId")).TypeText(value); }
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
                    WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_SupplierMandantId"))
                             .Selector()
                             .SelectedOption.Text;
            }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_SupplierMandantId"))
                         .Selector()
                         .SelectByText(value);
            }
        }
    }
}