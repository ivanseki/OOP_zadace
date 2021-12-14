using System;
using System.Data;

namespace Windchill
{
    public class WeatherGenerator
    {
        public double MinTemperature { get; private set; }
        public double MaxTemperature { get; private set; }
        public double MinHumidity { get; private set; }
        public double MaxHumidity { get; private set; }
        public double MinWindSpeed { get; private set; }
        public double MaxWindSpeed { get; private set; }
        public IRandomGenerator Generator {get; private set; }
        
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