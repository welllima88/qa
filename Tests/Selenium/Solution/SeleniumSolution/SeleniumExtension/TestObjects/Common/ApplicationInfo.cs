using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
{
    public class ApplicationInfo : WebObject
    {
        public IWebElement ApplicationName
        {
            get { return WebDriver.FindElement(By.CssSelector(Common.ApplicationInfo_ApplicationName)); }
        }

        public IWebElement Environment
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(Common.ApplicationInfo_Environment));
            }
        }
    }
}