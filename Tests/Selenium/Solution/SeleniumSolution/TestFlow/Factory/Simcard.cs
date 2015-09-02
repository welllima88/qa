namespace Six.Scs.Test.Factory
{
    public static class Simcard
    {
        public static Model.SimCard Create()
        {
            return new Model.SimCard
            {
                NetProvider = "SIX via Swisscom",
                SimCardNumber = "8" + Base.GenerateTestId(),
                MobileNumber = "1234567890",
                Pin = "4321",
                Puk = "22446688",
                Region = "Schweiz",
                Status = true,
                TerminalId = ""
            };
        }

        public static Model.SimCard Edit()
        {
            return new Model.SimCard
            {
                MobileNumber = "0123456789",
                NetProvider = "SIX via Swisscom",
                Pin = "0123",
                Puk = "01234567",
                Region = "Schweiz",
                SimCardNumber = "9" + Base.GenerateTestId(),
                Usage = "K - Kauf",
                Status = true,
                TerminalId = ""
            };
        }
    }
}