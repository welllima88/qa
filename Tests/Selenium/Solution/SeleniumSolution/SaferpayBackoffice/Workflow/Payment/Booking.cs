using System;
using Six.QA.Selenium.Extension.Helper;
using Six.Saferpay.QA.Selenium.Data;
using Six.Saferpay.QA.Selenium.Factory;

namespace Six.Saferpay.QA.Selenium.Workflow.Payment
{
    public class Booking : IPerform
    {
        private readonly Data.Payment.Booking _booking;
        private Account _account;

        public Booking(Data.Payment.Booking booking)
        {
            _booking = booking;
        }

        public void Check()
        {
            throw new NotImplementedException();
        }

        public void Do()
        {
            ClickBooking();
            ChooseAccount();
            EnterBookingData(_booking);
            ClickExecute();
        }

        private void ClickExecute()
        {
            Pages.Payment.Booking.Pay.Button().Click();
        }

        private void ClickBooking()
        {
        }

        public Booking On(Account account)
        {
            _account = account;
            return this;
        }

        private void ChooseAccount()
        {
            if (_account == null) _account = new Default();
        }

        protected virtual void EnterBookingData(Data.Payment.Booking booking)
        {
            Pages.Payment.Booking.CardNumber.TextField().TypeText(booking.CardNumber);
            Pages.Payment.Booking.ExpiryMonth.Selector().SelectByText(booking.ExpiryMonth);
            Pages.Payment.Booking.ExpiryYear.Selector().SelectByText(booking.ExpiryYear);
            Pages.Payment.Booking.CardHolderName.TextField().TypeText(booking.CardHolderName);
            Pages.Payment.Booking.VerificationCode.TextField().TypeText(booking.VerificationCode);
            Pages.Payment.Booking.Currency.TextField().TypeText(booking.Currency);
            Pages.Payment.Booking.Amount.TextField().TypeText(booking.Amount);
            Pages.Payment.Booking.OrderId.TextField().TypeText(booking.OrderId);
            Pages.Payment.Booking.Description.TextField().TypeText(booking.Description);
            Pages.Payment.Booking.Amount.TextField().TypeText(booking.Amount);
            Pages.Payment.Booking.PayerNote.TextField().TypeText(booking.PayerNote);
        }
    }
}