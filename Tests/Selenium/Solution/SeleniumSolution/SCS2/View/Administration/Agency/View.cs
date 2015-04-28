using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Application.View.Administration.Agency
{
    public class View : WebObject
    {
        public static string SbsAgentId
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Agency_SBSAgentId")).Text; }
        }

        public static string StreetNo
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Agency_Street")).Text; }
        }

        public static string Country
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Agency_CountryName")).Text; }
        }

        public static string Zip
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Agency_ZIP")).Text; }
        }

        public static string City
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Agency_City")).Text; }
        }

        public static string Name
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Agency_AgencyName")).Text; }
        }

        public static string DisplayName
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Agency_AgencyUserDefinedName")).Text; }
        }

        public static string Supplier
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Agency_SupplierMandantName")).Text; }
        }

        public static bool Status
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Agency_IsActive")).CheckBox().IsChecked(); }
        }

        public static void Edit()
        {
            WebDriver.FindAdaptedElement(By.Id("edit")).Button().Click();
        }
    }
}