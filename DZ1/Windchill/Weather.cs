using System;
using System.Runtime.CompilerServices;

namespace Windchill
{
    public class Weather
    {
        private double Temperature;
        private double WindSpeed;
        private double Humidity;

        public Weather()
        {
            this.Temperature = 0;
            this.WindSpeed = 0;
            this.Humidity = 0;
        }

        public Weather(double temperature, double humidity, double windSpeed)
        {
            this.Temperature = temperature;
            this.WindSpeed = windSpeed;
            this.Humidity = humidity;
        }

        public void SetTemperature(double temperature)
        {
            this.Temperature = temperature;
        }

        public double GetTemperature()
        {
            return this.Temperature; 
        }

        public void SetWindSpeed(double windSpeed)
        {
            this.WindSpeed = windSpeed;
        }
        
        public double GetWindSpeed()
        {
            return this.WindSpeed; 
        }
        
        public void SetHumidity(double humidity)
        {
            this.Humidity = humidity;
        }
        
        public double GetHumidity()
        {
            return this.Humidity; 
        }
        
        public double CalculateFeelsLikeTemperature()
        {
            return (-8.78469475556 + (1.61139411 * Temperature) + (2.33854883889 * Humidity)
                    + (-0.14611605 * Temperature * Humidity) + (-0.012308094 * Math.Pow(Temperature, 2))
                    + (-0.0164248277778 * Math.Pow(Humidity, 2)) + (0.002211732 * Math.Pow(Temperature, 2) * Humidity)
                    + (0.00072546 * Temperature * Math.Pow(Humidity, 2)) 
                    + (-0.000003582 * Math.Pow(Temperature, 2) * Math.Pow(Humidity, 2))
                    );
        }
        
        public double CalculateWindChill()
        {
            if (Temperature <= 10 && WindSpeed > 4.8)
            {
                return (13.12 + 0.6215 * Temperature - 11.37 * Math.Pow(WindSpeed, 0.16) +
                        0.3965 * Temperature * Math.Pow(WindSpeed, 0.16));
            }
            else
            {
                return 0;
            }
        }
    }
}
