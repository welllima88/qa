using NUnit.Framework;
using SIX.EP2.Client;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;
using SIX.SCS.QA.Tests.EP2.Data;
using SIX.SCS.QA.Tests.EP2.Message;
using SIX.SCS.QA.Tests.EP2.Setup;

namespace SIX.SCS.QA.Tests.EP2.Test
{
    [TestFixture]
    [Category("COI"), Category("EP2"), Category("LAID")]
    public class LaidRequestTest
    {
        [SetUp]
        public void SendMessage()
        {
            var messageMapper =
                MessageVersionMapper.Builder.AddFromAssemblyOfType<ConfigDataRequest>().Build();

            _clientProtocol = ClientProtocolBuilder.ClientProtocolWith(messageMapper);

            // _clientProtocol.WithSecurityProvider(new SecurityProvider());
        }

        private IRequestResponseClient _clientProtocol;

        [Test]
        [Category("SIX")]
        public void ResponseFromAcquirer02()
        {
            var handlerSessionHandler = new LaidRequestHandler();
            _clientProtocol.SendWith(Communication.Dev(), handlerSessionHandler);

            Assert.That(handlerSessionHandler.ListOfAid, Is.EquivalentTo(Laid.Six()));
        }

        [Test]
        [Category("Swisscard")]
        public void ResponseFromAcquirer25()
        {
            var handlerSessionHandler = new LaidRequestHandler();
            _clientProtocol.SendWith(Communication.Dev(), handlerSessionHandler);

            Assert.That(handlerSessionHandler.ListOfAid, Is.EquivalentTo(Laid.Swisscard()));
        }
    }
}