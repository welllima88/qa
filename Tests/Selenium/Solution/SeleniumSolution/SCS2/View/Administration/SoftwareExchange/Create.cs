using System;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Administration.SoftwareExchange
{
    public class Create : WebObject
    {
        public static IWebElement SelectedTerminalType
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SelectedTerminalType")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement IncludeDeactivated
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#IncludeDeactivated")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement IncludeCanceled
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#IncludeCancelled")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement SelectedCurrentRelease
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SelectedCurrentReleaseCriteria")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement SelectedNewRelease
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SelectedNewReleaseCriteria")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement SelectedNewTargetRelease
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SelectedNewRelease")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement SelectedNetType
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SelectedNetType")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement TidRangeStart
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#TidRangeStart")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement TidRangeEnd
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#TidRangeEnd")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement TerminalIdSelection
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#TerminalIdSelection")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement RecallNextFrom
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#RecallNextFrom")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement RecallNextUntil
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#RecallNextUntil")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement SelectedSupplierMandant
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SelectedSupplierMandant")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement IncludeKeyAccounts
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#IncludeKeyAccounts")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement CustomerIds
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#CustomerIds")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement Zips
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#Zips")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement SelectedCountry
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SelectedCountry")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement ResultLimit
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ResultLimit")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement RefreshButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#refresh")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement BatchTitle
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#BatchTitle")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement SelectAllSwitch
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#selectAllSwitch")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement SelectOddEvenSwitch
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#selectOddEvenSwitch")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement StartDateTime
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#startDateTime")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElement BatchCreateButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#execute")); }
        }
    }
}