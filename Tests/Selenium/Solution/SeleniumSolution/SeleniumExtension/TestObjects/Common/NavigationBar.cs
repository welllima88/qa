using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Common
{
    public class NavigationBar : WebObject
    {
        public static IWebElement Lobby
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(CommonRes.NavigationBar_Lobby));
            }
        }

        public static IWebElement Administration
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(CommonRes.NavigationBar_Administration));
            }
        }

        public static IWebElement Reporting
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(CommonRes.NavigationBar_Reporting));
            }
        }

        public static IWebElement Help
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector("td#tabNavBar div#ctl00_pnlMainMenu div#menuItems a[href*='/scs2/help']"));
            }
        }

        public static IWebElement Current
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.NavigationBar_Current)); }
        }
    }
}