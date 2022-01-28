using System;
using System.Data;

namespace Windchill
{
    public class WeatherGenerator
    {
        private double MinTemperature;
        private double MaxTemperature;
        private double MinHumidity;
        private double MaxHumidity;
        private double MinWindSpeed;
        private double MaxWindSpeed;
        private IRandomGenerator Generator;

        public void SetGenerator(IRandomGenerator generator)
        {
            this.Generator = generator;
        }

        public WeatherGenerator(double minTemperature, double maxTemperature,
                                double minHumidity, double maxHumidity, 
                                double minWindSpeed, double maxWindSpeed, 
                                IRandomGenerator generator)
        {
            this.MinTemperature = minTemperature;
            this.MaxTemperature = maxTemperature;
            this.MinHumidity = minHumidity;
            this.MaxHumidity = maxHumidity;
            this.MinWindSpeed = minWindSpeed;
            this.MaxWindSpeed = maxWindSpeed;
            this.Generator = generator;
        }

        public Weather Generate()
        {
            return new Weather(Generator.Generate(MinTemperature, MaxTemperature),
                Generator.Generate(MinHumidity, MaxHumidity),
                Generator.Generate(MinWindSpeed, MaxWindSpeed));
        }
    }
}