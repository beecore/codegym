using System;
using System.Globalization;
using System.IO;

namespace W8_3_csv
{
    internal class Country
    {
        public string IPX { get; set; }
        public string IPY { get; set; }
        public string CorX { get; set; }
        public string CorY { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    internal class ReadWritecsv
    {
        public static void ReadCSV()
        {
            StreamReader reader = new StreamReader("C:\\MyData\\data.csv");
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] values = line.Split(',');
                foreach (var value in values)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            ReadWritecsv.ReadCSV();
            Console.ReadLine();
        }
    }
}