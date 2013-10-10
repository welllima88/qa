using System;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.SimCard
{
    public class SimCardEdit : WebObject
    {
        public static IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button[type='submit']")); }
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
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_CardNumber")).
                          TypeText(value);
            }
        }

        public static string MobileNumber
        {
            get { throw new NotImplementedException(); }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_MobileNumber")).
                          TypeText(value);
            }
        }

        public static string Pin
        {
            get { throw new NotImplementedException(); }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_PIN")).
                          TypeText(value);
            }
        }

        public static string Puk
        {
            get { throw new NotImplementedException(); }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_PUK")).
                          TypeText(value);
            }
        }

        public static bool Status
        {
            get { throw new NotImplementedException(); }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_IsActive")).
                          SetCheckbox(value);
            }
        }

        public static string TerminalId
        {
            get { throw new NotImplementedException(); }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#TerminalId")).
                          TypeText(value);
            }
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