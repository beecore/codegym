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
            if (sourceFilePath.Trim().Length >0)
            {
                ReadTextFileExample example = new ReadTextFileExample();
                example.WriteFile(sourceFilePath);
            }
            Console.ReadLine();
        
        }
    }
}
