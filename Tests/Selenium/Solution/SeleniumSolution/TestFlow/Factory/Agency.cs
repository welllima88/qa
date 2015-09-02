namespace Six.Scs.Test.Factory
{
    public static class Agency
    {
        public static Model.Agency Default()
        {
            return new Model.Agency
            {
                Name = "SYR Agency " + Base.GenerateTestId(),
                DisplayName = "SYR Agency Display" + Base.GenerateTestId(),
                Adress = Adress.Create(),
                Contact = Contact.Create(),
                Supplier = "Alle Fremdhersteller",
                SbsAgentId = "881144",
                Status = true
            };
        }

        public static Model.Agency Edit()
        {
            return new Model.Agency
            {
                Name = "SYR Agency E" + Base.GenerateTestId(),
                DisplayName = "SYR Agency D/E" + Base.GenerateTestId(),
                Adress = Adress.Create(),
                Contact = Contact.Create(),
                Supplier = "SIX Payment Services AG",
                SbsAgentId = "001100",
                Status = true
            };
        }
    }
}