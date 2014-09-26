using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common
{
    public class ApplicationInfo : WebObject
    {
        public static IWebElementAdapter ApplicationName
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("div#applicationBar div.app-name span#ctl00_AppInfo_lblApplicationName"));
            }
        }

        public static IWebElementAdapter Environment
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("div#applicationBar div.app-title span#ctl00_AppInfo_lblEnvironmentText"));
            }
        }
    }
}