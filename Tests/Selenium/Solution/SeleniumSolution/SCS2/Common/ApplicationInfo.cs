using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

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
                        By.CssSelector("div#applicationBar div.app-name span"));
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

        public static ButtonElement Support
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("div#applicationBar div.alert div.app-name>a"))
                    .Button();
            }
        }

        public static IWebElementAdapter SupportDialog
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("div.modal-dialog")); }
        }
    }
}