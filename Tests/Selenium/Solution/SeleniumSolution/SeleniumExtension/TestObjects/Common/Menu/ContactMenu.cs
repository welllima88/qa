using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Common.Menu
{
    public class ContactMenu : WebObject
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