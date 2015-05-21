using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Common
{
    public class Footer : WebObject
    {
        public static IWebElementAdapter Disclaimer
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("td#footerNavigationBar>a[href*='/disclaimer.aspx']"));
            }
        }

        public static IWebElementAdapter Copyright
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#footerNavigationBar>div#copyright")); }
        }
    }
}