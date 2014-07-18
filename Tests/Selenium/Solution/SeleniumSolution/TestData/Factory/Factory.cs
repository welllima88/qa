using System;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.TestData.Factory
{
    public static class Factory
    {
        public static string GenerateTestId()
        {
            return DateTime.Now.Ticks.ToString();
        }

        public static class Simcard
        {
            public static SimCardData Create()
            {
                return new SimCardData
                {
                    NetProvider = "SIX via Swisscom",
                    SimCardNumber = "0123456789012345678",
                    MobileNumber = "1234567890",
                    Pin = "4321",
                    Puk = "22446688",
                    Status = true,
                    TerminalId = "21012730"
                };
            }

            public static SimCardData Edit()
            {
                return new SimCardData
                {
                    MobileNumber = "0123456789",
                    NetProvider = "SIX via Swisscom",
                    Pin = "0123",
                    Puk = "01234567",
                    Region = "Schweiz",
                    SimCardNumber = "0123456789012345679",
                    Usage = "Kauf"
                };
            }
        }
    }
}