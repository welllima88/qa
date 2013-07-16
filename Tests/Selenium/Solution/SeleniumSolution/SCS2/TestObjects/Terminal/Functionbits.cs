using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal
{
    public class Functionbits : WebObject, IWebGuiElement, IFunctionbits
    {
        private const string Pre =
            "span#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyFunctions_rowFunctions span";

        #region IFunctionbits Members

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

        public IWebElement Cancelation
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

        public IWebElement PurchaseWithCashBack
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

        #endregion
    }
}