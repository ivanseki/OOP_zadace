using System;

namespace Windchill
{
    public class ForecastUtilities
    {
        public static Weather FindWeatherWithLargestWindchill(Weather[] weather)
        {
            Weather WeatherWithLargestWindchill = weather[0];
            
            for (int i = 1; i < weather.Length; ++i)
            {
                if (weather[i].CalculateWindChill() > WeatherWithLargestWindchill.CalculateWindChill())
                    WeatherWithLargestWindchill = weather[i];
            }

            return WeatherWithLargestWindchill;
        }

        public static DailyForecast Parse(string dailyWeatherInput)
        {
            string[] day = dailyWeatherInput.Split(",");
            Weather weather = new Weather(Convert.ToDouble(day[1]), Convert.ToDouble(day[3]), Convert.ToDouble(day[2]));
            DailyForecast tempForecast = new DailyForecast(Convert.ToDateTime(day[0]), weather);

            return tempForecast;
        }

        public static void PrintWeathers(IPrinter[] printers, Weather[] weathers)
        {
            foreach(IPrinter printer in printers)
            {
                foreach(Weather weather in weathers)
                {
                    printer.Print(weather);
                }
            }
        }
    }
}