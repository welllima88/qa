using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu
{
    public class ContactMenu : MenuObject
    {
        public IWebElement Contact
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(MenuRes.ContactMenu_Contact));
            }
        }

        public IWebElement ContactEdit
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(MenuRes.ContactMenu_ContactEdit));
            }
        }
    }
}