namespace Six.Scs.QA.Selenium.Model.Factory
{
    public class TerminalReplace
    {
        public static ValueObjects.TerminalReplace Yoximo()
        {
            return new ValueObjects.TerminalReplace
            {
                Article = "yoximo PINPAD WLAN TCP/IP ep2 (DNS)",
                InstallationType = "Installation",
                SalesContract = "Kaufvertrag",
                SupportContract = "ServicePaket Light",
                Contactless = "contact and contactless",
                InstallationRemark = "Install remark " + Factory.GenerateTestId(),
                Infotext = "Infotext " + Factory.GenerateTestId(),
                DeliveryDate = "11.11.2022",
                SendNotifiaction = false
            };
        }
    }
}