using OpenQA.Selenium;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Common.Menu
{
    public class ContactMenu : MenuObject
    {
        public static IWebElement Contact
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(MenuRes.ContactMenu_Contact));
            }
        }

        public static IWebElement ContactEdit
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