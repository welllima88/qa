using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Terminal.ReceiptHeader
{
    public class Edit : WebObject
    {
        public static string Line1
        {
            get { return WebDriver.FindAdaptedElement(By.Id("ReceiptHeaderLine1")).Text; }
            set { WebDriver.FindAdaptedElement(By.Id("ReceiptHeaderLine1")).TextField().TypeText(value); }
        }

        public static string Line2
        {
            get { return WebDriver.FindAdaptedElement(By.Id("ReceiptHeaderLine2")).Text; }
            set { WebDriver.FindAdaptedElement(By.Id("ReceiptHeaderLine2")).TextField().TypeText(value); }
        }

        public static string Line3
        {
            get { return WebDriver.FindAdaptedElement(By.Id("ReceiptHeaderLine3")).Text; }
            set { WebDriver.FindAdaptedElement(By.Id("ReceiptHeaderLine3")).TextField().TypeText(value); }
        }

        public static void CopyFromLocation()
        {
            WebDriver.FindAdaptedElement(By.Id("defaultHeader")).Click();
        }

        public static IWebElement SaveButton()
        {
            return WebDriver.FindAdaptedElement(By.Id("save"));
        }
    }
}