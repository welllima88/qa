using System;
using log4net;
using Moq;
using NUnit.Framework;
using Six.Scs.Ep2.SI.Config.Messages.MsgIn;
using Six.Scs.Ep2.SI.Config.Messages.MsgOut;
using Six.Scs.Ep2.Test.Communication;
using SIX.EP2.Client;
using SIX.EP2.Core.Comm;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.Crypto;
using SIX.EP2.Core.Errors;
using SIX.EP2.Core.Header;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;
using SIX.EP2.Core.Util;

namespace Six.Scs.Ep2.SI.Config
{
    [TestFixture]
    public class SiConfigTests
    {
        [SetUp]
        public void Setup()
        {
            var m = new SessionStart();
            _testHandler = new Mock<IClientSessionHandler>();

            _securityInfoProvider = new Mock<IProvideSecurityInfo>();
            _securityInfoProvider.SetupGet(x => x.Publickey).Returns(new PubKeyParser().ParseFromString(_pubkey));
            _securityInfoProvider.SetupGet(x => x.RecipientIdentifier).Returns(_scId.ToString("D11"));

            _securityInfoProvider.SetupGet(x => x.SenderType).Returns(SenderType.Terminal);

            _securityInfoProvider.SetupGet(x => x.PublicKeyOwner).Returns(PublicKeyOwnerType.ServiceCenter);

            _comConfig = SiConfig.Dev();

            _requestResponseClientProtocol =
                new RequestResponseClientRequestResponseProtocol(new ClientFrameAdapter(new PullComClient()),
                    new ClientMessageDispatcher(),
                    MessageVersionMapper.Builder.AddFromAssemblyOfType<SessionStart>().Build());
            _requestResponseClientProtocol.WithSecurityProvider(_securityInfoProvider.Object);
        }

        private static readonly ILog _log = LogManager.GetLogger(typeof (SiConfigTests));
        private Mock<IProvideSecurityInfo> _securityInfoProvider;
        private RequestResponseClientRequestResponseProtocol _requestResponseClientProtocol;
        private ComConfig _comConfig;
        private Mock<IClientSessionHandler> _testHandler;
        private readonly string _trmWithCfgNtf = "21011222"; //610000001
        private readonly byte[] _trmWithCfgCompSecret = "0x483B8FC350D0557303D67DB1D53858F7".AsHexBytes();
        private readonly string _trmWithResetNtf = "20074641"; //610000002
        private readonly byte[] _trmWithResetNtfCompSecret = "0x21F67299BFCE2F39F336AFBC4D65943A".AsHexBytes();
        private readonly long _scId = 8000000001;
        private readonly string _scIdStr = "08000000001";

        private readonly string _pubkey =
            "800000000101121001018003C4213D101DE8E6FD8259730711AB377A1BF0EBC1E66578FBC1497E0F20C79BC858FFAA2A139B98B6D234CB2DAD25A193AE9EF056824736396DA2F9314AEA525407C80CA69C86E975F8ED5CC2E4BAFFE8D78D22B25E398A50242AAC3C22A6FB69696C959CED0EED04D5A0CB29FCFF160424D855DD6B886C24196485DD6DCD8F83010001373BFDC75FF0D8A30893E002A798B5BDB89D9C66";

