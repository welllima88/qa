using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.View.Terminal
{
    public class Functionbits : WebObject
    {
        private const string Pre =
            "span#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyFunctions_rowFunctions span";

        public IWebElementAdapter Booking
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_Booking']")); }
        }

        public IWebElementAdapter BookingReservation
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_BookingReservation']")); }
        }

        public IWebElementAdapter BookingTip
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_BookingTIP']")); }
        }

        public IWebElementAdapter BookingCashAdvance
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_BookingCashAdvance']")); }
        }

        public IWebElementAdapter Credit
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_Credit']")); }
        }

        public IWebElementAdapter BookingPhoneAuth
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_BookingPhoneAuth']")); }
        }

        public IWebElementAdapter OwnRiskTransaktion
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_OwnRiskTransaktion']")); }
        }

        public IWebElementAdapter BookingPhoneOrder
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_BookingPhoneOrder']")); }
        }

        public IWebElementAdapter BookingAuth
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_BookingAuth']")); }
        }

        public IWebElementAdapter BookingMailOrder
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_BookingMailOrder']")); }
        }

        public IWebElementAdapter Cancellation
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_Cancelation']")); }
        }

        public IWebElementAdapter Reservation
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_Reservation']")); }
        }

        public IWebElementAdapter ReservationsAdjustment
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_ReservationsAdjustment']")); }
        }

        public IWebElementAdapter ConfirmPhoneAut
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_ConfirmPhoneAut']")); }
        }

        public IWebElementAdapter Recurring
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_Recurring']")); }
        }

        public IWebElementAdapter PurchaseWithCashback
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + "[id$='_PurchaseWithCashBack']")); }
        }

        public ReadOnlyCollection<IWebElementAdapter> FunctionBits
        {
            get { return WebDriver.FindAdaptedElements(By.CssSelector(Pre + " input")); }
        }
    }
}