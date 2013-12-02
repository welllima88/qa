using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard
{
    /// <summary>
    ///     Terminal info object that represent the fix part in terminal dash board which shows terminal infos
    /// </summary>
    public class TerminalInfo : WebObject
    {
        public static IWebElementAdapter TerminalId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.TerminalInfo_TerminalId)); }
        }

        public static IWebElementAdapter ExternTerminalId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.TerminalInfo_ExternTerminalId)); }
        }

        public static IWebElementAdapter Article
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.TerminalInfo_Article)); }
        }

        public static IWebElementAdapter Status
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.TerminalInfo_Status)); }
        }
    }
}