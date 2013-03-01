using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Administration.SimCard
{
    internal class SimCardElementView : ISimCardElement
    {
        private readonly IWebDriverAdapter _driver;

        public SimCardElementView(IWebDriverAdapter driver)
        {
            _driver = driver;
        }

        #region ISimCardElement Members

        public string NetProvider
        {
            get { return _driver.FindAdaptedElement(By.CssSelector("#NetworkProvider")).Text; }
            set { throw new NotImplementedException(); }
        }

        public string SimCardNumber
        {
            get { return _driver.FindAdaptedElement(By.CssSelector("#SIMCardNumber")).Text; }
            set { throw new NotImplementedException(); }
        }

        public string MobileNumber
        {
            get { return _driver.FindAdaptedElement(By.CssSelector("#MobileNumber")).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Pin
        {
            get { return _driver.FindAdaptedElement(By.CssSelector("#PIN")).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Puk
        {
            get { return _driver.FindAdaptedElement(By.CssSelector("#PUK")).Text; }
            set { throw new NotImplementedException(); }
        }

        public bool Status
        {
            get { return _driver.FindAdaptedElement(By.CssSelector("#SIMCardState")).Text.Equals("aktiv"); }
            set { throw new NotImplementedException(); }
        }

        public string TerminalId
        {
            get { return _driver.FindAdaptedElement(By.CssSelector("#TerminalId")).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Region
        {
            get { return _driver.FindAdaptedElement(By.CssSelector("#SIMCard_LocationId")).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Usage
        {
            get { return _driver.FindAdaptedElement(By.CssSelector("#SIMCard_UsageId")).Text; }
            set { throw new NotImplementedException(); }
        }

        #endregion
    }
}