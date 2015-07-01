using NUnit.Framework;
using Six.Scs.Ep2.Coi.Common;
using Six.Scs.Ep2.Coi.Data.Definitions;
using Six.Scs.Ep2.Coi.Message;
using Six.Scs.Ep2.Coi.Message.Handler;
using SIX.EP2.Client;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;

namespace Six.Scs.Ep2.Coi.Test
{
    [TestFixture]
    [Category("COI"), Category("EP2"), Category("AISD")]
    public class AisdRequestTest
    {
        [SetUp]
        public void SendMessage()
        {
            var messageMapper =
                MessageVersionMapper.Builder.AddFromAssemblyOfType<ConfigDataRequest>().Build();

            _clientProtocol = ClientProtocolBuilder.ClientProtocolWith(messageMapper);
            _requestMsg = new ConfigDataRequest
            {
                ConfDataObj = "AISD",
                ScId = "8000000001",
                AcqId = 2
            };
            // _clientProtocol.WithSecurityProvider(new SecurityProvider());
        }

        private IRequestResponseClient _clientProtocol;
        private AisdRequestHandler _messageHandler;
        private ConfigDataRequest _requestMsg;

        [Test]
        [Category("Invalid Acquirer")]
        public void AcquirerIvalid()
        {
            _requestMsg.AcqId = -78025;

            _messageHandler = new AisdRequestHandler(_requestMsg);
            _clientProtocol.SendWith(Communication.Dev(), _messageHandler);

            Assert.That(_messageHandler.Error.ErrorCode, Is.EqualTo(1));
            Assert.That(_messageHandler.Error.ErrorDescription, Is.EquivalentTo("unknown acqid"));
        }

        [Test]
        [Category("Unknown Acquirer")]
        public void AcquirerUnknown()
        {
            _requestMsg.AcqId = 78025;
            _messageHandler = new AisdRequestHandler(_requestMsg);
            _clientProtocol.SendWith(Communication.Dev(), _messageHandler);

            Assert.That(_messageHandler.Error.ErrorCode, Is.EqualTo(1));
            Assert.That(_messageHandler.Error.ErrorDescription, Is.EquivalentTo("unknown acqid"));
        }

        [Test]
        [Category("SIX")]
        [Ignore("because reponses with no data to SC ID 8000000001")]
        public void ResponseFromAcquirerSix()
        {
            _requestMsg.AcqId = 2;
            _messageHandler = new AisdRequestHandler(_requestMsg);
            _clientProtocol.SendWith(Communication.Dev(), _messageHandler);

            Assert.That(_messageHandler.Aisd, Is.EqualTo(Aisd.Six()));
        }

        [Test]
        [Category("Swisscard")]
        public void ResponseFromAcquirerSwisscard()
        {
            _requestMsg.AcqId = 25;
            _messageHandler = new AisdRequestHandler(_requestMsg);
            _clientProtocol.SendWith(Communication.Dev(), _messageHandler);

            Assert.That(_messageHandler.Aisd, Is.EqualTo(Aisd.Swisscard()));
        }

        [Test]
        [Category("Invalid ServiceCenter")]
        public void ServiceCenterIvalid()
        {
            _requestMsg.ScId = "-78025";
            _messageHandler = new AisdRequestHandler(_requestMsg);
            _clientProtocol.SendWith(Communication.Dev(), _messageHandler);

            Assert.That(_messageHandler.Error.ErrorCode, Is.EqualTo(1));
            Assert.That(_messageHandler.Error.ErrorDescription, Is.EquivalentTo("no data, missing init address"));
        }

        [Test]
        [Category("Unknown ServiceCenter")]
        public void ServiceCenterUnknown()
        {
            _requestMsg.ScId = "8990000009";
            _messageHandler = new AisdRequestHandler(_requestMsg);
            _clientProtocol.SendWith(Communication.Dev(), _messageHandler);

            Assert.That(_messageHandler.Error.ErrorCode, Is.EqualTo(1));
            Assert.That(_messageHandler.Error.ErrorDescription, Is.EquivalentTo("no data, missing init address"));
        }
    }
}