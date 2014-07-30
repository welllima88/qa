using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common
{
    public class Footer : WebObject
    {
        public static IWebElementAdapter Disclaimer
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CommonRes.Footer_Disclaimer)); }
        }

        public static IWebElementAdapter Copyright
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CommonRes.Footer_Copyright)); }
        }
    }
}