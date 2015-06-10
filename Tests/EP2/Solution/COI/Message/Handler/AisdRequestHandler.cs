using System;
using Six.Scs.Ep2.Coi.Message.Elements;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;

namespace Six.Scs.Ep2.Coi.Message.Handler
{
    public class AisdRequestHandler :
        IClientSessionHandler,
        IStartWith<ConfigDataRequest>,
        IHandleMessage<ConfigDataResponse>,
        IHandleMessage<ErrorNotification>

    {
        private readonly ConfigDataRequest _request;
        public Aisd Aisd;
        public ErrorNotification Error;

        public AisdRequestHandler(ConfigDataRequest request)
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
            Aisd = response.Aisd;
            return response;
        }

        public IMessage Respond(ErrorNotification err)
        {
            Console.Out.WriteLine("An Eror occured: [{0}] {1}", err.ErrorCode, err.ErrorDescription);
            Error = err;
            return err;
        }

        public void FirstMessage(ConfigDataRequest request)
        {
            request.ConfDataObj = _request.ConfDataObj;
            request.ScId = _request.ScId;
            request.AcqId = _request.AcqId;
        }
    }
}