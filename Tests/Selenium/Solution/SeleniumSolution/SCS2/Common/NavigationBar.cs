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
                        By.CssSelector("td#tabNavBar div#ctl00_pnlMainMenu div#menuItems a[href*='/Lobby/']"));
            }
        }

        public static IWebElementAdapter Administration
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#tabNavBar div#ctl00_pnlMainMenu div#menuItems a[href*='AdminOverview']"));
            }
        }

        public static IWebElementAdapter Reporting
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#tabNavBar div#ctl00_pnlMainMenu div#menuItems a[href*='AnalysisOverview']"));
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
    }
}