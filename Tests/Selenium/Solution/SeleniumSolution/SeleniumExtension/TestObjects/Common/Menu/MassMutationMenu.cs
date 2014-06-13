using OpenQA.Selenium;

namespace SIX.SCS.Tests.Selenium.Extension.TestObjects.Common.Menu
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
            // css=td#leftHandMenu a+div>a[href*='/MassMutation/']
            get { return WebDriver.FindElement(By.XPath("//td[@id='leftHandMenu']//td[text()=' Massenmutation']")); }
        }

        public static void Expand(bool doExpand)
        {
            // css=td#leftHandMenu a+div>a[href*='/MassMutation/']

            const string menuName = "Massenmutation";
            IWebElement massMenu = WebDriver.FindElement(By.CssSelector("td#leftHandMenu a.level2 td")).
                FindElement(By.XPath("//td[text()=' " + menuName + "']"));
            if (massMenu.GetCssValue("class").Contains("expanderOpen") ^ doExpand)
            {
                massMenu.Click();
            }
        }
    }
}