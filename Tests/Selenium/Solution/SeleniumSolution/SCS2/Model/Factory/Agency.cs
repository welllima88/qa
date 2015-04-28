namespace Six.Scs.QA.Application.Model.Factory
{
    public static class Agency
    {
        public static ValueObjects.Agency Default()
        {
            return new ValueObjects.Agency
            {
                Name = "SYR Agency " + Factory.GenerateTestId(),
                DisplayName = "SYR Agency Display" + Factory.GenerateTestId(),
                Adress = Adress.Create(),
                Contact = Contact.Create(),
                Supplier = "Alle Fremdhersteller",
                SbsAgentId = "881144",
                Status = true
            };
        }

        public static ValueObjects.Agency Edit()
        {
            return new ValueObjects.Agency
            {
                Name = "SYR Agency E" + Factory.GenerateTestId(),
                DisplayName = "SYR Agency D/E" + Factory.GenerateTestId(),
                Adress = Adress.Create(),
                Contact = Contact.Create(),
                Supplier = "SIX Payment Services AG",
                SbsAgentId = "001100",
                Status = true
            };
        }
    }
}