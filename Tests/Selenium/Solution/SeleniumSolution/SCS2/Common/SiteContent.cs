using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common
{
    public class SiteContent : WebObject
    {
        public static string Header
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("tbody td#content h1")).Text; }
        }
    }
}