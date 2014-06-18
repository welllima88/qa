using System;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Administration.SoftwareExchange
{
    public class SoftwareExchangeCreate : WebObject
    {
        public static IWebElement SelectedTerminalType
        {
            get { return WebDriver.FindElement(By.CssSelector("#SelectedTerminalType")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement IncludeDeactivated
        {
            get { return WebDriver.FindElement(By.CssSelector("#IncludeDeactivated")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement IncludeCanceled
        {
            get { return WebDriver.FindElement(By.CssSelector("#IncludeCancelled")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement SelectedCurrentRelease
        {
            get { return WebDriver.FindElement(By.CssSelector("#SelectedCurrentReleaseCriteria")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement SelectedNewRelease
        {
            get { return WebDriver.FindElement(By.CssSelector("#SelectedNewReleaseCriteria")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement SelectedNewTargetRelease
        {
            get { return WebDriver.FindElement(By.CssSelector("#SelectedNewRelease")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement SelectedNetType
        {
            get { return WebDriver.FindElement(By.CssSelector("#SelectedNetType")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement TidRangeStart
        {
            get { return WebDriver.FindElement(By.CssSelector("#TidRangeStart")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement TidRangeEnd
        {
            get { return WebDriver.FindElement(By.CssSelector("#TidRangeEnd")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement TerminalIdSelection
        {
            get { return WebDriver.FindElement(By.CssSelector("#TerminalIdSelection")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement RecallNextFrom
        {
            get { return WebDriver.FindElement(By.CssSelector("#RecallNextFrom")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement RecallNextUntil
        {
            get { return WebDriver.FindElement(By.CssSelector("#RecallNextUntil")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement SelectedSupplierMandant
        {
            get { return WebDriver.FindElement(By.CssSelector("#SelectedSupplierMandant")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement IncludeKeyAccounts
        {
            get { return WebDriver.FindElement(By.CssSelector("#IncludeKeyAccounts")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement CustomerIds
        {
            get { return WebDriver.FindElement(By.CssSelector("#CustomerIds")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement Zips
        {
            get { return WebDriver.FindElement(By.CssSelector("#Zips")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement SelectedCountry
        {
            get { return WebDriver.FindElement(By.CssSelector("#SelectedCountry")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement ResultLimit
        {
            get { return WebDriver.FindElement(By.CssSelector("#ResultLimit")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement RefreshButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input#refresh")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement BatchTitle
        {
            get { return WebDriver.FindElement(By.CssSelector("#BatchTitle")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement SelectAllSwitch
        {
            get { return WebDriver.FindElement(By.CssSelector("#selectAllSwitch")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement SelectOddEvenSwitch
        {
            get { return WebDriver.FindElement(By.CssSelector("#selectOddEvenSwitch")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement StartDateTime
        {
            get { return WebDriver.FindElement(By.CssSelector("#StartDateTime")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement BatchCreateButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input#execute")); }
        }
    }
}