using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Administration.SoftwareExchange
{
    public class SoftwareExchangeCreate : WebObject
    {
        public IWebElement SelectedTerminalType
        {
            get { return WebDriver.FindElement(By.CssSelector("#SelectedTerminalType")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement IncludeDeactivated
        {
            get { return WebDriver.FindElement(By.CssSelector("#IncludeDeactivated")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement IncludeCancelled
        {
            get { return WebDriver.FindElement(By.CssSelector("#IncludeCancelled")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement SelectedCurrentRelease
        {
            get { return WebDriver.FindElement(By.CssSelector("#SelectedCurrentRelease")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement AllowTerminalsWithNoCurrentRelease
        {
            get { return WebDriver.FindElement(By.CssSelector("#AllowTerminalsWithNoCurrentRelease")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement SelectedNetType
        {
            get { return WebDriver.FindElement(By.CssSelector("#SelectedNetType")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement TidRangeStart
        {
            get { return WebDriver.FindElement(By.CssSelector("#TidRangeStart")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement TidRangeEnd
        {
            get { return WebDriver.FindElement(By.CssSelector("#TidRangeEnd")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement TerminalIdSelection
        {
            get { return WebDriver.FindElement(By.CssSelector("#TerminalIdSelection")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement RecallNextFrom
        {
            get { return WebDriver.FindElement(By.CssSelector("#RecallNextFrom")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement RecallNextUntil
        {
            get { return WebDriver.FindElement(By.CssSelector("#RecallNextUntil")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement SelectedSupplierMandant
        {
            get { return WebDriver.FindElement(By.CssSelector("#SelectedSupplierMandant")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement IncludeKeyAccounts
        {
            get { return WebDriver.FindElement(By.CssSelector("#IncludeKeyAccounts")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement CustomerIds
        {
            get { return WebDriver.FindElement(By.CssSelector("#CustomerIds")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement Zips
        {
            get { return WebDriver.FindElement(By.CssSelector("#Zips")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement SelectedCountry
        {
            get { return WebDriver.FindElement(By.CssSelector("#SelectedCountry")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement ResultLimit
        {
            get { return WebDriver.FindElement(By.CssSelector("#ResultLimit")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement RefreshButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input#refresh")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement BatchTitle
        {
            get { return WebDriver.FindElement(By.CssSelector("#BatchTitle")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement SelectAllSwitch
        {
            get { return WebDriver.FindElement(By.CssSelector("#selectAllSwitch")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement SelectOddEvenSwitch
        {
            get { return WebDriver.FindElement(By.CssSelector("#selectOddEvenSwitch")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement SelectedNewRelease
        {
            get { return WebDriver.FindElement(By.CssSelector("#SelectedNewRelease")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement StartDateTime
        {
            get { return WebDriver.FindElement(By.CssSelector("#StartDateTime")); }
            set { throw new NotImplementedException(); }
        }

        public IWebElement BatchCreateButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input#execute']")); }
            set { throw new NotImplementedException(); }
        }
    }
}