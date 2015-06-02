using System;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;
using SIX.SCS.QA.Tests.EP2.Message;
using SIX.SCS.QA.Tests.EP2.Message.Basic;

namespace SIX.SCS.QA.Tests.EP2.Setup
{
    public class MyHandler :
        IClientSessionHandler,
        IStartWith<ConfigDataNotification>,
        IHandleMessage<ConfigDataResponse>,
        IHandleMessage<ErrorNotification>

    {
        public void EnrichErrorMessage(ErrorNotification errorNotification, Exception ex)
        {
            errorNotification.ErrorCode = 33;
        }

        public bool IsDone
        {
            get { return true; }
        }

        public IMessage Respond(ConfigDataResponse request)
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
            msg.SCID = "8000000001";
        }
    }
}