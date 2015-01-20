using NUnit.Framework;
using SIX.EP2.Client;
using SIX.EP2.Core.Comm;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;

namespace SIX.SCS.QA.Tests.EP2.Coi.Setup
{
    [TestFixture]
    [Ignore]
    public class CoiTest
    {
        private IRequestResponseClient clientProtocol;
        private ComConfig _comConfig;

        [TestFixtureSetUp]
        public void SendMessage()
        {
            IMessageVersionMapper messageMapper =
                MessageVersionMapper.Builder.AddFromAssemblyOfType<ConfigDataNotification>().Build();

            _comConfig = new ComConfig
            {
                Port = 2253,
                ServerAddress = "mdzhwcweb01",
                Version = "0600"
            };

            clientProtocol = ClientProtocolBuilder.ClientProtocolWith(messageMapper);

            
        }

        [Test]
        public void Response()
        {
            var handlerSessionHandler = new MyHandler();
            clientProtocol.SendWith(_comConfig, handlerSessionHandler);
        }
    }
}