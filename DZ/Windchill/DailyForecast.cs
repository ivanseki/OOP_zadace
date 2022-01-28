using System;

namespace Windchill
{
    public class DailyForecast
    {
        public DateTime Day { get; set; }
        public Weather Weather { get; set; }

        public DailyForecast(DateTime day, Weather weather)
        {
            this.Day = day;
            this.Weather = weather;
        }

        public override string ToString()
        {
            return $"{Day.ToString()}: {Weather.ToString()}";
        }

    }
}