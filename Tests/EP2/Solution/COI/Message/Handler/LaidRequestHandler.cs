using System;
using NUnit.Framework;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;
using SIX.SCS.QA.Tests.EP2.Message.Basic;
using SIX.SCS.QA.Tests.EP2.Message.Elements;

namespace SIX.SCS.QA.Tests.EP2.Message.Handler
{
    public class LaidRequestHandler :
        IClientSessionHandler,
        IStartWith<ConfigDataRequest>,
        IHandleMessage<ConfigDataResponse>,
        IHandleMessage<ErrorNotification>

    {
        private readonly ConfigDataRequest _rq;
        public ListAID ListOfAid;
        public ErrorNotification Error;

        public LaidRequestHandler(ConfigDataRequest rq)
        {
            _rq = rq;
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
            ListOfAid = response.ListAID;
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
            request.ConfDataObj = _rq.ConfDataObj;
            request.SCID = _rq.SCID;
            request.AcqID = _rq.AcqID;
        }
    }
}