using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu
{
    public class TicketMenu : MenuObject
    {
        public TicketMenu(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElement NotAssigned
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TicketMenu_NotAssigned)); }
        }

        public IWebElement MyGroup
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TicketMenu_MyGroup)); }
        }

        public IWebElement My
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TicketMenu_My)); }
        }
    }
}