using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard
{
    /// <summary>
    ///     Terminal info object that represent the fix part in terminal dash board which shows terminal infos
    /// </summary>
    public class TerminalInfo : WebObject
    {
        public static string TerminalId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.TerminalInfo_TerminalId)).Text; }
        }

        public static string ExternTerminalId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.TerminalInfo_ExternTerminalId)).Text; }
        }

        public static string Article
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.TerminalInfo_Article)).Text; }
        }

        public static string Status
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.TerminalInfo_Status)).Text; }
        }
    }
}