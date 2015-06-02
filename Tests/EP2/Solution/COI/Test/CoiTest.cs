using NUnit.Framework;
using SIX.EP2.Client;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;
using SIX.SCS.QA.Tests.EP2.Message;
using SIX.SCS.QA.Tests.EP2.Message.Basic;
using SIX.SCS.QA.Tests.EP2.Setup;

namespace SIX.SCS.QA.Tests.EP2.Test
{
    [TestFixture]
    [Ignore]
    public class CoiTest
    {
        private IRequestResponseClient clientProtocol;

        [TestFixtureSetUp]
        public void SendMessage()
        {
            var messageMapper =
                MessageVersionMapper.Builder.AddFromAssemblyOfType<ConfigDataNotification>().Build();

            clientProtocol = ClientProtocolBuilder.ClientProtocolWith(messageMapper);
        }

        [Test]
        public void ResponseFromAcquirer02()
        {
            var handlerSessionHandler = new MyHandler();
            clientProtocol.SendWith(Communication.Dev(), handlerSessionHandler);
        }

        [Test]
        public void ResponseFromAcquirer25()
        {
            var handlerSessionHandler = new MyHandler();
            clientProtocol.SendWith(Communication.Dev(), handlerSessionHandler);
        }
    }
}