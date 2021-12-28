using System;
using System.Runtime.Serialization;

namespace Windchill
{
    public class NoSuchDailyWeatherException : Exception
    {
        public NoSuchDailyWeatherException() { }
        public NoSuchDailyWeatherException(string message) : base(message) { }
        public NoSuchDailyWeatherException(string message, Exception innerException) : base(message, innerException) { }
        public NoSuchDailyWeatherException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}