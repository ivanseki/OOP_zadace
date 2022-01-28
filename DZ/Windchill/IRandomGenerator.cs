using System;

namespace Windchill
{
    public interface IRandomGenerator
    {
        double Generate(double min, double max);
    }
}