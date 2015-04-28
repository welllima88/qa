namespace Six.Scs.QA.Application.Model.Factory
{
    public class Terminal
    {
        public static ValueObjects.Terminal Xentissimo()
        {
            return new ValueObjects.Terminal {Type = "xentissimo MOBILE WLAN, TCP/IP", Color = "grau"};
        }

        public static ValueObjects.Terminal Yomani()
        {
            return new ValueObjects.Terminal {Type = "yomani AUTONOM, TCP/IP ep2 (DNS)", Color = "weiss"};
        }
    }
}