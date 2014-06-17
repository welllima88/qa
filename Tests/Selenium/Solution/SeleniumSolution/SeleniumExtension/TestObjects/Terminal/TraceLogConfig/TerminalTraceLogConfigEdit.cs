using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Terminal.TraceLogConfig
{
    public class TerminalTraceLogConfigEdit : WebObject
    {
        public static string ActivatedUntil
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#activateTill")).TextBox().TypeText(value); }
        }

        public static string Parameter
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_Parameter")).TextBox().TypeText(value); }
        }

        public static string Medium
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_DestinationDevice"))
                    .Selector()
                    .SelectByValue(value);
            }
        }

        public static string DestinationAddress
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_DestinationAddressIp"))
                    .TextBox()
                    .TypeText(value);
            }
        }

        public static string DestinationPort
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_DestinationAddressPort"))
                    .TextBox()
                    .TypeText(value);
            }
        }

        public static string TelephoneIsdn
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_PhoneNumberIsdn")).TextBox().TypeText(value);
            }
        }

        public static string TelephonePstn
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_PhoneNumberPstn")).TextBox().TypeText(value);
            }
        }

        public static string DestinationUrl
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_InternetAddressUrl")).TextBox().TypeText(value);
            }
        }

        public static string DestinationUrlPort
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_InternetAddressPort")).TextBox().TypeText(value);
            }
        }

        public static IWebElementAdapter Save
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#activate")); }
        }

        public IWebElementAdapter Deactivate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button[name='deactivate']")); }
        }
    }
}