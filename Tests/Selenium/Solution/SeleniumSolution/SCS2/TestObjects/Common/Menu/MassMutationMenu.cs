using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu
{
    public class MassMutationMenu : MenuObject
    {
        public MassMutationMenu(IWebDriverAdapter driver) : base(driver)
        {
        }


        public IWebElement CustomerCreate
        {
            get { return Driver.FindElement(By.CssSelector(Menu.MassMutationMenu_CustomerCreate)); }
        }

        public IWebElement LocationCreate
        {
            get { return Driver.FindElement(By.CssSelector(Menu.MassMutationMenu_LocationCreate)); }
        }

        public IWebElement TerminalCreate
        {
            get { return Driver.FindElement(By.CssSelector(Menu.MassMutationMenu_TerminalCreate)); }
        }

        public IWebElement ContractCreate
        {
            get { return Driver.FindElement(By.CssSelector(Menu.MassMutationMenu_ContractCreate)); }
        }

        public IWebElement BusinessTemplateMigrate
        {
            get { return Driver.FindElement(By.CssSelector(Menu.MassMutationMenu_BusinessTemplateMigrate)); }
        }
    }
}