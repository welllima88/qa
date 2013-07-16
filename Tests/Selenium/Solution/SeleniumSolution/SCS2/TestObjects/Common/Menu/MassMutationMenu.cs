using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu
{
    public class MassMutationMenu : MenuObject
    {
        public IWebElement CustomerCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.MassMutationMenu_CustomerCreate)); }
        }

        public IWebElement LocationCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.MassMutationMenu_LocationCreate)); }
        }

        public IWebElement TerminalCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.MassMutationMenu_TerminalCreate)); }
        }

        public IWebElement ContractCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.MassMutationMenu_ContractCreate)); }
        }

        public IWebElement BusinessTemplateMigrate
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.MassMutationMenu_BusinessTemplateMigrate)); }
        }

        public IWebElement AcquirerChange
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.AcquirerChange)); }
        }

        public IWebElement SimCardManage
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.SimCardManagement)); }
        }
    }
}