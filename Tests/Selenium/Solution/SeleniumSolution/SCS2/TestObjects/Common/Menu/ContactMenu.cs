using OpenQA.Selenium;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common.Menu
{
    public class ContactMenu : MenuObject
    {
        public IWebElement Contact
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(Menu.ContactMenu_Contact));
            }
        }

        public IWebElement ContactEdit
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(Menu.ContactMenu_ContactEdit));
            }
        }
    }
}