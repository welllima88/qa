using System.Collections.Generic;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Terminal
{
    public class Functionbits : WebObject
    {
        private const string Pre =
            "span#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyFunctions_rowFunctions span";

        public IWebElement Booking
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_Booking']")); }
        }

        public IWebElement BookingReservation
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_BookingReservation']")); }
        }

        public IWebElement BookingTip
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_BookingTIP']")); }
        }

        public IWebElement BookingCashAdvance
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_BookingCashAdvance']")); }
        }

        public IWebElement Credit
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_Credit']")); }
        }

        public IWebElement BookingPhoneAuth
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_BookingPhoneAuth']")); }
        }

        public IWebElement OwnRiskTransaktion
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_OwnRiskTransaktion']")); }
        }

        public IWebElement BookingPhoneOrder
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_BookingPhoneOrder']")); }
        }

        public IWebElement BookingAuth
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_BookingAuth']")); }
        }

        public IWebElement BookingMailOrder
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_BookingMailOrder']")); }
        }

        public IWebElement Cancellation
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_Cancelation']")); }
        }

        public IWebElement Reservation
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_Reservation']")); }
        }

        public IWebElement ReservationsAdjustment
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_ReservationsAdjustment']")); }
        }

        public IWebElement ConfirmPhoneAut
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_ConfirmPhoneAut']")); }
        }

        public IWebElement Recurring
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_Recurring']")); }
        }

        public IWebElement PurchaseWithCashback
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_PurchaseWithCashBack']")); }
        }

        public IEnumerable<IWebElement> FunctionBits
        {
            get { return WebDriver.FindAdaptedElements(By.CssSelector(Pre + " input")); }
        }
    }
}