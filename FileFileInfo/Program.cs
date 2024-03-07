using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"C:\MyData\a\a.txt"; //File nguồn
            string destinationFilePath = @"C:\MyData\b\b.txt"; //File đích
            bool overWrite = true; //Có ghi đè không
           // File.Copy(sourceFilePath, destinationFilePath, overWrite);
            FileInfo fInfo = new FileInfo(sourceFilePath);
            fInfo.CopyTo(destinationFilePath, overWrite);
            string directoryPath = fInfo.DirectoryName;
            //xoa
            // sourceFilePath = @"C:\MyData\b\b.txt";
            //File.Delete(sourceFilePath);

            //check
            //bool doesFileExist = File.Exists(sourceFilePath);
            //DateTime fileCreatedOn = File.GetCreationTime(sourceFilePath);
            Console.ReadLine();
        }
    }
}