        [Category("Integration")]
        [Test]
        [TestCase]
        public void Given_DoCatchCOnfig()
        {
            _securityInfoProvider.SetupGet(x => x.SenderIdentifier).Returns(_trmWithCfgNtf);
            _securityInfoProvider.SetupGet(x => x.CompSecret).Returns(_trmWithCfgCompSecret);

            var sessStartHandler = _testHandler.As<IStartWith<SessionStart>>();
            var resetTrmNotificationHandler = _testHandler.As<IHandleMessage<ResetTerminalNotification>>();
            var dataNotificationHandler = _testHandler.As<IHandleMessage<ConfigDataNotificationV0500>>();
            var configNotificationHandler = _testHandler.As<IHandleMessage<ActivateConfigNotification>>();
            var sessionEnd = _testHandler.As<IHandleMessage<SessionEnd>>();
            var dataRequest = _testHandler.As<IHandleMessage<ConfigDataRequest>>();
            //var onError = _testHandler.As<IHandleError>();

            sessStartHandler.Setup(x => x.FirstMessage(It.IsAny<SessionStart>())).Callback((SessionStart s) =>
            {
                s.TrmID = _trmWithCfgNtf;
                s.SCID = _scId;
                s.MsgNum = 123;
                s.ConfDlMode = 1;
                s.AcqDatChanged = true;
            });

            configNotificationHandler.Setup(x => x.Respond(It.IsAny<ActivateConfigNotification>()))
                .Returns(new ActivateConfigAcknowledge
                {
                    TrmID = _trmWithCfgNtf,
                    SCID = _scId,
                    MsgNum = 777
                });

            dataNotificationHandler.Setup(x => x.Respond(It.IsAny<ConfigDataNotificationV0500>()))
                .Returns(new ConfigDataAcknowledge
                {
                    TrmID = _trmWithCfgNtf,
                    SCID = _scId,
                    MsgNum = 555
                });

            resetTrmNotificationHandler.Setup(x => x.Respond(It.IsAny<ResetTerminalNotification>()))
                .Returns(new ResetTerminalAcknowledge
                {
                    TrmID = _trmWithCfgNtf,
                    SCID = _scId,
                    MsgNum = 125
                });

            dataRequest.Setup(x => x.Respond(It.IsAny<ConfigDataRequest>())).Returns(new ConfigDataResponse
            {
                TrmID = _trmWithCfgNtf,
                SCID = _scId,
                MsgNum = 124
            });

            dataRequest.Setup(x => x.Respond(It.Is<ConfigDataRequest>(r => r.ConfDataObj == "TELD")))
                .Returns(new ConfigDataResponse
                {
                    TrmID = _trmWithCfgNtf,
                    SCID = _scId,
                    MsgNum = 124,
                    Teld =
                        "ASATBhIESScAACAEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAJjAYnxwIMzAzODA0MjmfhAoEUgEgk5+EHwEBASATBhIEWQYAAEBDAAAAAGVwMnRyYW5zcG9ydC5jcHAgKDUxMikAAAAAAAAAAAAAAAAARTArnxwIMzAzODA0MjmfhAoEUgEgk5+Efw4xOTIuMTY4LjIyMS4yMJ+FAAIyAAQgEwYSBFkQAAAgAoAHADxlcDJzcnYuY3BwICgxMDU1KQAAAAAAAAAAAAAAAAAAAAAAACUwF58cCDMwMzgwNDI5n4QKBFIBIJOfAQEBBCATBhIEWRYAACACgAcAaGVwMnNydi5jcHAgKDEwNTUpAAAAAAAAAAAAAAAAAAAAAAAAJTAXnxwIMzAzODA0MjmfhAoEUgEgk58BAQQEIBMGEgRZIgAAIAKABApnZXAyc3J2LmNwcCAoMTA1NSkAAAAAAAAAAAAAAAAAAAAAAAAlMBefHAgzMDM4MDQyOZ+ECgRSASCTnwEBkwQgEwYSBFkoAAAgAoAECmdlcDJzcnYuY3BwICgxMDU1KQAAAAAAAAAAAAAAAAAAAAAAACUwF58cCDMwMzgwNDI5n4QKBFIBIJOfAQGF"
                });

            var isDone = false;
            _testHandler.SetupGet(x => x.IsDone).Returns(isDone);
            //sessionEnd.Setup(x => x.Response(It.IsAny<SessionEnd>())).Returns(null);

            //act

            _requestResponseClientProtocol.SendWith(_comConfig, _testHandler.Object);

            dataRequest.Verify(x => x.Respond(It.Is<ConfigDataRequest>(r => r.ConfDataObj == "ACD")), Times.Once());
            //dataRequest.Verify(x => x.Response(It.Is<DataRequest>(r => r.ConfDataObj == "AISD")), Times.Once());
            dataRequest.Verify(x => x.Respond(It.Is<ConfigDataRequest>(r => r.ConfDataObj == "CPTD")), Times.Once());
            dataRequest.Verify(x => x.Respond(It.Is<ConfigDataRequest>(r => r.ConfDataObj == "TACD")), Times.Once());
            dataRequest.Verify(x => x.Respond(It.Is<ConfigDataRequest>(r => r.ConfDataObj == "TCACD")), Times.Once());
            dataRequest.Verify(x => x.Respond(It.Is<ConfigDataRequest>(r => r.ConfDataObj == "TELD")), Times.Once());

            sessionEnd.Verify(x => x.Respond(It.IsAny<SessionEnd>()), Times.Once());
        }

