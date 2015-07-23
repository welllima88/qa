using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Contract
{
    public class Selection : WebObject
    {
        public const string Acquirer = "Acquirer";
        public const string Brand = "Provider";

        public static IWebElement ConfirmButton()
        {
            return WebDriver.FindAdaptedElement(By.Id("next"));
        }

        public static IWebElement CancelButton()
        {
            return WebDriver.FindAdaptedElement(By.Id("cancel"));
        }

        /// <summary>
        ///     Selects Brands which are to create on a terminal
        /// </summary>
        /// <param name="id">can be any part of the string e.g. BrandId or/and Name</param>
        /// <param name="eType"></param>
        public static void Select(string id, string eType = Brand)
        {
            var locator = "li#" + eType + "_" + id + ".jstree-unchecked.Brand>a ins";
            ClickElement(locator);
        }

        public static void Deselect(string id, string eType = Brand)
        {
            var locator = "li#" + eType + "_" + id + ".jstree-checked.Brand>a ins";
            ClickElement(locator);
        }

        public static void Open(string id, string eType = Acquirer)
        {
            var locator = "li#" + eType + "_" + id + ".jstree-closed>ins.jstree-icon";
            ClickElement(locator);
        }

        public static void Close(string id, string eType = Acquirer)
        {
            var locator = "li#" + eType + "_" + id + ".jstree-open>ins.jstree-icon";
            ClickElement(locator);
        }

        public static IWebElement BrandTree()
        {
            return WebDriver.FindAdaptedElement(By.CssSelector("div#createContractTree"));
        }

        private static void ClickElement(string locator)
        {
            var d = WebDriver.FindAdaptedElement(By.CssSelector(locator));
            d.Click();
        }
    }
}