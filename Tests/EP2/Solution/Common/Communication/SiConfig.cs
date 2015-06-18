using SIX.EP2.Core.Comm;

namespace Six.Scs.Ep2.Test.Communication
{
    public static class SiConfig
    {
        public static ComConfig Dev()
        {
            return new ComConfig
            {
                Port = 8115,
                ServerAddress = "mdzhwcweb01",
                Version = "0520",
                ConnectionTimeout = 4,
                ReceiveTimeout = 30000,
                SendTimeout = 30000
            };
        }
    }
}