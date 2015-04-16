using System;
using Six.QA.Selenium.Extension.Helper;
using Six.Saferpay.QA.Selenium.Data;

namespace Six.Saferpay.QA.Selenium.Workflow.Payment
{
    public class Booking : IPerform
    {
        private readonly Data.Payment.Payment _payment;
        private Account _account;

        public Booking(Data.Payment.Payment payment)
        {
            _payment = payment;
        }

        public void Check()
        {
            throw new NotImplementedException();
        }

        public void Do()
        {
            ClickBooking();
            ChooseAccount();
            EnterBookingData(_payment);
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
            if (_account == null) _account = Factory.Account.Account.Default();
        }

        protected virtual void EnterBookingData(Data.Payment.Payment payment)
        {
            Pages.Payment.Booking.CardNumber.TextField().TypeText(payment.CardNumber);
            Pages.Payment.Booking.ExpiryMonth.Selector().SelectByText(payment.ExpiryMonth);
            Pages.Payment.Booking.ExpiryYear.Selector().SelectByText(payment.ExpiryYear);
            Pages.Payment.Booking.CardHolderName.TextField().TypeText(payment.CardHolderName);
            Pages.Payment.Booking.VerificationCode.TextField().TypeText(payment.VerificationCode);
            Pages.Payment.Booking.Currency.TextField().TypeText(payment.Currency);
            Pages.Payment.Booking.Amount.TextField().TypeText(payment.Amount);
            Pages.Payment.Booking.OrderId.TextField().TypeText(payment.OrderId);
            Pages.Payment.Booking.Description.TextField().TypeText(payment.Description);
            Pages.Payment.Booking.Amount.TextField().TypeText(payment.Amount);
            Pages.Payment.Booking.PayerNote.TextField().TypeText(payment.PayerNote);
        }
    }
}