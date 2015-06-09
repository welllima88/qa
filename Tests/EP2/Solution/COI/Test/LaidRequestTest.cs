using NUnit.Framework;
using Six.Scs.Ep2.Coi.Common;
using Six.Scs.Ep2.Coi.Message;
using Six.Scs.Ep2.Coi.Message.Handler;
using SIX.EP2.Client;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;

namespace Six.Scs.Ep2.Coi.Test
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
                ScId = "8000000001",
                AcqId = 2
            };
            // _clientProtocol.WithSecurityProvider(new SecurityProvider());
        }

        private IRequestResponseClient _clientProtocol;
        private LaidRequestHandler _messageHandler;
        private ConfigDataRequest _requestMsg;

        [Test]
        [Category("Invalid Acquirer")]
        public void AcquirerIvalid()
        {
            _requestMsg.AcqId = -78025;

            _messageHandler = new LaidRequestHandler(_requestMsg);
            _clientProtocol.SendWith(Communication.Dev(), _messageHandler);

            Assert.That(_messageHandler.Error.ErrorCode, Is.EqualTo(1));
            Assert.That(_messageHandler.Error.ErrorDescription, Is.EquivalentTo("unknown acqid"));
        }

        [Test]
        [Category("Unknown Acquirer")]
        public void AcquirerUnknown()
        {
            _requestMsg.AcqId = 78025;
            _messageHandler = new LaidRequestHandler(_requestMsg);
            _clientProtocol.SendWith(Communication.Dev(), _messageHandler);

            Assert.That(_messageHandler.Error.ErrorCode, Is.EqualTo(1));
            Assert.That(_messageHandler.Error.ErrorDescription, Is.EquivalentTo("unknown acqid"));
        }

        [Test]
        [Category("SIX")]
        public void ResponseFromAcquirerSix()
        {
            _requestMsg.AcqId = 2;
            _messageHandler = new LaidRequestHandler(_requestMsg);
            _clientProtocol.SendWith(Communication.Dev(), _messageHandler);

            Assert.That(_messageHandler.ListOfAid.ListAIds, Is.EquivalentTo(Data.Definitions.Laid.Six()));
        }

        [Test]
        [Category("Swisscard")]
        public void ResponseFromAcquirerSwisscard()
        {
            _requestMsg.AcqId = 25;
            _messageHandler = new LaidRequestHandler(_requestMsg);
            _clientProtocol.SendWith(Communication.Dev(), _messageHandler);

            Assert.That(_messageHandler.ListOfAid.ListAIds, Is.EquivalentTo(Data.Definitions.Laid.Swisscard()));
        }

        [Test]
        [Category("Invalid ServiceCenter")]
        public void ServiceCenterIvalid()
        {
            _requestMsg.ScId = "-78025";
            _messageHandler = new LaidRequestHandler(_requestMsg);
            _clientProtocol.SendWith(Communication.Dev(), _messageHandler);

            Assert.That(_messageHandler.ListOfAid.ListAIds, Is.Null);
        }

        [Test]
        [Category("Unknown ServiceCenter")]
        public void ServiceCenterUnknown()
        {
            _requestMsg.ScId = "8990000009";
            _messageHandler = new LaidRequestHandler(_requestMsg);
            _clientProtocol.SendWith(Communication.Dev(), _messageHandler);

            Assert.That(_messageHandler.ListOfAid.ListAIds, Is.Null);
        }
    }
}