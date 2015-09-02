using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.UI.Administration.Provider
{
    public class View : WebObject
    {
        public static string Name
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Name")).Text; }
        }

        public static string ProviderId
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Provider ID")).Text; }
        }

        public static string Acquirer
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Acquirer")).Text; }
        }

        public static string AcquirerId
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Acquirer ID")).Text; }
        }

        public static string ExternId
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Extern ID")).Text; }
        }

        public static string CardType
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Card Type")).Text; }
        }

        public static string Service
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Service")).Text; }
        }

        public static string DefaultCurrency
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Standardwährung")).Text; }
        }

        public static string IgnoreMpiCache
        {
            get { return WebDriver.FindAdaptedElement(By.Id("MPI Cache ignorieren")).Text; }
        }

        public static string AcquirerBin
        {
            get { return WebDriver.FindAdaptedElement(By.Id("3DS Acquirer BIN")).Text; }
        }

        public static bool DirectoryServer
        {
            get { return WebDriver.FindAdaptedElement(By.Id("ProviderDto_DirectoryId")).Selected; }
        }

        public static bool Currencies
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Währungen")).Selected; }
        }

        public static IEnumerable<string> Softwares
        {
            get { return WebDriver.FindAdaptedElements(By.Id("Softwares")).Select(e => e.Text).ToList(); }
        }
    }
}