using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Administration.Provider
{
    public class List : WebObject
    {
        public static string Name
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Name")).Text; }
        }

        public static bool Status
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Status")).Selected; }
        }
    }
}