using NUnit.Framework;
using SIX.EP2.Client;
using SIX.EP2.Core.Comm;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;

namespace SIX.SCS.QA.Tests.EP2.Coi
{
    [TestFixture]
    public class CoiTest
    {
        [Test]
        public void SendMessage()
        {
            IMessageVersionMapper messageMapper =
                MessageVersionMapper.Builder.AddFromAssemblyOfType<ConfigDataNotification>().Build();

            var comConfig = new ComConfig
            {
                Port = 2253,
                ServerAddress = "mdzhwcweb01",
                Version = "0600"
            };

            IRequestResponseClient clientProtocol = ClientProtocolBuilder.ClientProtocolWith(messageMapper);

            clientProtocol.SendWith(comConfig,  new MyHandler());
        }
    }
}