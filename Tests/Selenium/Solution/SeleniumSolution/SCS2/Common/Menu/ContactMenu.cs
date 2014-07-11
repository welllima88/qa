using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common.Menu
{
    public class ContactMenu : WebObject
    {
        public static ButtonElement Contact
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(MenuRes.ContactMenu_Contact)).Button();
            }
        }

        public static ButtonElement ContactEdit
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(MenuRes.ContactMenu_ContactEdit)).Button();
            }
        }
    }
}