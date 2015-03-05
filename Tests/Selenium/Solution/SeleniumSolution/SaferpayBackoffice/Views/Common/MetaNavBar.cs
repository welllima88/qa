using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Saferpay.QA.Selenium.Views.Common
{
    public class MetaNavBar : WebObject
    {
        // [FindsBy(How = How.CssSelector, Using = "li#text_logout a")] public static IWebElementAdapter LogOff;
        public static IWebElementAdapter LogOff
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("li#text_logout a")); }
        }
    }
}