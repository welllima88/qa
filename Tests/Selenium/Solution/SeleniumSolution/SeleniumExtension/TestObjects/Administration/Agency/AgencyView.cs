using System;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.Agency
{
    public class AgencyView : WebObject
    {
        public static IWebElement CreateAgencyButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button[name='create']")); }
        }

        public static string SbsAgentId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_SBSAgentId")).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Telephone
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_PhoneNumber")).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Language
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_LanguageId")).Text; }
            set { throw new NotSupportedException(); }
        }

        public static IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button#save")); }
        }

        public static string StreetNo
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_Street")).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Country
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_CountryId")).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Zip
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_ZIP")).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string City
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

        public static string Name
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_AgencyName")).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string DisplayName
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_AgencyUserDefinedName")).Text; }
            set { throw new NotSupportedException(); }
        }

        public static string Supplier
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