using System;
using OpenQA.Selenium;
using SIX.SCS.Tests.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.Tests.Selenium.Extension.TestObjects.Administration.SimCard
{
    public class SimCardEdit : WebObject
    {
        public static IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#save")); }
        }

        public static string NetProvider
        {
            get { throw new NotImplementedException(); }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#SIMCard_NetworkProviderId")).
                    Selector().SelectByText(value);
            }
        }

        public static string SimCardNumber
        {
            get { throw new NotImplementedException(); }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_CardNumber")).TextBox().TypeText(value); }
        }

        public static string MobileNumber
        {
            get { throw new NotImplementedException(); }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_MobileNumber")).TextBox().TypeText(value);
            }
        }

        public static string Pin
        {
            get { throw new NotImplementedException(); }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_PIN")).TextBox().TypeText(value); }
        }

        public static string Puk
        {
            get { throw new NotImplementedException(); }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_PUK")).TextBox().TypeText(value); }
        }

        public static bool Status
        {
            get { throw new NotImplementedException(); }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_IsActive")).
                    CheckBox().Set(value);
            }
        }

        public static string TerminalId
        {
            get { throw new NotImplementedException(); }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#TerminalId")).TextBox().TypeText(value); }
        }

        public static string Region
        {
            get { throw new NotImplementedException(); }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#SIMCard_LocationId")).
                    Selector().SelectByText(value);
            }
        }

        public static string Usage
        {
            get { throw new NotImplementedException(); }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#SIMCard_UsageId")).
                    Selector().SelectByText(value);
            }
        }
    }
}