        [Test]
        [ExpectedException(typeof (Ep2RemoteReturnedErrorException))]
        public void Given_ErrorMessageAndNoHandler_Exception()
        {
            _comConfig.Version = "0100";
            _securityInfoProvider.SetupGet(x => x.SenderIdentifier).Returns(_trmWithResetNtf);
            _securityInfoProvider.SetupGet(x => x.CompSecret).Returns(_trmWithResetNtfCompSecret);

            var sessStartHandler = _testHandler.As<IStartWith<SessionStartV01>>();

            sessStartHandler.Setup(x => x.FirstMessage(It.IsAny<SessionStartV01>())).Callback((SessionStartV01 s) =>
            {
                s.TrmID = _trmWithResetNtf;
                s.SCID = _scId;
                s.MsgNum = 123;
            });

            _requestResponseClientProtocol.SendWith(_comConfig, _testHandler.Object);
        }

        [Test]
        public void Given_ServerError_TheServerDoesNotDropTheConnection()
        {
            _securityInfoProvider.SetupGet(x => x.SenderIdentifier).Returns(_trmWithResetNtf);
            _securityInfoProvider.SetupGet(x => x.CompSecret).Returns(_trmWithResetNtfCompSecret);

            var sessStartHandler = _testHandler.As<IStartWith<SessionStart>>();
            var errorHandler = _testHandler.As<IHandleMessage<ErrorNotification>>();
            //   var request = _testHandler.As<IHandleMessage<DataRequest>>();

            //errorHandler.Setup(x => x.OnError(It.IsAny<ErrorNotification>()));

            sessStartHandler.Setup(x => x.FirstMessage(It.IsAny<SessionStart>())).Callback((SessionStart s) =>
            {
                s.TrmID = _trmWithResetNtf;
                s.SCID = _scId;
            });

            errorHandler.Setup(x => x.Respond(It.IsAny<ErrorNotification>())).Returns(new SessionStart
            {
                TrmID = _trmWithResetNtf,
                SCID = _scId,
                MsgNum = 10
            }
                );

            _testHandler.Setup(x => x.EnrichErrorMessage(It.IsAny<ErrorNotification>(), null))
                .Callback((ErrorNotification e, Exception ex) =>
                {
                    e.SCId = _scIdStr;
                    e.TerminalId = _trmWithResetNtf;
                });

            _requestResponseClientProtocol.SendWith(_comConfig, _testHandler.Object);

            _testHandler.Verify(
                x =>
                    x.EnrichErrorMessage(It.Is<ErrorNotification>(e => e.ErrorCode == ErrorCodes.UnexpectedMessage),
                        It.IsAny<Exception>()),
                Times.Once());
            // errorHandler.Verify(x => x.OnError(It.Is<ErrorNotification>(e => e.ErrorCode == 115)), Times.Once());
        }

