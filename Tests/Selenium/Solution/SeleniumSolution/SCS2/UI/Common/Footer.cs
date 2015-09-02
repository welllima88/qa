using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Common
{
    public class Footer : WebObject
    {
        public static IWebElement Disclaimer
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("td#footerNavigationBar>a[href*='/disclaimer.aspx']"));
            }
        }

        public static IWebElement Copyright
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#footerNavigationBar>div#copyright")); }
        }
    }
}