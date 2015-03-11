using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Administration.Provider
{
    public class View : WebObject
    {
        public static string Name
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Name")).Text; }
        }

        public static string ProviderId
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Name")).Text; }
        }

        public static string AcquirerId
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Name")).Text; }
        }

        public static string ExternId
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Name")).Text; }
        }

        public static bool CardType
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Status")).Selected; }
        }

        public static bool Service
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Status")).Selected; }
        }

        public static bool DefaultCurrency
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Status")).Selected; }
        }

        public static bool IgnoreMPICache
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Status")).Selected; }
        }

        public static bool AcquirerBIN
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Status")).Selected; }
        }

        public static bool DirectoryServer
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Status")).Selected; }
        }
        public static bool Currencies
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Status")).Selected; }
        }
        public static bool Softwares
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Status")).Selected; }
        }
    }
}