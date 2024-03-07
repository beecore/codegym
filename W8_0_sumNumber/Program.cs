using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W8_0_sumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"C:\MyData\a\numbers.txt"; //File nguồn
            Console.WriteLine("File path: " + sourceFilePath);
            ReadTextFileExample example = new ReadTextFileExample();
            example.ReadTextFile(sourceFilePath);
            Console.ReadLine();
        }
    }
}
