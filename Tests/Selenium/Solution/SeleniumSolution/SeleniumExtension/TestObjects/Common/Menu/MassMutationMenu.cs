using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu
{
    public class MassMutationMenu : MenuObject
    {
        public IWebElement CustomerCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.MassMutationMenu_CustomerCreate)); }
        }

        public IWebElement LocationCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.MassMutationMenu_LocationCreate)); }
        }

        public IWebElement TerminalCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.MassMutationMenu_TerminalCreate)); }
        }

        public IWebElement ContractCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.MassMutationMenu_ContractCreate)); }
        }

        public IWebElement BusinessTemplateMigrate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.MassMutationMenu_BusinessTemplateMigrate)); }
        }

        public IWebElement AcquirerChange
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.AcquirerChange)); }
        }

        public IWebElement SimCardManage
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.SimCardManagement)); }
        }
    }
}