using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu
{
    public class LocationMenu : MenuObject
    {
        public LocationMenu(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElement Location
        {
            get { return Driver.FindElement(By.CssSelector(Menu.LocationMenu_Location)); }
        }


        public IWebElement TerminalCreate
        {
            get { return Driver.FindElement(By.CssSelector(Menu.LocationMenu_TerminalCreate)); }
        }

        public IWebElement InfotextCreate
        {
            get { return Driver.FindElement(By.CssSelector(Menu.LocationMenu_InfotextCreate)); }
        }

        public IWebElement ContactCreate
        {
            get { return Driver.FindElement(By.CssSelector(Menu.LocationMenu_ContactCreate)); }
        }

        public IWebElement LocationEdit
        {
            get { return Driver.FindElement(By.CssSelector(Menu.LocationMenu_LocationEdit)); }
        }

        public IWebElement LocationQuit
        {
            get { return Driver.FindElement(By.CssSelector(Menu.LocationMenu_LocationQuit)); }
        }

        public IWebElement Terminals
        {
            get { return Driver.FindElement(By.CssSelector(Menu.LocationMenu_Terminals)); }
        }

        public IWebElement Contacts
        {
            get { return Driver.FindElement(By.CssSelector(Menu.LocationMenu_Contacts)); }
        }

        public IWebElement Infotexts
        {
            get { return Driver.FindElement(By.CssSelector(Menu.LocationMenu_Infotexts)); }
        }
    }
}