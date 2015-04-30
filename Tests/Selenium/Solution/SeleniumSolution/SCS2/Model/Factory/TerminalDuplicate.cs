namespace Six.Scs.Test.Model.Factory
{
    public class TerminalDuplicate
    {
        public static ValueObjects.TerminalDuplicate Create()
        {
            return new ValueObjects.TerminalDuplicate
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