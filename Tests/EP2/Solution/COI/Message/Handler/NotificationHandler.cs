using System;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;

namespace Six.Scs.Ep2.Coi.Message.Handler
{
    public class NotificationHandler :
        IClientSessionHandler,
        IStartWith<ConfigDataNotification>,
        IHandleMessage<ConfigDataResponse>,
        IHandleMessage<ErrorNotification>

    {
        private readonly ConfigDataNotification _request;
        public ErrorNotification Error;

        public NotificationHandler(ConfigDataNotification request)
        {
            _request = request;
        }

        public void EnrichErrorMessage(ErrorNotification errorNotification, Exception ex)
        {
        }

        public bool IsDone
        {
            get { return true; }
        }

        public IMessage Respond(ConfigDataResponse response)
        {
            return response;
        }

        public IMessage Respond(ErrorNotification err)
        {
            Console.Out.WriteLine("An Eror occured: [{0}] {1}", err.ErrorCode, err.ErrorDescription);
            Error = err;
            return err;
        }

        public void FirstMessage(ConfigDataNotification request)
        {
            request.DataProcCmd = _request.DataProcCmd;
            request.ScId = _request.ScId;
            request.AcqId = _request.AcqId;
            request.Ad = _request.Ad;
            request.Tcd = _request.Tcd;
        }
    }
}