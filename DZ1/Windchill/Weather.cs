namespace Windchill
{
    public class Weather
    {
        private int Temperature;
        private int WindSpeed;
        private int Humidity;

        public Weather(int temperature, int windSpeed, int humidity)
        {
            this.Temperature = temperature;
            this.WindSpeed = windSpeed;
            this.Humidity = humidity;
        }
        
    }
}