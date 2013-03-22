using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu
{
    public class TerminalMenu : MenuObject
    {
        public TerminalAnalysisMenu AnalysisMenu;

        public TerminalMenu(IWebDriverAdapter driver) : base(driver)
        {
            AnalysisMenu = new TerminalAnalysisMenu(Driver);
        }

        public IWebElement Terminal
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalMenu_Terminal)); }
        }

        public IWebElement ContractCreate
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalMenu_ContractCreate)); }
        }

        public IWebElement InfotextCreate
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalMenu_InfotextCreate)); }
        }

        public IWebElement TicketCreate
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalMenu_TicketCreate)); }
        }

        public IWebElement ServiceCenterCreate
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalMenu_ServiceCenterCreate)); }
        }

        public IWebElement PmsCreate
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalMenu_PmsCreate)); }
        }

        public IWebElement Edit
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalMenu_Edit)); }
        }

        public IWebElement Deactivate
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalMenu_Deactivate)); }
        }

        public IWebElement Duplicate
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalMenu_Duplicate)); }
        }

        public IWebElement Replace
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalMenu_Replace)); }
        }

        public IWebElement Tickets
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalMenu_Tickets)); }
        }

        public IWebElement Infotexts
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalMenu_Infotexts)); }
        }

        public IWebElement Forms
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalMenu_Forms)); }
        }
    }
}