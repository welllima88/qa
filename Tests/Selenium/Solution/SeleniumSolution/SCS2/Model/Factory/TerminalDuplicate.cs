namespace Six.Scs.Test.Model.Factory
{
    public class TerminalDuplicate
    {
        public static Model.TerminalDuplicate Create()
        {
            return new Model.TerminalDuplicate
            {
                NumberOfTerminals = "2",
                InstallMessage = "SYR Install Message " + Factory.GenerateTestId(),
                InformationText = "SYR Infotext " + Factory.GenerateTestId(),
                CopyPassword = true,
                MessageForAcquirers = true
            };
        }
    }
}