        [Category("Integration")]
        [Test]
        public void Given_TerminalNeedsConfig_TELDSent_AndConfigSent()
        {
            _log.Info("Start");

            _securityInfoProvider.SetupGet(x => x.CompSecret).Returns(_trmWithCfgCompSecret);
            _securityInfoProvider.SetupGet(x => x.SenderIdentifier).Returns(_trmWithCfgNtf);

            var sessStartHandler = _testHandler.As<IStartWith<SessionStart>>();
            var resetTrmNotificationHandler = _testHandler.As<IHandleMessage<ResetTerminalNotification>>();
            var dataNotificationHandler = _testHandler.As<IHandleMessage<ConfigDataNotificationV0500>>();
            var configNotificationHandler = _testHandler.As<IHandleMessage<ActivateConfigNotification>>();
            var sessionEnd = _testHandler.As<IHandleMessage<SessionEnd>>();
            //var onError = _testHandler.As<IHandleError>();

            configNotificationHandler.Setup(x => x.Respond(It.IsAny<ActivateConfigNotification>()))
                .Returns(new ActivateConfigAcknowledge
                {
                    TrmID = _trmWithCfgNtf,
                    SCID = _scId,
                    MsgNum = 777
                });

            dataNotificationHandler.Setup(x => x.Respond(It.IsAny<ConfigDataNotificationV0500>()))
                .Returns(new ConfigDataAcknowledge
                {
                    TrmID = _trmWithCfgNtf,
                    SCID = _scId,
                    MsgNum = 555
                });

            resetTrmNotificationHandler.Setup(x => x.Respond(It.IsAny<ResetTerminalNotification>()))
                .Returns(new ResetTerminalAcknowledge
                {
                    TrmID = _trmWithCfgNtf,
                    SCID = _scId,
                    MsgNum = 125
                });

            sessStartHandler.Setup(x => x.FirstMessage(It.IsAny<SessionStart>())).Callback((SessionStart s) =>
            {
                s.TrmID = _trmWithCfgNtf;
                s.SCID = _scId;
                s.MsgNum = 123;

                // s.ConfDlMode = 10;
            });
            var dataRequest = _testHandler.As<IHandleMessage<ConfigDataRequest>>();
            dataRequest.Setup(x => x.Respond(It.IsAny<ConfigDataRequest>())).Returns(new ConfigDataResponse
            {
                TrmID = _trmWithCfgNtf,
                SCID = _scId,
                MsgNum = 124,
                Teld =
                    "ASATBhIESScAACAEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAJjAYnxwIMzAzODA0MjmfhAoEUgEgk5+EHwEBASATBhIEWQYAAEBDAAAAAGVwMnRyYW5zcG9ydC5jcHAgKDUxMikAAAAAAAAAAAAAAAAARTArnxwIMzAzODA0MjmfhAoEUgEgk5+Efw4xOTIuMTY4LjIyMS4yMJ+FAAIyAAQgEwYSBFkQAAAgAoAHADxlcDJzcnYuY3BwICgxMDU1KQAAAAAAAAAAAAAAAAAAAAAAACUwF58cCDMwMzgwNDI5n4QKBFIBIJOfAQEBBCATBhIEWRYAACACgAcAaGVwMnNydi5jcHAgKDEwNTUpAAAAAAAAAAAAAAAAAAAAAAAAJTAXnxwIMzAzODA0MjmfhAoEUgEgk58BAQQEIBMGEgRZIgAAIAKABApnZXAyc3J2LmNwcCAoMTA1NSkAAAAAAAAAAAAAAAAAAAAAAAAlMBefHAgzMDM4MDQyOZ+ECgRSASCTnwEBkwQgEwYSBFkoAAAgAoAECmdlcDJzcnYuY3BwICgxMDU1KQAAAAAAAAAAAAAAAAAAAAAAACUwF58cCDMwMzgwNDI5n4QKBFIBIJOfAQGF"
            });

            var isDone = false;
            _testHandler.SetupGet(x => x.IsDone).Returns(isDone);
            //sessionEnd.Setup(x => x.Response(It.IsAny<SessionEnd>())).Returns(null);

            //act
            _requestResponseClientProtocol.SendWith(_comConfig, _testHandler.Object);

            //resetTrmNotificationHandler.Verify(x => x.Response(It.IsAny<ResetTerminalNotification>()), Times.Once());
            dataNotificationHandler.Verify(
                x =>
                    x.Respond(
                        It.Is<ConfigDataNotificationV0500>(
                            n => n.Aisd[0].CommAddrAcqInitSrv.CommIpAddr == "153.46.226.2"
                                 && n.tcd.MaxFinAdvQueueSize == 20
                                 && n.tcd.DataSubmTrigg == 0)),
                Times.Once());
        }

