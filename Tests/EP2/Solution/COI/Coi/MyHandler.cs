using System;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;

namespace SIX.SCS.QA.Tests.EP2.Coi
{
    public class MyHandler :
        IClientSessionHandler,
        IStartWith<ConfigDataNotification>,
        IHandleMessage<ConfigResponse>,
        IHandleMessage<ErrorNotification>

    {
        public void EnrichErrorMessage(ErrorNotification errorNotification, Exception ex)
        {
        }

        public bool IsDone
        {
            get { return true; }
        }

        public IMessage Respond(ConfigResponse request)
        {
            return null;
        }

        public IMessage Respond(ErrorNotification request)
        {
            return null;
        }

        public void FirstMessage(ConfigDataNotification msg)
        {
            msg.AcqID = "3";
        }
    }
}