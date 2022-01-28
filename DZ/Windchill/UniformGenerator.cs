using System;

namespace Windchill
{
    public class UniformGenerator : IRandomGenerator
    {
        private Random generator;
        
        public UniformGenerator(Random generator)
        {
            this.generator = generator;
        }

        public double Generate(double min, double max)
        {
            return (min + generator.NextDouble() * (max - min));
        }
    }
}