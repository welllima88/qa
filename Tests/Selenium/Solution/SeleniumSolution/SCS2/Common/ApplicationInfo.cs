using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common
{
    public class ApplicationInfo : WebObject
    {
        public static IWebElement ApplicationName
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.ApplicationInfo_ApplicationName)); }
        }

        public static IWebElement Environment
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.ApplicationInfo_Environment)); }
        }
    }
}