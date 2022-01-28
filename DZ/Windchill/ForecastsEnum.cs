using System;
using System.Collections;
using System.Collections.Generic;

namespace Windchill
{
    public class ForecastsEnum : IEnumerator
    {
        public List<DailyForecast> _forecasts;
        
        int position = -1;

        public ForecastsEnum(List<DailyForecast> list)
        {
            _forecasts = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _forecasts.Count);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public DailyForecast Current
        {
            get
            {
                try
                {
                    return _forecasts[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}