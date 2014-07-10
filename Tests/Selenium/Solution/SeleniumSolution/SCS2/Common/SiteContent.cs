using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common
{
    public class SiteContent : WebObject
    {
        public static string Header
        {
            get { return WebDriver.FindElement(By.CssSelector("tbody td#content h1")).Text; }
        }
    }
}