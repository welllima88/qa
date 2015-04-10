using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.FoMessages
{
    /// <summary>
    ///     Represents the last FO-Message
    /// </summary>
    public class FoMessage : WebObject
    {
        private const string Pre =
            "html body#body table#tableStructure tbody tr#rowContent td#content table tbody tr.Summary td";

        public static IWebElementAdapter Compare
        {
            get { return WebDriver.FindAdaptedElement(By.Id("compareBtn")); }
        }

        public static string Date
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + ":nth-child(3)")).Text; }
        }

        public static string Id
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + ":nth-child(4)")).Text; }
        }

        public static string JobId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + ":nth-child(5)")).Text; }
        }

        public static string ResponseCode
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + ":nth-child(6)")).Text; }
        }

        public static string UserName
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + ":nth-child(7)")).Text; }
        }

        public static string TerminalId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + ":nth-child(8)")).Text; }
        }
    }
}