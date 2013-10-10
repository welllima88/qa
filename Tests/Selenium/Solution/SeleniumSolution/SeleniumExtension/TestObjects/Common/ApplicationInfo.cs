using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
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