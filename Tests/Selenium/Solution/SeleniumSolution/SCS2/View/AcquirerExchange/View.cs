using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.AcquirerExchange
{
    public class View : WebObject
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

        public static Acquirer AcquirerElement(string acquirerName)
        {
            return new Acquirer(acquirerName);
        }
    }
}