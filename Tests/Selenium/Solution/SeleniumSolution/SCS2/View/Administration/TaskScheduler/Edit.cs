using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Administration.TaskScheduler
{
    public class Edit : WebObject
    {
        public static IWebElement Retries
        {
            get { return WebDriver.FindAdaptedElement(By.Id("??")); }
        }

        public static IWebElement NextRun
        {
            get { return WebDriver.FindAdaptedElement(By.Id("??")); }
        }

        public static IWebElement Errors
        {
            get { return WebDriver.FindAdaptedElement(By.Id("??")); }
        }

        public static IWebElement State
        {
            get { return WebDriver.FindAdaptedElement(By.Id("??")); }
        }

        public static IWebElement LastErrorMessage
        {
            get { return WebDriver.FindAdaptedElement(By.Id("??")); }
        }

        public static IWebElement LastErrorCode
        {
            get { return WebDriver.FindAdaptedElement(By.Id("??")); }
        }

        public static IWebElement LastRun
        {
            get { return WebDriver.FindAdaptedElement(By.Id("??")); }
        }

        public static IWebElement LastStop
        {
            get { return WebDriver.FindAdaptedElement(By.Id("??")); }
        }

        public static IWebElement LastChange
        {
            get { return WebDriver.FindAdaptedElement(By.Id("??")); }
        }

        public static IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }

        public static IWebElement DeleteButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("delete")); }
        }

        public static IWebElement DeleteConfirmButton
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("div.modal-dialog form button.btn-danger[type='submit']"));
            }
        }
    }
}