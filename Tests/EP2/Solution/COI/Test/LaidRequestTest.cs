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

            _myService = new MessageObject
            {
                ConfDataObj = "LAID",
                ScId = "8000000001"
            };

            _handlerSessionHandler = new LaidRequestHandler(_myService);
            // _clientProtocol.WithSecurityProvider(new SecurityProvider());
        }

        private IRequestResponseClient _clientProtocol;
        private MessageObject _myService;
        private LaidRequestHandler _handlerSessionHandler;

        [Test]
        [Category("SIX")]
        public void ResponseFromAcquirer02()
        {
            _myService.AcqId = 2;
            _clientProtocol.SendWith(Communication.Dev(), _handlerSessionHandler);

            Assert.That(_myService.ListOfAid, Is.EquivalentTo(Laid.Six()));
        }

        [Test]
        [Category("Swisscard")]
        public void ResponseFromAcquirer25()
        {
            _myService.AcqId = 25;
            _clientProtocol.SendWith(Communication.Dev(), _handlerSessionHandler);

            Assert.That(_myService.ListOfAid, Is.EquivalentTo(Laid.Swisscard()));
        }
    }
}