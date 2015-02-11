using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Saferpay.QA.Selenium.Common
{
    public class MetaNavBar
    {
        [FindsBy
        public static IWebElementAdapter LogOff
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("li#text_logout")); }
        }

        public static IWebElementAdapter LogOff
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("li#text_logout")); }
        }
    }
}