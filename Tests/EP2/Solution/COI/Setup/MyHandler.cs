using System;
using Six.Scs.Ep2.Coi.Message;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;

namespace Six.Scs.Ep2.Coi.Setup
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
            msg.AcqId = "3";
            msg.ScId = "8000000001";
        }
    }
}