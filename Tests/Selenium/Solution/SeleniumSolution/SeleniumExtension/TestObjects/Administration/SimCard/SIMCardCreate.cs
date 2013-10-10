using System;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.SimCard
{
    public class SimCardCreate : WebObject
    {
        public static IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button[type='submit']")); }
        }

        #region ISimCardElement Members

        public static string NetProvider
        {
            get { throw new NotSupportedException(); }
            set { WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_NetworkProviderId")).Selector().SelectByText(value); }
        }

        public static string SimCardNumber
        {
            get { throw new NotSupportedException(); }
            set { WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_CardNumber")).TypeText(value); }
        }

        public static string MobileNumber
        {
            get { throw new NotSupportedException(); }
            set { WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_MobileNumber")).TypeText(value); }
        }

        public static string Pin
        {
            get { throw new NotSupportedException(); }
            set { WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_PIN")).TypeText(value); }
        }

        public static string Puk
        {
            get { throw new NotSupportedException(); }
            set { WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_PUK")).TypeText(value); }
        }

        public bool Status
        {
            get { throw new NotSupportedException(); }
            set { throw new NotSupportedException(); }
        }

        public string TerminalId
        {
            get { throw new NotSupportedException(); }
            set { throw new NotSupportedException(); }
        }

        public static string Region
        {
            get { throw new NotImplementedException(); }
            set { WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_LocationId")).Selector().SelectByText(value); }
        }

        public static string Usage
        {
            get { throw new NotImplementedException(); }
            set { WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_UsageId")).Selector().SelectByText(value); }
        }

        #endregion
    }
}