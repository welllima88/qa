using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Brand
{
    public class Selection : WebObject
    {
        public const string Acquirer = "Acqirer";
        public const string Brand = "Provider";

        public static IWebElementAdapter ConfirmButton()
        {
            return WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEditDetails"));
        }

        /// <summary>
        ///     Selects Brands which are to create on a terminal
        /// </summary>
        /// <param name="id">can be any part of the string e.g. BrandId or/and Name</param>
        /// <param name="eType"></param>
        public static void Select(string id, string eType = Brand)
        {
            string locator = "li#" + eType + "_" + id + ".jstree-unchecked.Brand>a ins";
            ClickElement(locator);
        }

        public static void Deselect(string id, string eType = Brand)
        {
            string locator = "li#" + eType + "_" + id + ".jstree-checked.Brand>a ins";
            ClickElement(locator);
        }

        public static void Open(string id, string eType = Acquirer)
        {
            string locator = "li#" + eType + "_" + id + ".jstree-closed a ins.jstree-icon";
            ClickElement(id);
        }

        public static void Close(string id, string eType = Acquirer)
        {
            string locator = "li#" + eType + "_" + id + ".jstree-open a ins.jstree-icon";
            ClickElement(id);
        }

        public static IWebElementAdapter BrandTree()
        {
            return WebDriver.FindAdaptedElement(By.CssSelector("div#createContractTree"));
        }

        private static void ClickElement(string locator)
        {
            IWebElementAdapter d = WebDriver.FindAdaptedElement(By.CssSelector(locator));
            d.Click();
        }
    }
}