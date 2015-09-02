namespace Six.Scs.Test.Factory
{
    public class TerminalReplace
    {
        public static Model.TerminalReplace Yoximo()
        {
            return new Model.TerminalReplace
            {
                Article = "yoximo PINPAD WLAN TCP/IP ep2 (DNS)",
                InstallationType = "Installation",
                SalesContract = "Kaufvertrag",
                SupportContract = "ServicePaket Light",
                Contactless = "contact and contactless",
                InstallationRemark = "Install remark " + Base.GenerateTestId(),
                Infotext = "Infotext " + Base.GenerateTestId(),
                DeliveryDate = "11.11.2022",
                SendNotifiaction = false
            };
        }
    }
}