using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.TestData.ValueObjects;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal
{
    public class Functionbits : WebObject, IFunctionbits
    {
        private const string Pre =
            "span#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyFunctions_rowFunctions span";

        public IWebElement Booking
        {
            get { return WebDriver.FindElement(By.CssSelector(Pre + "[id$='_Booking']")); }
        }

        public IWebElement BookingReservation
        {
            get { return WebDriver.FindElement(By.CssSelector(Pre + "[id$='_BookingReservation']")); }
        }

        public IWebElement BookingTip
        {
            get { return WebDriver.FindElement(By.CssSelector(Pre + "[id$='_BookingTIP']")); }
        }

        public IWebElement BookingCashAdvance
        {
            get { return WebDriver.FindElement(By.CssSelector(Pre + "[id$='_BookingCashAdvance']")); }
        }

        public IWebElement Credit
        {
            get { return WebDriver.FindElement(By.CssSelector(Pre + "[id$='_Credit']")); }
        }

        public IWebElement BookingPhoneAuth
        {
            get { return WebDriver.FindElement(By.CssSelector(Pre + "[id$='_BookingPhoneAuth']")); }
        }

        public IWebElement OwnRiskTransaktion
        {
            get { return WebDriver.FindElement(By.CssSelector(Pre + "[id$='_OwnRiskTransaktion']")); }
        }

        public IWebElement BookingPhoneOrder
        {
            get { return WebDriver.FindElement(By.CssSelector(Pre + "[id$='_BookingPhoneOrder']")); }
        }

        public IWebElement BookingAuth
        {
            get { return WebDriver.FindElement(By.CssSelector(Pre + "[id$='_BookingAuth']")); }
        }

        public IWebElement BookingMailOrder
        {
            get { return WebDriver.FindElement(By.CssSelector(Pre + "[id$='_BookingMailOrder']")); }
        }

        public IWebElement Cancellation
        {
            get { return WebDriver.FindElement(By.CssSelector(Pre + "[id$='_Cancelation']")); }
        }

        public IWebElement Reservation
        {
            get { return WebDriver.FindElement(By.CssSelector(Pre + "[id$='_Reservation']")); }
        }

        public IWebElement ReservationsAdjustment
        {
            get { return WebDriver.FindElement(By.CssSelector(Pre + "[id$='_ReservationsAdjustment']")); }
        }

        public IWebElement ConfirmPhoneAut
        {
            get { return WebDriver.FindElement(By.CssSelector(Pre + "[id$='_ConfirmPhoneAut']")); }
        }

        public IWebElement Recurring
        {
            get { return WebDriver.FindElement(By.CssSelector(Pre + "[id$='_Recurring']")); }
        }

        public IWebElement PurchaseWithCashback
        {
            get { return WebDriver.FindElement(By.CssSelector(Pre + "[id$='_PurchaseWithCashBack']")); }
        }

        public ReadOnlyCollection<IWebElement> FunctionBits
        {
            get
            {
                return
                    WebDriver.FindElements(
                        By.CssSelector(
                            Pre + " input"));
            }
        }
    }
}