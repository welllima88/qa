namespace Six.Scs.Test.Factory
{
    public class TerminalDuplicate
    {
        public static Model.TerminalDuplicate Create()
        {
            return new Model.TerminalDuplicate
            {
                NumberOfTerminals = "2",
                InstallMessage = "SYR Install Message " + Base.GenerateTestId(),
                InformationText = "SYR Infotext " + Base.GenerateTestId(),
                CopyPassword = true,
                MessageForAcquirers = true
            };
        }
    }
}