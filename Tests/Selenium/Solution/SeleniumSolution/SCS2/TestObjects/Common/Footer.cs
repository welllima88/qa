using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class Footer : WebObject
    {
        public Footer(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElement Feedback
        {
            get { return Driver.FindElement(By.CssSelector(Common.Footer_Feedback)); }
        }

        public IWebElement Disclaimer
        {
            get { return Driver.FindElement(By.CssSelector(Common.Footer_Disclaimer)); }
        }

        public IWebElement Copyright
        {
            get { return Driver.FindElement(By.CssSelector(Common.Footer_Copyright)); }
        }

        public IWebElement PrintPage
        {
            get { return Driver.FindElement(By.CssSelector(Common.Footer_PrintPage)); }
        }

        public IWebElement ScrollUp
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Common.Footer_ScrollUp));
            }
        }
    }
}