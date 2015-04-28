using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Application.View.Terminal
{
    public class ListView : WebObject
    {
        public static IWebElementAdapter First()
        {
            return
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "tbody tr td#content table tbody tr td a[href*='/TerminalDashboard?TerminalId=']"));
        }
    }
}