using SIX.EP2.Client;
using SIX.EP2.Core.Comm;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;

namespace SIX.SCS.QA.Tests.EP2.Coi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IMessageVersionMapper messageMapper =
                MessageVersionMapper.Builder.AddFromAssemblyOfType<ConfigRequest>().Build();

            IRequestResponseClient clientProtocol = ClientProtocolBuilder.ClientProtocolWith(messageMapper);
            var sessionHandler = new MyHandler();
            var comConfig = new ComConfig
            {
                Port = 2253,
                ServerAddress = "mdzhwcweb01",
                Version = "0530"
            };
            clientProtocol.SendWith(comConfig, sessionHandler);
        }
    }
}