        [Category("Integration")]
        [Test]
        public void Given_TerminalNeedsOnlyTeld()
        {
            _securityInfoProvider.SetupGet(x => x.SenderIdentifier).Returns(_trmWithCfgNtf);
            _securityInfoProvider.SetupGet(x => x.CompSecret).Returns(_trmWithCfgCompSecret);

            var sessStartHandler = _testHandler.As<IStartWith<SessionStart>>();
            var sessionEnd = _testHandler.As<IHandleMessage<SessionEnd>>();
            var dataRequest = _testHandler.As<IHandleMessage<ConfigDataRequest>>();
            //var onError = _testHandler.As<IHandleError>();

            sessStartHandler.Setup(x => x.FirstMessage(It.IsAny<SessionStart>())).Callback((SessionStart s) =>
            {
                s.TrmID = _trmWithCfgNtf;
                s.SCID = _scId;
                s.MsgNum = 123;
                s.ConfDlMode = 10;
            });

            dataRequest.Setup(x => x.Respond(It.IsAny<ConfigDataRequest>())).Returns(new ConfigDataResponse
            {
                TrmID = _trmWithResetNtf,
                SCID = _scId,
                MsgNum = 124,
                Teld =
                    "ASATBhIESScAACAEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAJjAYnxwIMzAzODA0MjmfhAoEUgEgk5+EHwEBASATBhIEWQYAAEBDAAAAAGVwMnRyYW5zcG9ydC5jcHAgKDUxMikAAAAAAAAAAAAAAAAARTArnxwIMzAzODA0MjmfhAoEUgEgk5+Efw4xOTIuMTY4LjIyMS4yMJ+FAAIyAAQgEwYSBFkQAAAgAoAHADxlcDJzcnYuY3BwICgxMDU1KQAAAAAAAAAAAAAAAAAAAAAAACUwF58cCDMwMzgwNDI5n4QKBFIBIJOfAQEBBCATBhIEWRYAACACgAcAaGVwMnNydi5jcHAgKDEwNTUpAAAAAAAAAAAAAAAAAAAAAAAAJTAXnxwIMzAzODA0MjmfhAoEUgEgk58BAQQEIBMGEgRZIgAAIAKABApnZXAyc3J2LmNwcCAoMTA1NSkAAAAAAAAAAAAAAAAAAAAAAAAlMBefHAgzMDM4MDQyOZ+ECgRSASCTnwEBkwQgEwYSBFkoAAAgAoAECmdlcDJzcnYuY3BwICgxMDU1KQAAAAAAAAAAAAAAAAAAAAAAACUwF58cCDMwMzgwNDI5n4QKBFIBIJOfAQGF"
            });

            //act
            _requestResponseClientProtocol.SendWith(_comConfig, _testHandler.Object);

            sessionEnd.Verify(x => x.Respond(It.IsAny<SessionEnd>()), Times.Once());
        }

        [Category("Integration")]
        [Test]
        public void Given_TerminalStartsSession_and_SendsErrorNtft()
        {
            _log.Info("Start");

            _securityInfoProvider.SetupGet(x => x.SenderIdentifier).Returns(_trmWithResetNtf);
            _securityInfoProvider.SetupGet(x => x.CompSecret).Returns(_trmWithResetNtfCompSecret);

            var sessStartHandler = _testHandler.As<IStartWith<SessionStart>>();

            sessStartHandler.Setup(x => x.FirstMessage(It.IsAny<SessionStart>())).Callback((SessionStart s) =>
            {
                s.TrmID = _trmWithResetNtf;
                s.SCID = _scId;
                s.MsgNum = 123;
                // s.ConfDlMode = 10;
            });
            var dataRequest = _testHandler.As<IHandleMessage<ConfigDataRequest>>();
            dataRequest.Setup(x => x.Respond(It.IsAny<ConfigDataRequest>())).Returns(new ErrorNotification
            {
                TerminalId = _trmWithResetNtf
            });

            _testHandler.SetupGet(x => x.IsDone).Returns(true);
            //act
            _requestResponseClientProtocol.SendWith(_comConfig, _testHandler.Object);

            dataRequest.Verify(x => x.Respond(It.IsAny<ConfigDataRequest>()), Times.Once());
        }

