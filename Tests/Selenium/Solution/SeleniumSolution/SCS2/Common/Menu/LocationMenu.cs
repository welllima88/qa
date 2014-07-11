using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common.Menu
{
    public class LocationMenu : WebObject
    {
        public static IWebElementAdapter Location
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.LocationMenu_Location)); }
        }

        public static IWebElementAdapter TerminalCreate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.LocationMenu_TerminalCreate)); }
        }

        public static IWebElementAdapter CreateInfotext
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.LocationMenu_InfotextCreate)); }
        }

        public static IWebElementAdapter ContactCreate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.LocationMenu_ContactCreate)); }
        }

        public static IWebElementAdapter LocationEdit
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.LocationMenu_LocationEdit)); }
        }

        public static IWebElementAdapter LocationQuit
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.LocationMenu_LocationQuit)); }
        }

        public static IWebElementAdapter Terminals
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.LocationMenu_Terminals)); }
        }

        public static IWebElementAdapter Contacts
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.LocationMenu_Contacts)); }
        }

        public static IWebElementAdapter Infotexts
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.LocationMenu_Infotexts)); }
        }
    }
}