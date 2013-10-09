using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
{
    public class NavigationBar : WebObject
    {
        public IWebElement Lobby
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(CommonRes.NavigationBar_Lobby));
            }
        }

        public IWebElement Administration
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(CommonRes.NavigationBar_Administration));
            }
        }

        public IWebElement Reporting
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(CommonRes.NavigationBar_Reporting));
            }
        }

        public IWebElement MoreMenu
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(CommonRes.NavigationBar_MoreMenu));
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
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.NavigationBar_Current)); }
        }
    }
}