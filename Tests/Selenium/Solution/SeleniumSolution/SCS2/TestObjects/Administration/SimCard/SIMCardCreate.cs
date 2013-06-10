using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Administration.SimCard
{
    internal class SimCardCreate : ISimCardElement
    {
        private readonly IWebDriverAdapter _driver;

        public SimCardCreate(IWebDriverAdapter driver)
        {
            _driver = driver;
        }

        public IWebElement SaveButton
        {
            get { return _driver.FindAdaptedElement(By.CssSelector("input.button[value='Speichern']")); }
        }

        #region ISimCardElement Members

        public string NetProvider
        {
            get { throw new NotSupportedException(); }
            set { _driver.FindAdaptedElement(By.CssSelector("#SIMCard_NetworkProviderId")).Selector().SelectByText(value); }
        }

        public string SimCardNumber
        {
            get { throw new NotSupportedException(); }
            set { _driver.FindAdaptedElement(By.CssSelector("#SIMCard_CardNumber")).TypeText(value); }
        }

        public string MobileNumber
        {
            get { throw new NotSupportedException(); }
            set { _driver.FindAdaptedElement(By.CssSelector("#SIMCard_MobileNumber")).TypeText(value); }
        }

        public string Pin
        {
            get { throw new NotSupportedException(); }
            set { _driver.FindAdaptedElement(By.CssSelector("#SIMCard_PIN")).TypeText(value); }
        }

        public string Puk
        {
            get { throw new NotSupportedException(); }
            set { _driver.FindAdaptedElement(By.CssSelector("#SIMCard_PUK")).TypeText(value); }
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

        public string Region
        {
            get { throw new NotImplementedException(); }
            set { _driver.FindAdaptedElement(By.CssSelector("#SIMCard_LocationId")).Selector().SelectByText(value); }
        }

        public string Usage
        {
            get { throw new NotImplementedException(); }
            set { _driver.FindAdaptedElement(By.CssSelector("#SIMCard_UsageId")).Selector().SelectByText(value); }
        }

        #endregion
    }
}