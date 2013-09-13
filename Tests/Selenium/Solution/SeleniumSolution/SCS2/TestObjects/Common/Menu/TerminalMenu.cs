using OpenQA.Selenium;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common.Menu
{
    public class TerminalMenu : MenuObject
    {
        public TerminalAnalysisMenu AnalysisMenu;

        public TerminalMenu()
        {
            AnalysisMenu = new TerminalAnalysisMenu();
        }

        public IWebElement Terminal
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.TerminalMenu_Terminal)); }
        }

        public IWebElement ContractCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.TerminalMenu_ContractCreate)); }
        }

        public IWebElement InfotextCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.TerminalMenu_InfotextCreate)); }
        }

        public IWebElement TicketCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.TerminalMenu_TicketCreate)); }
        }

        public IWebElement ServiceCenterCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.TerminalMenu_ServiceCenterCreate)); }
        }

        public IWebElement PmsCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.TerminalMenu_PmsCreate)); }
        }

        public IWebElement Edit
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.TerminalMenu_Edit)); }
        }

        public IWebElement Deactivate
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.TerminalMenu_Deactivate)); }
        }

        public IWebElement Duplicate
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.TerminalMenu_Duplicate)); }
        }

        public IWebElement Replace
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.TerminalMenu_Replace)); }
        }

        public IWebElement Tickets
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.TerminalMenu_Tickets)); }
        }

        public IWebElement Infotexts
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.TerminalMenu_Infotexts)); }
        }

        public IWebElement Forms
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.TerminalMenu_Forms)); }
        }
    }
}