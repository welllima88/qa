using System;
using OpenQA.Selenium;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Definitions;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Administration.SimCard
{
    internal class SimCardElementView : WebObject, ISimCardElement
    {
        #region ISimCardElement Members

        public string NetProvider
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#NetworkProvider")).Text; }
            set { throw new NotImplementedException(); }
        }

        public string SimCardNumber
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SIMCardNumber")).Text; }
            set { throw new NotImplementedException(); }
        }

        public string MobileNumber
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#MobileNumber")).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Pin
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#PIN")).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Puk
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#PUK")).Text; }
            set { throw new NotImplementedException(); }
        }

        public bool Status
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SIMCardState")).Text.Equals("aktiv"); }
            set { throw new NotImplementedException(); }
        }

        public string TerminalId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#TerminalId")).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Region
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_LocationId")).Text; }
            set { throw new NotImplementedException(); }
        }

        public string Usage
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_UsageId")).Text; }
            set { throw new NotImplementedException(); }
        }

        #endregion
    }
}