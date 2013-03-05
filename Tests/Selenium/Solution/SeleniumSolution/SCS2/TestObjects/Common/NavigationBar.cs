using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class NavigationBar : WebObject
    {
        public NavigationBar(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElement Lobby
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("td#tabNavBar div#ctl00_pnlMainMenu div#menuItems a[href*='Default']"));
            }
            //todod: ... [text*='Lobby'] doesnt work...why??
        }

        public IWebElement Administration
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("td#tabNavBar div#ctl00_pnlMainMenu div#menuItems a[href*='AdminOverview']"));
            }
        }

        public IWebElement Reporting
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("td#tabNavBar div#ctl00_pnlMainMenu div#menuItems a[href*='AnalysisOverview']"));
            }
        }

        public IWebElement MoreMenu
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("td#tabNavBar div#ctl00_pnlMainMenu div#menuItems a#ctl00_hplMenuMore.moreLink"));
            }
        }

        public IWebElement Help
        {
            get
            {
                //return Driver.FindElement(By.CssSelector("div.menuMore a[text=\"Hilfe\"]")); 
                return Driver.FindElement(By.XPath("//div[@class='menuMore']/a[text()='Hilfe']"));
            }
        }

        public IWebElement SystemInfo
        {
            get { return Driver.FindElement(By.XPath("//div[@class='menuMore']/a[text()='Systeminfo']")); }
        }

        public IWebElement Current
        {
            get { return Driver.FindElement(By.CssSelector("a#ctl00_hplMenuMenuCurrent")); }
        }
    }
}