using System;
using Six.QA.Selenium.Extension.Helper;

namespace Six.Saferpay.QA.Selenium.Workflow.Payment
{
    public class Booking : IPerform
    {
        private readonly Data.Payment.Booking _booking;

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
            throw new NotImplementedException();
        }
    }
}