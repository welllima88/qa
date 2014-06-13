using OpenQA.Selenium;
using SIX.SCS.Tests.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.Tests.Selenium.Extension.TestObjects.Common
{
    public class Footer : WebObject
    {
        public static IWebElement Feedback
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.Footer_Feedback)); }
        }

        public static IWebElement Disclaimer
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.Footer_Disclaimer)); }
        }

        public static IWebElement Copyright
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.Footer_Copyright)); }
        }

        public static IWebElement ScrollUp
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector(CommonRes.Footer_ScrollUp));
            }
        }
    }
}