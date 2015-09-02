namespace Six.Scs.Test.Factory
{
    public class Mpd
    {
        public static Model.Mpd Create()
        {
            return new Model.Mpd
            {
                Adress = "Adress",
                Port = "Port",
                Description = "SYR MPD" + Base.GenerateTestId()
            };
        }

        public static Model.Mpd Edit()
        {
            return new Model.Mpd
            {
                Adress = "Adress Edit",
                Port = "Port E",
                Description = "SYR MPD" + Base.GenerateTestId()
            };
        }
    }
}