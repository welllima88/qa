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

        public static bool Status
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Status")).Selected; }
        }
    }
}