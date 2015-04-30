﻿using NUnit.Framework;
using Six.Scs.Test.Workflow;

namespace Six.Scs.Test
{
    public class Mpd
    {
        public static Model.ValueObjects.Mpd Create(Model.ValueObjects.Customer customer)
        {
            Customer.Open(customer);

            var mpd = Model.Factory.Mpd.Create();
            Workflow.Mpd.Create(mpd);
            Check(mpd);

            Lobby.OpenLatestElement();
            Check(mpd);
            return mpd;
        }

        public static Model.ValueObjects.Mpd Edit(Model.ValueObjects.Mpd _mpd)
        {
            Open(_mpd);
            var mpd = Model.Factory.Mpd.Edit();
            mpd.Id = _mpd.Id; // keep Id

            Workflow.Mpd.Edit(mpd);
            Check(mpd);

            Lobby.OpenLatestElement();
            Check(mpd);
            return mpd;
        }

        public static void Open(Model.ValueObjects.Mpd mpd)
        {
            Search.MpdCanBeFoundById(mpd.Id);
        }

        public static void Check(Model.ValueObjects.Mpd m)
        {
            Assert.AreEqual(m.Id, View.Mpd.View.Id);
            Assert.AreEqual(m.Description, View.Mpd.View.Description);
            Assert.AreEqual(m.Adress, View.Mpd.View.Adress);
            Assert.AreEqual(m.Port, View.Mpd.View.Port);
        }
    }
}