        [Category("Integration")]
        [Test]
        public void Given_TheTerminalNeedsReset_RightMessages_Sent()
        {
            _log.Info("Start");

            _securityInfoProvider.SetupGet(x => x.SenderIdentifier).Returns(_trmWithResetNtf);
            _securityInfoProvider.SetupGet(x => x.CompSecret).Returns(_trmWithResetNtfCompSecret);

            var sessStartHandler = _testHandler.As<IStartWith<SessionStart>>();
            var resetTrmNotificationHandler = _testHandler.As<IHandleMessage<ResetTerminalNotification>>();

            sessStartHandler.Setup(x => x.FirstMessage(It.IsAny<SessionStart>())).Callback((SessionStart s) =>
            {
                s.TrmID = _trmWithResetNtf;
                s.SCID = _scId;
                s.MsgNum = 123;
                // s.AcqDatChanged = 1;
                // s.ConfDlMode = -1;
            });

            var dataRequest = _testHandler.As<IHandleMessage<ConfigDataRequest>>();
            dataRequest.Setup(x => x.Respond(It.IsAny<ConfigDataRequest>())).Returns(new ConfigDataResponse
            {
                TrmID = _trmWithResetNtf,
                SCID = _scId,
                MsgNum = 124,
                Teld =
                    "ASATBhIESScAACAEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAJjAYnxwIMzAzODA0MjmfhAoEUgEgk5+EHwEBASATBhIEWQYAAEBDAAAAAGVwMnRyYW5zcG9ydC5jcHAgKDUxMikAAAAAAAAAAAAAAAAARTArnxwIMzAzODA0MjmfhAoEUgEgk5+Efw4xOTIuMTY4LjIyMS4yMJ+FAAIyAAQgEwYSBFkQAAAgAoAHADxlcDJzcnYuY3BwICgxMDU1KQAAAAAAAAAAAAAAAAAAAAAAACUwF58cCDMwMzgwNDI5n4QKBFIBIJOfAQEBBCATBhIEWRYAACACgAcAaGVwMnNydi5jcHAgKDEwNTUpAAAAAAAAAAAAAAAAAAAAAAAAJTAXnxwIMzAzODA0MjmfhAoEUgEgk58BAQQEIBMGEgRZIgAAIAKABApnZXAyc3J2LmNwcCAoMTA1NSkAAAAAAAAAAAAAAAAAAAAAAAAlMBefHAgzMDM4MDQyOZ+ECgRSASCTnwEBkwQgEwYSBFkoAAAgAoAECmdlcDJzcnYuY3BwICgxMDU1KQAAAAAAAAAAAAAAAAAAAAAAACUwF58cCDMwMzgwNDI5n4QKBFIBIJOfAQGF"
            });

            resetTrmNotificationHandler.Setup(x => x.Respond(It.IsAny<ResetTerminalNotification>()))
                .Returns(new ResetTerminalAcknowledge
                {
                    TrmID = _trmWithResetNtf,
                    SCID = _scId,
                    MsgNum = 125
                });

            //act
            _requestResponseClientProtocol.SendWith(_comConfig, _testHandler.Object);

            resetTrmNotificationHandler.Verify(x => x.Respond(It.IsAny<ResetTerminalNotification>()), Times.Once());

            // do not acknoledge the last message because it will set the HasChanges value to zero
        }

        [Category("Integration")]
        [Test]
        public void Given_UnsupportedVersion_RightMessages_Sent()
        {
            _comConfig.Version = "0100";
            _securityInfoProvider.SetupGet(x => x.SenderIdentifier).Returns(_trmWithResetNtf);
            _securityInfoProvider.SetupGet(x => x.CompSecret).Returns(_trmWithResetNtfCompSecret);

            var sessStartHandler = _testHandler.As<IStartWith<SessionStartV01>>();
            var errorHandler = _testHandler.As<IHandleMessage<ErrorNotification>>();

            sessStartHandler.Setup(x => x.FirstMessage(It.IsAny<SessionStartV01>())).Callback((SessionStartV01 s) =>
            {
                s.TrmID = _trmWithResetNtf;
                s.SCID = _scId;
                s.MsgNum = 123;
            });

            _requestResponseClientProtocol.SendWith(_comConfig, _testHandler.Object);

            errorHandler.Verify(x => x.Respond(It.IsAny<ErrorNotification>()), Times.Once());
        }
    }
}