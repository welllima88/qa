using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Terminal
{
    public class Returns : WebObject
    {
        public static IWebElement TerminalLink(Model.Terminal terminal)
        {
            return WebDriver.FindAdaptedElement(By.LinkText(terminal.Id));
        }

        public static IWebElement Deactivate(Model.Terminal terminal)
        {
            return
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        string.Format(
                            "button.btn-warning[onclick*='/TerminalState/edit?TerminalId={0}&Deactivate=true&RedirectTo=TerminalReturnShipping']",
                            terminal.Id)));
        }

        public static IWebElement Cancel(Model.Terminal terminal)
        {
            return
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        string.Format(
                            "button.btn-danger[onclick*='/TerminalState/edit?TerminalId={0}&Cancel=true&RedirectTo=TerminalReturnShipping']",
                            terminal.Id)));
        }
    }
}