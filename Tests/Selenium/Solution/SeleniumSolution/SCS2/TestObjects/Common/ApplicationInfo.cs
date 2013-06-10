using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class ApplicationInfo : WebObject
    {
        public ApplicationInfo(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElement ApplicationName
        {
            get { return Driver.FindElement(By.CssSelector(Common.ApplicationInfo_ApplicationName)); }
        }

        public IWebElement Environment
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(Common.ApplicationInfo_Environment));
            }
        }
    }
}