using System;
using System.Collections.Generic;
using NUnit.Framework;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;
using SIX.SCS.QA.Tests.EP2.Message;
using SIX.SCS.QA.Tests.EP2.Message.Basic;
using SIX.SCS.QA.Tests.EP2.Test;

namespace SIX.SCS.QA.Tests.EP2.Data
{
    public class LaidRequestHandler :
        IClientSessionHandler,
        IStartWith<ConfigDataRequest>,
        IHandleMessage<ConfigDataResponse>,
        IHandleMessage<ErrorNotification>

    {
        private readonly Laid _myService;

        public LaidRequestHandler(Laid myService)
        {
            _myService = myService;
        }

        public IList<string> ListOfAid { get; private set; }

        public void EnrichErrorMessage(ErrorNotification errorNotification, Exception ex)
        {
        }

        public bool IsDone
        {
            get { return true; }
        }

        public IMessage Respond(ConfigDataResponse rsp)
        {
            _myService.ListOfAid = rsp.ListAID.AID;
            return rsp;
        }

        public IMessage Respond(ErrorNotification err)
        {
            Assert.Fail("An Eror occured: [{0}] {1}", err.ErrorCode, err.ErrorDescription);
            return err;
        }

        public void FirstMessage(ConfigDataRequest rq)
        {
            rq.ConfDataObj = _myService.ConfDataObj;
            rq.SCID = _myService.ScId;
            rq.AcqID = _myService.AcqId;
        }
    }
}