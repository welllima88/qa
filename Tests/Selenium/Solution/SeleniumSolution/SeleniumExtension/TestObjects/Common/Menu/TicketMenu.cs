using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu
{
    public class TicketMenu : MenuObject
    {
        public IWebElement NotAssigned
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TicketMenu_NotAssigned)); }
        }

        public IWebElement MyGroup
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TicketMenu_MyGroup)); }
        }

        public IWebElement My
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TicketMenu_My)); }
        }
    }
}