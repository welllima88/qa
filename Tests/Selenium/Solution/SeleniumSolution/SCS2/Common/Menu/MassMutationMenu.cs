using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common.Menu
{
    public class MassMutationMenu : WebObject
    {
        public static IWebElementAdapter CustomerCreate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.MassMutationMenu_CustomerCreate)); }
        }

        public static IWebElementAdapter LocationCreate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.MassMutationMenu_LocationCreate)); }
        }

        public static IWebElementAdapter TerminalCreate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.MassMutationMenu_TerminalCreate)); }
        }

        public static IWebElementAdapter ContractCreate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.MassMutationMenu_ContractCreate)); }
        }

        public static IWebElementAdapter BusinessTemplateMigrate
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.MassMutationMenu_BusinessTemplateMigrate));
            }
        }

        public static IWebElementAdapter AcquirerChange
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.AcquirerChange)); }
        }

        public static IWebElementAdapter MassMutation
        {
            // css=td#leftHandMenu a+div>a[href*='/MassMutation/']
            get
            {
                return WebDriver.FindAdaptedElement(By.XPath("//td[@id='leftHandMenu']//td[text()=' Massenmutation']"));
            }
        }

        public static void Expand(bool doExpand)
        {
            // css=td#leftHandMenu a+div>a[href*='/MassMutation/']

            const string menuName = "Massenmutation";
            IWebElement massMenu =
                WebDriver.FindElement(By.CssSelector("td#leftHandMenu a.level2 td"))
                    .FindElement(By.XPath("//td[text()=' " + menuName + "']"));
            if (massMenu.GetCssValue("class").Contains("expanderOpen") ^ doExpand)
            {
                massMenu.Click();
            }
        }
    }
}