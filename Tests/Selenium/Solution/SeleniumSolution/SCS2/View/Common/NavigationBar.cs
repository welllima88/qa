using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Common
{
    public class NavigationBar : WebObject
    {
        public static IWebElementAdapter Lobby
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("div#tabNavBar div#ctl00_pnlMainMenu div#menuItems a[href*='/Lobby/']"));
            }
        }

        public static IWebElementAdapter Administration
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("div#tabNavBar div#ctl00_pnlMainMenu div#menuItems a[href*='AdminOverview']"));
            }
        }

        public static IWebElementAdapter Reporting
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("div#tabNavBar div#ctl00_pnlMainMenu div#menuItems a[href*='AnalysisOverview']"));
            }
        }

        public static IWebElementAdapter Help
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("div#tabNavBar div#ctl00_pnlMainMenu div#menuItems a[href*='/help']"));
            }
        }
    }
}