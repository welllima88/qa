using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace Six.Scs.QA.Selenium.Extension.TestData.ValueObjects
{
    public interface IFunctionbits
    {
        IWebElement Booking { get; }
        IWebElement BookingReservation { get; }
        IWebElement BookingTip { get; }
        IWebElement BookingCashAdvance { get; }
        IWebElement Credit { get; }
        IWebElement BookingPhoneAuth { get; }
        IWebElement OwnRiskTransaktion { get; }
        IWebElement BookingPhoneOrder { get; }
        IWebElement BookingAuth { get; }
        IWebElement BookingMailOrder { get; }
        IWebElement Cancellation { get; }
        IWebElement Reservation { get; }
        IWebElement ReservationsAdjustment { get; }
        IWebElement ConfirmPhoneAut { get; }
        IWebElement Recurring { get; }
        IWebElement PurchaseWithCashback { get; }
        ReadOnlyCollection<IWebElement> FunctionBits { get; }
    }
}