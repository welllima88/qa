using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Terminal.FinancialConfig
{
    public class Edit : WebObject
    {
        public static string AdviceQueueSize
        {
            get
            {
                return WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_tbcTerminalData_tpFinancialconfig_tpFinancialconfigPropertyMaxFinAdvQueueSize_valueText"))
                    .TextField().Text();
            }
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_tbcTerminalData_tpFinancialconfig_tpFinancialconfigPropertyMaxFinAdvQueueSize_valueText"))
                    .TextField().TypeText(value);
            }
        }

        public static IWebElementAdapter SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnSave")); }
        }
    }
}