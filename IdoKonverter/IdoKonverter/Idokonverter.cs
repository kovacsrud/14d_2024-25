namespace IdoKonverter
{
    public static class Idokonverter
    {
        public static int MinuteToSec(int minute)
        {
            return minute * 60;
        }

        public static int SecToMillisec(int sec) {

            return sec * 1000;

        }

        public static double SecToMinute(double sec) {
            return sec / 60;
        }

        public static int HourToSec(int hour)
        {
            return hour * 60 * 60;
        }
    }
}
