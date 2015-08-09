using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Acquirer
{
    public class Exchange : WebObject
    {
        public static IWebElement Reload
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "tbody form a.btn-default[href*='/Location/PrepareForAcquirerExchange?LocationId=']"));
            }
        }

        public static IWebElement Save
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }
    }
}