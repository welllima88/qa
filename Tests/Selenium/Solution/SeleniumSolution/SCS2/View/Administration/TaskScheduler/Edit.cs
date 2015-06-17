using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Administration.TaskScheduler
{
    public class Edit : WebObject
    {
        public static IWebElementAdapter Retries
        {
            get { return WebDriver.FindAdaptedElement(By.Id("??")); }
        }

        public static IWebElementAdapter NextRun
        {
            get { return WebDriver.FindAdaptedElement(By.Id("??")); }
        }

        public static IWebElementAdapter Errors
        {
            get { return WebDriver.FindAdaptedElement(By.Id("??")); }
        }

        public static IWebElementAdapter State
        {
            get { return WebDriver.FindAdaptedElement(By.Id("??")); }
        }

        public static IWebElementAdapter LastErrorMessage
        {
            get { return WebDriver.FindAdaptedElement(By.Id("??")); }
        }

        public static IWebElementAdapter LastErrorCode
        {
            get { return WebDriver.FindAdaptedElement(By.Id("??")); }
        }

        public static IWebElementAdapter LastRun
        {
            get { return WebDriver.FindAdaptedElement(By.Id("??")); }
        }

        public static IWebElementAdapter LastStop
        {
            get { return WebDriver.FindAdaptedElement(By.Id("??")); }
        }

        public static IWebElementAdapter LastChange
        {
            get { return WebDriver.FindAdaptedElement(By.Id("??")); }
        }

        public static IWebElementAdapter SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }
    }
}