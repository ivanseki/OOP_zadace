using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Xml.Serialization;

namespace Windchill
{
    public class DailyForecastRepository : IEnumerable
    {
        private List<DailyForecast> forecasts;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }

        public ForecastsEnum GetEnumerator()
        {
            return new ForecastsEnum(forecasts);
        }
        

        public DailyForecastRepository()
        {
            this.forecasts = new List<DailyForecast>();
        }

        public DailyForecastRepository(DailyForecastRepository repo) : this()
        {
            foreach(DailyForecast forecast in forecasts)
            {
                DailyForecast copy = new DailyForecast(forecast.Day, forecast.Weather);
            }
        }

        public void Add(DailyForecast forecast)
        {
            if(!forecasts.Any(f => f.Day.Date == forecast.Day.Date))
                this.forecasts.Add(forecast);
            else
            {
                forecasts[forecasts.FindIndex(f => f.Day.Date == forecast.Day.Date)].Day = forecast.Day;
                forecasts[forecasts.FindIndex(f => f.Day.Date == forecast.Day.Date)].Weather = forecast.Weather;
            }
            
            this.forecasts.Sort((x, y) => x.Day.Date.CompareTo(y.Day.Date));
        }
        
        public void Add(List<DailyForecast> forecast)
        {
            foreach(DailyForecast f in forecast)
            {
                if (!forecasts.Any(fc => fc.Day.Date == f.Day.Date))
                    this.forecasts.Add(f);
                else
                {
                    forecasts[forecasts.FindIndex(fc => fc.Day.Date == f.Day.Date)].Day = f.Day;
                    forecasts[forecasts.FindIndex(fc => fc.Day.Date == f.Day.Date)].Weather = f.Weather;
                }
            }
            
            this.forecasts.Sort((x, y) => x.Day.Date.CompareTo(y.Day.Date));
        }

        public void Remove(DateTime date)
        {
            if (!forecasts.Any(f => f.Day.Date == date.Date))
                throw new NoSuchDailyWeatherException($"No daily forecast for {date.Date}");

            this.forecasts.RemoveAll(f => f.Day.Date == date.Date);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, forecasts);
        }
    }
}