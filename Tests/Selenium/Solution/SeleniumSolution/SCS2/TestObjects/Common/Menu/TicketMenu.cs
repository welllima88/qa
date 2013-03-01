using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu
{
    public class TicketMenu : WebObject
    {
        public TicketMenu(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElement NotAssigned
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/TicketList.asp?ListType=notassign']")); }
        }

        public IWebElement MyGroup
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/TicketList.asp?ListType=pending']")); }
        }

        public IWebElement My
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/TicketList.asp?ListType=personal']")); }
        }
    }
}