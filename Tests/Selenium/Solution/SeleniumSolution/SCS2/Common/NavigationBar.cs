using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common
{
    public class NavigationBar : WebObject
    {
        public static IWebElementAdapter Lobby
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(CommonRes.NavigationBar_Lobby));
            }
        }

        public static IWebElementAdapter Administration
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(CommonRes.NavigationBar_Administration));
            }
        }

        public static IWebElementAdapter Reporting
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(CommonRes.NavigationBar_Reporting));
            }
        }

        public static IWebElementAdapter Help
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#tabNavBar div#ctl00_pnlMainMenu div#menuItems a[href*='/scs2/help']"));
            }
        }

        public static IWebElementAdapter Current
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CommonRes.NavigationBar_Current)); }
        }
    }
}