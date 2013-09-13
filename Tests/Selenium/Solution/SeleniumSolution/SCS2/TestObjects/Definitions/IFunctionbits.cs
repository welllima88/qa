using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Definitions
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
        IWebElement Cancelation { get; }
        IWebElement Reservation { get; }
        IWebElement ReservationsAdjustment { get; }
        IWebElement ConfirmPhoneAut { get; }
        IWebElement Recurring { get; }
        IWebElement PurchaseWithCashBack { get; }
        ReadOnlyCollection<IWebElement> FunctionBits { get; }
    }
}