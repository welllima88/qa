using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.TraceLogConfig
{
    public class TerminalTraceLogConfigEdit : WebObject
    {
        public static IWebElementAdapter ActivatedUntil
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#activateTill")); }
        }

        public static IWebElementAdapter Parameter
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_Parameter")); }
        }

        public static SelectElement Medium
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_DestinationDevice")).Selector(); }
        }

        public static IWebElementAdapter DestinationAddress
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_DestinationAddressIp")); }
        }

        public static IWebElementAdapter DestinationPort
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_DestinationAddressPort")); }
        }

        public static IWebElementAdapter TelephoneIsdn
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_PhoneNumberIsdn")); }
        }

        public static IWebElementAdapter TelephonePstn
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_PhoneNumberPstn")); }
        }

        public static IWebElementAdapter DestinationUrl
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_InternetAddressUrl")); }
        }

        public static IWebElementAdapter DestinationUrlPort
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_InternetAddressPort")); }
        }

        public static IWebElementAdapter Save
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button[value='speichern']")); }
        }

        public IWebElementAdapter Deactivate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button[name='deactivate']")); }
        }
    }
}