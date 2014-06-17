using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Terminal.FinancialConfig
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
                    .TextBox().Text();
            }
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_tbcTerminalData_tpFinancialconfig_tpFinancialconfigPropertyMaxFinAdvQueueSize_valueText"))
                    .TextBox().TypeText(value);
            }
        }

        public static IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnSave")); }
        }
    }
}