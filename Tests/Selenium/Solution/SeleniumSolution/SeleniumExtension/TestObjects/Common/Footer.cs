using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
{
    public class Footer : WebObject
    {
        public IWebElement Feedback
        {
            get { return WebDriver.FindElement(By.CssSelector(Common.Footer_Feedback)); }
        }

        public IWebElement Disclaimer
        {
            get { return WebDriver.FindElement(By.CssSelector(Common.Footer_Disclaimer)); }
        }

        public IWebElement Copyright
        {
            get { return WebDriver.FindElement(By.CssSelector(Common.Footer_Copyright)); }
        }

        public IWebElement PrintPage
        {
            get { return WebDriver.FindElement(By.CssSelector(Common.Footer_PrintPage)); }
        }

        public IWebElement ScrollUp
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector(Common.Footer_ScrollUp));
            }
        }
    }
}