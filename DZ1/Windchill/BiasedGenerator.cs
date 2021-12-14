using System;

namespace Windchill
{
    public class BiasedGenerator : IRandomGenerator
    {
        private Random generator;
        
        public BiasedGenerator(Random generator)
        {
            this.generator = generator;
        }

        public double Generate(double min, double max)
        {
            double rand;
            Random randomGenerator = new Random();

            rand = randomGenerator.NextDouble();

            if(rand < (2.0 / 3.0))
                return (min + generator.NextDouble() * (max / 2 - min));
            else
                return (max / 2 + generator.NextDouble() * (max - max / 2));
        }
    }
}