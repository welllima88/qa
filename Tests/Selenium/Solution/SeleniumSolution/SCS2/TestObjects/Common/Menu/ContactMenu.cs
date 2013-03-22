using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu
{
    public class ContactMenu : MenuObject
    {
        public ContactMenu(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElement Contact
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(Menu.ContactMenu_Contact));
            }
        }

        public IWebElement ContactEdit
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(Menu.ContactMenu_ContactEdit));
            }
        }
    }
}