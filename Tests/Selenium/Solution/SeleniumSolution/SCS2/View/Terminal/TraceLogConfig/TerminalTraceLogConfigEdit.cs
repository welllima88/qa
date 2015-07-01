using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Terminal.TraceLogConfig
{
    public class TerminalTraceLogConfigEdit : WebObject
    {
        public static string ActivatedUntil
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#activateTill")).TextField().TypeText(value); }
        }

        public static string Parameter
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_Parameter")).TextField().TypeText(value); }
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
                    .TextField()
                    .TypeText(value);
            }
        }

        public static string DestinationPort
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_DestinationAddressPort"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static string TelephoneIsdn
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_PhoneNumberIsdn")).TextField().TypeText(value);
            }
        }

        public static string TelephonePstn
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_PhoneNumberPstn")).TextField().TypeText(value);
            }
        }

        public static string DestinationUrl
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_InternetAddressUrl"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static string DestinationUrlPort
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_InternetAddressPort"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static ButtonElement Save
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#activate")).Button(); }
        }

        public static IWebElement Deactivate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button[name='deactivate']")); }
        }
    }
}