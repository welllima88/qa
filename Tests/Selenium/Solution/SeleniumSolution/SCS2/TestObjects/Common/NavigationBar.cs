using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class NavigationBar : WebObject
    {
        public IWebElement Lobby
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(Common.NavigationBar_Lobby));
            }
        }

        public IWebElement Administration
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(Common.NavigationBar_Administration));
            }
        }

        public IWebElement Reporting
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(Common.NavigationBar_Reporting));
            }
        }

        public IWebElement MoreMenu
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(Common.NavigationBar_MoreMenu));
            }
        }

        public IWebElement Help
        {
            get
            {
                return WebDriver.FindElement(By.CssSelector("div.menuMore>a.first"));
                //return WebDriver.FindElement(By.CssSelector("div.menuMore a[text=\"Hilfe\"]")); 
                //return WebDriver.FindElement(By.XPath("//div[@class='menuMore']/a[text()='Hilfe']"));
            }
        }

        public IWebElement SystemInfo
        {
            get { return WebDriver.FindElement(By.CssSelector("div.menuMore>a.last")); }
        }

        public IWebElement Current
        {
            get { return WebDriver.FindElement(By.CssSelector(Common.NavigationBar_Current)); }
        }
    }
}