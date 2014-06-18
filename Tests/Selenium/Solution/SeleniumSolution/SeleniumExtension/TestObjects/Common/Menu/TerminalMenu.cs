using OpenQA.Selenium;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Common.Menu
{
    public class TerminalMenu : MenuObject
    {
        public static IWebElement Terminal
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalMenu_Terminal)); }
        }

        public static IWebElement ContractCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalMenu_ContractCreate)); }
        }

        public static IWebElement InfotextCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalMenu_InfotextCreate)); }
        }

        public static IWebElement TicketCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalMenu_TicketCreate)); }
        }

        public static IWebElement ServiceCenterCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalMenu_ServiceCenterCreate)); }
        }

        public static IWebElement PmsCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalMenu_PmsCreate)); }
        }

        public static IWebElement Edit
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalMenu_Edit)); }
        }

        public static IWebElement Deactivate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalMenu_Deactivate)); }
        }

        public static IWebElement Duplicate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalMenu_Duplicate)); }
        }

        public static IWebElement Replace
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalMenu_Replace)); }
        }

        public static IWebElement Tickets
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalMenu_Tickets)); }
        }

        public static IWebElement Infotexts
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalMenu_Infotexts)); }
        }

        public static IWebElement Forms
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalMenu_Forms)); }
        }
    }
}