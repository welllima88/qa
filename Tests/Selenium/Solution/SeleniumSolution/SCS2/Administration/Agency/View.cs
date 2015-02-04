using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Administration.Agency
{
    public class View : WebObject
    {
        public static string SbsAgentId
        {
            get { return WebDriver.FindAdaptedElement(By.Id("AgencySBSAgent")).Text; }
        }

        public static string Telephone
        {
            get { return WebDriver.FindAdaptedElement(By.Id("AgencyPhoneNumber")).Text; }
        }

        public static string Language
        {
            get { return WebDriver.FindAdaptedElement(By.Id("AgencyLanguage")).Text; }
        }

        public static string StreetNo
        {
            get { return WebDriver.FindAdaptedElement(By.Id("AgencyStreet")).Text; }
        }

        public static string Country
        {
            get { return WebDriver.FindAdaptedElement(By.Id("AgencyCountry")).Text; }
        }

        public static string Zip
        {
            get { return WebDriver.FindAdaptedElement(By.Id("AgencyPLZ")).Text; }
        }

        public static string City
        {
            get { return WebDriver.FindAdaptedElement(By.Id("AgencyCity")).Text; }
        }

        public static string Name
        {
            get { return WebDriver.FindAdaptedElement(By.Id("AgencyName")).Text; }
        }

        public static string DisplayName
        {
            get { return WebDriver.FindAdaptedElement(By.Id("AgencyUserDefinedName")).Text; }
        }

        public static string Supplier
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Mandant")).Text; }
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