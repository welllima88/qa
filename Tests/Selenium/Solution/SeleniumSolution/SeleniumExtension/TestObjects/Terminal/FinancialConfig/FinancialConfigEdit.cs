using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.FinancialConfig
{
    public class FinancialConfigEdit : WebObject
    {
        public static string AdviceQueueSize
        {
            get
            {
                return WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_tbcTerminalData_tpFinancialconfig_tpFinancialconfigPropertyMaxFinAdvQueueSize_valueText"))
                                .GetAttribute("value");
            }
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_tbcTerminalData_tpFinancialconfig_tpFinancialconfigPropertyMaxFinAdvQueueSize_valueText"))
                         .TypeText(value);
            }
        }

        public IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnSave")); }
        }
    }
}