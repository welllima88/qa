using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Terminal
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