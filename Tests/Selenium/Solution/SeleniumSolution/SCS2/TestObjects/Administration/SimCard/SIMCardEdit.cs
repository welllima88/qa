using System;
using OpenQA.Selenium;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Definitions;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Administration.SimCard
{
    internal class SimCardEdit : WebObject, ISimCardElement
    {
        public IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button[type='submit']")); }
        }

        public IWebElement CancelButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button[name='cancel']")); }
        }

        #region ISimCardElement Members

        public string NetProvider
        {
            get { throw new NotImplementedException(); }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#SIMCard_NetworkProviderId")).
                          Selector().SelectByText(value);
            }
        }

        public string SimCardNumber
        {
            get { throw new NotImplementedException(); }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_CardNumber")).
                          TypeText(value);
            }
        }

        public string MobileNumber
        {
            get { throw new NotImplementedException(); }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_MobileNumber")).
                          TypeText(value);
            }
        }

        public string Pin
        {
            get { throw new NotImplementedException(); }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_PIN")).
                          TypeText(value);
            }
        }

        public string Puk
        {
            get { throw new NotImplementedException(); }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_PUK")).
                          TypeText(value);
            }
        }

        public bool Status
        {
            get { throw new NotImplementedException(); }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_IsActive")).
                          SetCheckbox(value);
            }
        }

        public string TerminalId
        {
            get { throw new NotImplementedException(); }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#TerminalId")).
                          TypeText(value);
            }
        }

        public string Region
        {
            get { throw new NotImplementedException(); }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#SIMCard_LocationId")).
                          Selector().SelectByText(value);
            }
        }

        public string Usage
        {
            get { throw new NotImplementedException(); }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#SIMCard_UsageId")).
                          Selector().SelectByText(value);
            }
        }

        #endregion
    }
}