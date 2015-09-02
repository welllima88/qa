using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Common
{
    public class ApplicationInfo : WebObject
    {
        public static IWebElement ApplicationName
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("div#applicationBar div.app-name span"));
            }
        }

        public static IWebElement Environment
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

        public static IWebElement SupportDialog
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("div.modal-dialog")); }
        }
    }
}