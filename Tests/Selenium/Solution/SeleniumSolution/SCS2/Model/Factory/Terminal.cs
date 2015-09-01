namespace Six.Scs.Test.Model.Factory
{
    public class Terminal
    {
        public static Model.Terminal Xentissimo()
        {
            return new Model.Terminal {Type = "xentissimo MOBILE WLAN, TCP/IP", Color = "grau"};
        }

        public static Model.Terminal Yomani()
        {
            return new Model.Terminal {Type = "yomani AUTONOM, TCP/IP ep2 (DNS)", Color = "weiss"};
        }

        public static Model.Terminal DavinciIfsf()
        {
            return new Model.Terminal { Type = "davinci2 SAFE PETROL PINPAD IFSF, TCP/IP ep2 (DNS)", Color = "weiss" };
        }
    }
}