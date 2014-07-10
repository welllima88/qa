using System;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Administration.SimCard
{
    public class SimCardCreate : WebObject
    {
        public static IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button[type='submit']")); }
        }

        public static string NetProvider
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_NetworkProviderId")).Selector().SelectByText(value);
            }
        }

        public static string SimCardNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_CardNumber")).TextField().TypeText(value); }
        }

        public static string MobileNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_MobileNumber")).TextField().TypeText(value); }
        }

        public static string Pin
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_PIN")).TextField().TypeText(value); }
        }

        public static string Puk
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_PUK")).TextField().TypeText(value); }
        }

        public static bool Status
        {
            set { throw new NotSupportedException(); }
        }

        public static string TerminalId
        {
            set { throw new NotSupportedException(); }
        }

        public static string Region
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_LocationId")).Selector().SelectByText(value); }
        }

        public static string Usage
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_UsageId")).Selector().SelectByText(value); }
        } 
    }
}