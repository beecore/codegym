using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W8_0_sumNumber
{
    class ReadTextFileExample
    {
        public void ReadTextFile(string filePath)
        {
            try
            {
                FileInfo file = new FileInfo(filePath);
                if (!file.Exists)
                {
                    throw new FileNotFoundException();
                }

                StreamReader reader = new StreamReader(filePath);
                string line = "";
                int sum = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    sum += Int32.Parse(line);
                }
                reader.Close();
                Console.WriteLine("Total: " + sum);
            }
            catch (System.Exception)
            {
                Console.Error.WriteLine("File not found or invalid content");
            }
        }

        public void ReadText(string filePath)
        {
            try
            {
                FileInfo file = new FileInfo(filePath);
                if (!file.Exists)
                {
                    throw new FileNotFoundException();
                }

                StreamReader reader = new StreamReader(filePath);
                string line = "";

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    
                }
                reader.Close();
            }
            catch (System.Exception)
            {
                Console.Error.WriteLine("File not found or invalid content");
            }
        }

        public  void WriteFile(string filePath)
        {
            try
            {
                FileInfo file = new FileInfo(filePath);
                if (!file.Exists)
                {
                    throw new FileNotFoundException();
                }

                StreamWriter writer = new StreamWriter(filePath);
                String line = Console.ReadLine();
                while (line != "")
                {
                    writer.WriteLine(line);
                    line = Console.ReadLine();
                }
                writer.Flush();

             

                writer.Close();

                Console.WriteLine("Write completed");
                Console.WriteLine("============");

                ReadText(filePath); //đọc file đã ghi
            }
            catch (System.Exception)
            {
                Console.Error.WriteLine("File not found or invalid content");
               
            }
        }
    }
}
