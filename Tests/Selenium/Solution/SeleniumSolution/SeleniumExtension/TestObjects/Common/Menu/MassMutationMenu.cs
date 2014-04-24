using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu
{
    public class MassMutationMenu : MenuObject
    {
        public static IWebElement CustomerCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.MassMutationMenu_CustomerCreate)); }
        }

        public static IWebElement LocationCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.MassMutationMenu_LocationCreate)); }
        }

        public static IWebElement TerminalCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.MassMutationMenu_TerminalCreate)); }
        }

        public static IWebElement ContractCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.MassMutationMenu_ContractCreate)); }
        }

        public static IWebElement BusinessTemplateMigrate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.MassMutationMenu_BusinessTemplateMigrate)); }
        }

        public static IWebElement AcquirerChange
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.AcquirerChange)); }
        }

        public static IWebElement MassMutation
        {
            get { return WebDriver.FindElement(By.XPath("//td[@id='leftHandMenu']//td[text()=' Massenmutation']")); }
        }
    }
}