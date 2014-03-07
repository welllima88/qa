using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Brand
{
    public class ContractSelect : WebObject
    {
        public static IWebElement ConfirmButton()
        {
            return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEditDetails"));
        }

        public static void Select(string brandId)
        {
            WebDriver.FindElement(
                By.CssSelector(
                    string.Format("span#ctl00_bodyContentPlaceHolder_trvAvailable div a tr td:contains('[{0}]')",
                                  brandId))).Click();
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