using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Terminal.Dashboard.Brand;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Brand
{
    public class BrandSelect : WebObject
    {
        public static IWebElement ConfirmButton()
        {
            return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEditDetails"));
        }

        /// <summary>
        ///     Selects Brands which are to create on a terminal
        /// </summary>
        /// <param name="brand">can be any part of the string e.g. BrandId or/and Name</param>
        public static void Select(string brand)
        {
            // title[textContent~='']
            // By.XPath("//td[text()='" + brand + "']");

            ReadOnlyCollection<IWebElement> ccss =
                WebDriver.FindElements(By.CssSelector("span#ctl00_bodyContentPlaceHolder_trvAvailable div a tr td.data"));
            IWebElement firstOrDefault = ccss.FirstOrDefault(d => d.Text.Contains(brand));
            if (firstOrDefault != null)
                firstOrDefault.Click();
        }

        public static void DeSelect(string brandId)
        {
            WebDriver.FindElement(
                By.CssSelector(
                    string.Format("span#ctl00_bodyContentPlaceHolder_lblSelected div a tr td:contains('[{0}]')",
                        brandId))).Click();
        }

        public static void Acquirer(string acquirerName)
        {
            IWebElement acquirer = WebDriver.FindElement(By.XPath("//span"));
        }

        public static void AcquirerList(string acquirerName)
        {
            var acquirers = new Collection<Acquirer>();
        }

        public static IWebElement BrandTree()
        {
            return WebDriver.FindElement(By.CssSelector("div#createContractTree"));
        }
    }
}