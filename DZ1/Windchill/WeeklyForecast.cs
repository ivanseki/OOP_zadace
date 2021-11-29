namespace Windchill
{
    public class WeeklyForecast
    {
        private DailyForecast[] weeklyForecast { get; set; }

        public WeeklyForecast(DailyForecast[] weeklyforecast)
        {
            this.weeklyForecast = weeklyforecast;
        }

        public string GetAsString()
        {
            string temp = "";
            for(int i = 0; i < weeklyForecast.Length; ++i)
            {
                temp += weeklyForecast[i].GetAsString() + "\n";
            }
            
            return temp;
        }

        public double GetMaxTemperature()
        {
            DailyForecast tempDailyForecast = weeklyForecast[0];
            for (int i = 1; i < weeklyForecast.Length; ++i)
            {
                if(weeklyForecast[i].Weather.GetTemperature() > tempDailyForecast.Weather.GetTemperature())
                {
                    tempDailyForecast = weeklyForecast[i];
                }
            }

            return tempDailyForecast.Weather.GetTemperature();
        }
    }
}