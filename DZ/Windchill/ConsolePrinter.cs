using System;

namespace Windchill
{
    public class ConsolePrinter : IPrinter
    {
        private ConsoleColor consoleColor;

        public void SetConsoleColor(ConsoleColor consoleColour)
        {
            this.consoleColor = consoleColour;
        }
        
        public ConsolePrinter(ConsoleColor consoleColour)
        {
            this.consoleColor = consoleColour;
        }
        
        public void Print(Weather weather)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(weather.ToString());
        }
    }
}