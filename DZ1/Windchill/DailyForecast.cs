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

        public string GetAsString()
        {
            return $"{Day.ToString()}: {Weather.GetAsString()}";
        }

    }
}