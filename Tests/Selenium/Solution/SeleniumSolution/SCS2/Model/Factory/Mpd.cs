namespace Six.Scs.Test.Model.Factory
{
    public class Mpd
    {
        public static Model.Mpd Create()
        {
            return new Model.Mpd
            {
                Adress = "Adress",
                Port = "Port",
                Description = "SYR MPD" + Factory.GenerateTestId()
            };
        }

        public static Model.Mpd Edit()
        {
            return new Model.Mpd
            {
                Adress = "Adress Edit",
                Port = "Port E",
                Description = "SYR MPD" + Factory.GenerateTestId()
            };
        }
    }
}