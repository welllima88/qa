using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.FinancialConfig
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