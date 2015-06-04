using SIX.EP2.Core.Comm;

namespace Six.Scs.Ep2.Coi.Common
{
    public class Communication
    {
        public static ComConfig Dev()
        {
            return new ComConfig
            {
                Port = 2253,
                ServerAddress = "mdzhwcweb01",
                Version = "0600",
                ConnectionTimeout = 4,
                ReceiveTimeout = 30000,
                SendTimeout = 30000
            };
        }
    }
}