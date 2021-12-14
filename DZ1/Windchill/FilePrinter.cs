using System;
using System.IO;
using System.Threading.Channels;

namespace Windchill
{
    public class FilePrinter : IPrinter
    {
        private string fileName;

        void SetFileName(string file)
        {
            this.fileName = file;
        }

        public FilePrinter(string file)
        {
            this.fileName = file;
        }

        public void Print(Weather weather)
        {
            using StreamWriter file = new StreamWriter(fileName, append: true);
            file.WriteLine(weather.ToString());
        }
    }
}