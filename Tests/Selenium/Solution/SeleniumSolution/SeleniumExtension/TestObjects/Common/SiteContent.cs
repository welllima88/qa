using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
{
    public class SiteContent : WebObject
    {
        public static string Header
        {
            get { return WebDriver.FindElement(By.CssSelector("tbody td#content h1")).Text; }
        }
    }
}