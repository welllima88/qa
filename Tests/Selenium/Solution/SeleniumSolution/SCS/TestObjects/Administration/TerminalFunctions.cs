using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.SCSClassics.Tests.Selenium.TestObjects.Administration
{
    public class TerminalFunctions : IWebGuiElement
    {
        private const string Pre =
            "span#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyFunctions_rowFunctions span";

        private readonly IWebDriver _driver;

        public TerminalFunctions(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement Booking
        {
            get { return _driver.FindElement(By.CssSelector(Pre + "[id$='_Booking']")); }
        }

        public IWebElement BookingReservation
        {
            get { return _driver.FindElement(By.CssSelector(Pre + "[id$='_BookingReservation']")); }
        }

        public IWebElement BookingTip
        {
            get { return _driver.FindElement(By.CssSelector(Pre + "[id$='_BookingTIP']")); }
        }

        public IWebElement BookingCashAdvance
        {
            get { return _driver.FindElement(By.CssSelector(Pre + "[id$='_BookingCashAdvance']")); }
        }

        public IWebElement Credit
        {
            get { return _driver.FindElement(By.CssSelector(Pre + "[id$='_Credit']")); }
        }

        public IWebElement BookingPhoneAuth
        {
            get { return _driver.FindElement(By.CssSelector(Pre + "[id$='_BookingPhoneAuth']")); }
        }

        public IWebElement OwnRiskTransaktion
        {
            get { return _driver.FindElement(By.CssSelector(Pre + "[id$='_OwnRiskTransaktion']")); }
        }

        public IWebElement BookingPhoneOrder
        {
            get { return _driver.FindElement(By.CssSelector(Pre + "[id$='_BookingPhoneOrder']")); }
        }

        public IWebElement BookingAuth
        {
            get { return _driver.FindElement(By.CssSelector(Pre + "[id$='_BookingAuth']")); }
        }

        public IWebElement BookingMailOrder
        {
            get { return _driver.FindElement(By.CssSelector(Pre + "[id$='_BookingMailOrder']")); }
        }

        public IWebElement Cancelation
        {
            get { return _driver.FindElement(By.CssSelector(Pre + "[id$='_Cancelation']")); }
        }

        public IWebElement Reservation
        {
            get { return _driver.FindElement(By.CssSelector(Pre + "[id$='_Reservation']")); }
        }

        public IWebElement ReservationsAdjustment
        {
            get { return _driver.FindElement(By.CssSelector(Pre + "[id$='_ReservationsAdjustment']")); }
        }

        public IWebElement ConfirmPhoneAut
        {
            get { return _driver.FindElement(By.CssSelector(Pre + "[id$='_ConfirmPhoneAut']")); }
        }

        public IWebElement Recurring
        {
            get { return _driver.FindElement(By.CssSelector(Pre + "[id$='_Recurring']")); }
        }

        public IWebElement PurchaseWithCashBack
        {
            get { return _driver.FindElement(By.CssSelector(Pre + "[id$='_PurchaseWithCashBack']")); }
        }

        public ReadOnlyCollection<IWebElement> FunctionBits
        {
            get
            {
                return
                    _driver.FindElements(
                        By.CssSelector(
                            Pre + " input"));
            }
        }
    }
}