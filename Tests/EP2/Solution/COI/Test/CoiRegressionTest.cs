using NUnit.Framework;
using Six.Scs.Ep2.Coi.Common;
using Six.Scs.Ep2.Coi.Message;
using Six.Scs.Ep2.Coi.Message.Elements;
using Six.Scs.Ep2.Coi.Message.Handler;
using SIX.EP2.Client;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;

namespace Six.Scs.Ep2.Coi.Test
{
    [TestFixture]
    [Category("COI"), Category("EP2"), Category("LAID")]
    public class CoiRegressionTest
    {
        [SetUp]
        public void SendMessage()
        {
            var messageMapper =
                MessageVersionMapper.Builder.AddFromAssemblyOfType<ConfigDataRequest>().Build();

            _clientProtocol = ClientProtocolBuilder.ClientProtocolWith(messageMapper);

            _laidRequest = LaidRequest();
        }

        private IRequestResponseClient _clientProtocol;
        private ConfigDataRequest _laidRequest;
        private LaidRequestHandler _messageHandler;

        private static ConfigDataRequest LaidRequest()
        {
            return new ConfigDataRequest
            {
                ConfDataObj = "LAID",
                ScId = "8000000001",
                AcqId = 2
            };
        }

        [Test]
        [Category("SIX")]
        public void Test()
        {
            // send LAID RQ
            _messageHandler = new LaidRequestHandler(_laidRequest);
            _clientProtocol.SendWith(Communication.Dev(), _messageHandler);
            var tcd = new Tcd().ListAID = _messageHandler.ListOfAid;
            // var ad = new Ad() = _messageHandler.ListOfAid;

            // TCD02 (SIX) use 3 AIDs and create Terminal to unknown Merchant -fail
            // AD create merchant
            // send again TCD
            // in UI not activate all, VP close tickets, check MCC
            // send again TCD
            // in UI check no further tickets
            // check coi notification history

            // (AD+)TCD25 (Amex)
            // UI enter VP no MCC
            // delete
            // UI check Contract, notification histrory 'ep2coi' user
            // delete last
            // UI check, Acquirer and Brand deleted, terminal is quitted
            // TCD25 again
            // the former terminal is still quitted, new Terminal was created (SCS-Id, same ep2-Id), Tickets open

            // FO check not necessary

            _laidRequest.AcqId = 2;
            _clientProtocol.SendWith(Communication.Dev(), _messageHandler);

            Assert.That(_messageHandler.ListOfAid.ListAIds, Is.EquivalentTo(Data.Definitions.Laid.Six()));
        }
    }
}