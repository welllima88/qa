using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Common
{
    public class NavigationBar : WebObject
    {
        public static IWebElement Lobby
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("div#tabNavBar div#ctl00_pnlMainMenu div#menuItems a[href*='/Lobby/']"));
            }
        }

        public static IWebElement Administration
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("div#tabNavBar div#ctl00_pnlMainMenu div#menuItems a[href*='AdminOverview']"));
            }
        }

        public static IWebElement Reporting
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("div#tabNavBar div#ctl00_pnlMainMenu div#menuItems a[href*='AnalysisOverview']"));
            }
        }

        public static IWebElement Help
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