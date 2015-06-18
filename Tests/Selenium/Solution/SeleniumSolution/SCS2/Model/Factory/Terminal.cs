namespace Six.Scs.Test.Model.Factory
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

        public static ValueObjects.Terminal DavinciIfsf()
        {
            return new ValueObjects.Terminal { Type = "davinci2 SAFE PETROL PINPAD IFSF, TCP/IP ep2 (DNS)", Color = "weiss" };
        }
    }
}