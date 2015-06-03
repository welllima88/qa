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
                SCID = "8000000001",
                AcqID = 2
            };
            // _clientProtocol.WithSecurityProvider(new SecurityProvider());
        }

        private IRequestResponseClient _clientProtocol;
        private LaidRequestHandler _handlerSessionHandler;
        private ConfigDataRequest _requestMsg;

        [Test]
        [Category("Invalid Acquirer")]
        public void AcquirerIvalid()
        {
            _requestMsg.AcqID = -78025;

            _handlerSessionHandler = new LaidRequestHandler(_requestMsg);
            _clientProtocol.SendWith(Communication.Dev(), _handlerSessionHandler);

            Assert.That(_handlerSessionHandler.Error.ErrorCode, Is.EqualTo(1));
            Assert.That(_handlerSessionHandler.Error.ErrorDescription, Is.EquivalentTo("unknown acqid"));
        }

        [Test]
        [Category("Unknown Acquirer")]
        public void AcquirerUnknown()
        {
            _requestMsg.AcqID = 78025;
            _handlerSessionHandler = new LaidRequestHandler(_requestMsg);
            _clientProtocol.SendWith(Communication.Dev(), _handlerSessionHandler);

            Assert.That(_handlerSessionHandler.Error.ErrorCode, Is.EqualTo(1));
            Assert.That(_handlerSessionHandler.Error.ErrorDescription, Is.EquivalentTo("unknown acqid"));
        }

        [Test]
        [Category("SIX")]
        public void ResponseFromAcquirerSix()
        {
            _requestMsg.AcqID = 2;
            _handlerSessionHandler = new LaidRequestHandler(_requestMsg);
            _clientProtocol.SendWith(Communication.Dev(), _handlerSessionHandler);

            Assert.That(_handlerSessionHandler.ListOfAid.LAID, Is.EquivalentTo(Data.Definitions.Laid.Six()));
        }

        [Test]
        [Category("Swisscard")]
        public void ResponseFromAcquirerSwisscard()
        {
            _requestMsg.AcqID = 25;
            _handlerSessionHandler = new LaidRequestHandler(_requestMsg);
            _clientProtocol.SendWith(Communication.Dev(), _handlerSessionHandler);

            Assert.That(_handlerSessionHandler.ListOfAid.LAID, Is.EquivalentTo(Data.Definitions.Laid.Swisscard()));
        }

        [Test]
        [Category("Invalid ServiceCenter")]
        public void ServiceCenterIvalid()
        {
            _requestMsg.SCID = "-78025";
            _handlerSessionHandler = new LaidRequestHandler(_requestMsg);
            _clientProtocol.SendWith(Communication.Dev(), _handlerSessionHandler);

            Assert.That(_handlerSessionHandler.ListOfAid.LAID, Is.Null);
        }

        [Test]
        [Category("Unknown ServiceCenter")]
        public void ServiceCenterUnknown()
        {
            _requestMsg.SCID = "8990000009";
            _handlerSessionHandler = new LaidRequestHandler(_requestMsg);
            _clientProtocol.SendWith(Communication.Dev(), _handlerSessionHandler);

            Assert.That(_handlerSessionHandler.ListOfAid.LAID, Is.Null);
        }
    }
}