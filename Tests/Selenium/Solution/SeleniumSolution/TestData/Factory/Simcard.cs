using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.TestData.Factory
{
    public static class Simcard
    {
        public static SimCard Create()
        {
            return new SimCard
            {
                NetProvider = "SIX via Swisscom",
                SimCardNumber = "8" + Factory.GenerateTestId(),
                MobileNumber = "1234567890",
                Pin = "4321",
                Puk = "22446688",
                Region = "Schweiz",
                Status = true,
                TerminalId = ""
            };
        }

        public static SimCard Edit()
        {
            return new SimCard
            {
                MobileNumber = "0123456789",
                NetProvider = "SIX via Swisscom",
                Pin = "0123",
                Puk = "01234567",
                Region = "Schweiz",
                SimCardNumber = "9" + Factory.GenerateTestId(),
                Usage = "K - Kauf",
                TerminalId = "31380020"
            };
        }
    }
}