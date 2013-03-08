using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class ApplicationInfo : WebObject
    {
        public ApplicationInfo(IWebDriverAdapter driver) : base(driver)
        {
            Prefix = "div#applicationBar div#applicationInformation ";
        }

        public IWebElement ApplicationName
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "span#ctl00_lblApplicationName")); }
        }

        public IWebElement Environment
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(Prefix + "span#ctl00_lblEnvironmentText"));
            }
        }
    }
}