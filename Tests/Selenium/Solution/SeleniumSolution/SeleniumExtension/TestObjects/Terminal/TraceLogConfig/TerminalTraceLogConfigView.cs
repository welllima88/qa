using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Terminal.TraceLogConfig
{
    public class TerminalTraceLogConfigView : WebObject
    {
        public static string ActivatedUntil
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#activateTill")).Text; }
        }

        public static string Parameter
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_Parameter")).Text; }
        }

        public static string Medium
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_DestinationDevice")).Text; }
        }

        public static string DestinationAddress
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_DestinationAddressIp")).Text; }
        }

        public static string DestinationPort
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_DestinationAddressPort")).Text; }
        }

        public static string TelephoneIsdn
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_PhoneNumberIsdn")).Text; }
        }

        public static string TelephonePstn
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_PhoneNumberPstn")).Text; }
        }

        public static string DestinationUrl
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_InternetAddressUrl")).Text; }
        }

        public static string DestinationUrlPort
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_InternetAddressPort")).Text; }
        }

        public static IWebElementAdapter Edit
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button[name='deactivate']")); }
        }
    }
}