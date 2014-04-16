using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Brand
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
    }
}