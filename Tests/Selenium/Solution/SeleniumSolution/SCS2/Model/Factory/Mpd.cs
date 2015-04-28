namespace Six.Scs.QA.Application.Model.Factory
{
    public class Mpd
    {
        public static ValueObjects.Mpd Create()
        {
            return new ValueObjects.Mpd
            {
                Adress = "Adress",
                Port = "Port",
                Description = "SYR MPD" + Factory.GenerateTestId()
            };
        }

        public static ValueObjects.Mpd Edit()
        {
            return new ValueObjects.Mpd
            {
                Adress = "Adress Edit",
                Port = "Port E",
                Description = "SYR MPD" + Factory.GenerateTestId()
            };
        }
    }
}