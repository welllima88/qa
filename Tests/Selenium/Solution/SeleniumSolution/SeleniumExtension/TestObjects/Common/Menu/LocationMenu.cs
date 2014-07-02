using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Common.Menu
{
    public class LocationMenu : WebObject
    {
        public static IWebElement Location
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LocationMenu_Location)); }
        }

        public static IWebElement TerminalCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LocationMenu_TerminalCreate)); }
        }

        public static IWebElement CreateInfotext
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LocationMenu_InfotextCreate)); }
        }

        public static IWebElement ContactCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LocationMenu_ContactCreate)); }
        }

        public static IWebElement LocationEdit
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LocationMenu_LocationEdit)); }
        }

        public static IWebElement LocationQuit
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LocationMenu_LocationQuit)); }
        }

        public static IWebElement Terminals
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LocationMenu_Terminals)); }
        }

        public static IWebElement Contacts
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LocationMenu_Contacts)); }
        }

        public static IWebElement Infotexts
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LocationMenu_Infotexts)); }
        }
    }
}