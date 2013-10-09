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