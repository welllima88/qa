using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common
{
    public class ApplicationInfo : WebObject
    {
        public static IWebElementAdapter ApplicationName
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CommonRes.ApplicationInfo_ApplicationName)); }
        }

        public static IWebElementAdapter Environment
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CommonRes.ApplicationInfo_Environment)); }
        }
    }
}