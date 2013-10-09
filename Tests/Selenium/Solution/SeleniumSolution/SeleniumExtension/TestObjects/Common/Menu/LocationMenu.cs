using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu
{
    public class LocationMenu : MenuObject
    {
        public IWebElement Location
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LocationMenu_Location)); }
        }

        public IWebElement TerminalCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LocationMenu_TerminalCreate)); }
        }

        public IWebElement InfotextCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LocationMenu_InfotextCreate)); }
        }

        public IWebElement ContactCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LocationMenu_ContactCreate)); }
        }

        public IWebElement LocationEdit
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LocationMenu_LocationEdit)); }
        }

        public IWebElement LocationQuit
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LocationMenu_LocationQuit)); }
        }

        public IWebElement Terminals
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LocationMenu_Terminals)); }
        }

        public IWebElement Contacts
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LocationMenu_Contacts)); }
        }

        public IWebElement Infotexts
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LocationMenu_Infotexts)); }
        }
    }
}