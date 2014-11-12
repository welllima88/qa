﻿using System.Xml.Linq;
using NUnit.Framework;
using SIX.EP2.Client;
using SIX.EP2.Core.Comm;
using SIX.EP2.Core.Header;
using SIX.EP2.Core.SessionHandling;

namespace SIX.SCS.QA.Tests.EP2.COI
{
    [TestFixture]
    public class CoiNotificationTest
    {
        [SetUp]
        public void PrepareCoiMessage()
        {
            _commClient = new PullComClient();
            _commClient.Connect(new ComConfig {ServerAddress = "ep2host", Port = 1234});
            _sessionContext = SessionContext.StartClientSessionWithSec(new Ep2MessageVersion("600"),
                new ProvideSecurityInfo());
        }

        private SessionContext _sessionContext;
        private ICommClient _commClient;

        [Test]
        public void CreateSixTerminalwithBrandsAndDcc()
        {
            // Arrange
            // create ojbect, set values and build message

            // Act
            // send COI message via client to (configured) environment

            // Assert
            // that COI was sent and terminal is created in GUI
            
            
            EP2Frame frameout = _sessionContext.OutgoingFrame();
            frameout.ContentAsXmlContent().Xml = new XDocument(); // TODO dont know
            _commClient.Send(frameout);

            _sessionContext.OnFrameSent();
        }
    }
}