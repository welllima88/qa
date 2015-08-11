using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Customer
{
    internal class Move : WebObject
    {
        public static string TargetCustomerId
        {
            set
            {
                WebDriver.FindAdaptedElement(By.Id("inputTargetCustomer")).TextField().TypeText(value);
                var locator = By.CssSelector("li.ui-menu-item>a");
                WebDriver.WebDriverWait()
                    .Until(d => d.FindElement(locator).Displayed);
                WebDriver.FindAdaptedElement(locator).Click();
            }
        }

        public static void Execute()
        {
            WebDriver.SwitchTo().Alert().Accept();
            WebDriver.FindAdaptedElement(By.Id("send"));
        }
    }
}