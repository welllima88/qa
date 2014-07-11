using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Brand;

namespace Six.Scs.QA.Selenium.Brand
{
    public class BrandSelect : WebObject
    {
        public static IWebElementAdapter ConfirmButton()
        {
            return WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEditDetails"));
        }

        /// <summary>
        ///     Selects Brands which are to create on a terminal
        /// </summary>
        /// <param name="brand">can be any part of the string e.g. BrandId or/and Name</param>
        public static void Select(string brand)
        {
            // title[textContent~='']
            // By.XPath("//td[text()='" + brand + "']");

            ReadOnlyCollection<IWebElementAdapter> ccss =
                WebDriver.FindAdaptedElements(By.CssSelector("span#ctl00_bodyContentPlaceHolder_trvAvailable div a tr td.data"));
            IWebElementAdapter firstOrDefault = ccss.FirstOrDefault(d => d.Text.Contains(brand));
            if (firstOrDefault != null)
                firstOrDefault.Click();
        }

        public static void Deselect(string brandId)
        {
            WebDriver.FindAdaptedElement(
                By.CssSelector(
                    string.Format("span#ctl00_bodyContentPlaceHolder_lblSelected div a tr td:contains('[{0}]')",
                        brandId))).Click();
        }

        public static void Acquirer(string acquirerName)
        {
            IWebElementAdapter acquirer = WebDriver.FindAdaptedElement(By.XPath("//span"));
        }

        public static void AcquirerList(string acquirerName)
        {
            // css=a[title='Acquirer-Id: SIX Payment Services'] ins
            var acquirers = new Collection<Acquirer>();
        }

        public static IWebElementAdapter BrandTree()
        {
            return WebDriver.FindAdaptedElement(By.CssSelector("div#createContractTree"));
        }
    }
}