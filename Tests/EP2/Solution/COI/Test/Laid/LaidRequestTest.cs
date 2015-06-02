using NUnit.Framework;
using SIX.EP2.Client;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;
using SIX.SCS.QA.Tests.EP2.Message.Basic;
using SIX.SCS.QA.Tests.EP2.Message.Handler;
using SIX.SCS.QA.Tests.EP2.Setup;

namespace SIX.SCS.QA.Tests.EP2.Test.Laid
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

            _requestMsg = new ConfigDataRequest
            {
                ConfDataObj = "LAID",
                SCID = "8000000001"
            };

            _handlerSessionHandler = new LaidRequestHandler(_requestMsg);
            // _clientProtocol.WithSecurityProvider(new SecurityProvider());
        }

        private IRequestResponseClient _clientProtocol;
        private ConfigDataRequest _requestMsg;
        private LaidRequestHandler _handlerSessionHandler;

        [Test]
        [Category("SIX")]
        public void ResponseFromAcquirer02()
        {
            _requestMsg.AcqID = 2;
            _clientProtocol.SendWith(Communication.Dev(), _handlerSessionHandler);

            Assert.That(_handlerSessionHandler.ListOfAid.LAID, Is.EquivalentTo(Data.Definitions.Laid.Six()));
        }

        [Test]
        [Category("Swisscard")]
        public void ResponseFromAcquirer25()
        {
            _requestMsg.AcqID = 25;
            _clientProtocol.SendWith(Communication.Dev(), _handlerSessionHandler);

            Assert.That(_handlerSessionHandler.ListOfAid.LAID, Is.EquivalentTo(Data.Definitions.Laid.Swisscard()));
        }

        [Test]
        [Category("Invalid")]
        public void ResponseFromAcquirerIvalid()
        {
            _requestMsg.AcqID = -78025;
            _clientProtocol.SendWith(Communication.Dev(), _handlerSessionHandler);

            Assert.That(_handlerSessionHandler.Error.ErrorCode, Is.EqualTo(1));
            Assert.That(_handlerSessionHandler.Error.ErrorDescription, Is.EquivalentTo("unknown acqid"));
        }

        [Test]
        [Category("Unknown")]
        public void ResponseFromAcquirerUnknown()
        {
            _requestMsg.AcqID = 78025;
            _clientProtocol.SendWith(Communication.Dev(), _handlerSessionHandler);

            Assert.That(_handlerSessionHandler.Error.ErrorCode, Is.EqualTo(1));
            Assert.That(_handlerSessionHandler.Error.ErrorDescription, Is.EquivalentTo("unknown acqid"));
        }
    }
}