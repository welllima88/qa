using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class Footer : WebObject
    {
        public Footer(IWebDriverAdapter driver) : base(driver)
        {
            Prefix = "td#footerNavigationBar>";
        }

        public IWebElement Feedback
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "a#ctl00_hplFeedback")); }
        }

        public IWebElement Disclaimer
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "a[href*='/disclaimer.aspx']")); }
        }

        public IWebElement Copyright
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "div#copyright")); }
        }

        public IWebElement PrintPage
        {
            get { return Driver.FindElement(By.CssSelector("td#footerFunctionBar>a[href*='JavaScript:Page.Print()']")); }
        }

        public IWebElement ScrollUp
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("td#footerFunctionBar>a[href*='JavaScript:window.scroll(0,0)']"));
            }
        }
    }
}