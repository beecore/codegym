﻿using System;
using System.IO;

namespace W8_1_copyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter source file: ");
            string sourcePath = "C:\\MyData\\a\\numbers.txt";
            string destinationPath = "C:\\MyData\\b\\b.txt";

            FileInfo source = new FileInfo(sourcePath);
            FileInfo des = new FileInfo(destinationPath);
            try
            {
                CopyFileUsingStream(source, des);
                Console.WriteLine("Copy Completed");
            }
            catch (IOException e)
            {
                Console.WriteLine("Cannot Copy");
                Console.Error.WriteLine(e.Message);
            }

            Console.ReadLine();

    }
        private static void CopyFileUsingFileInfo(FileInfo source, FileInfo des)
        {
            Console.WriteLine("Start Copy using FileInfo");
            source.CopyTo(des.FullName, true);
        }
        private static void CopyFileUsingStream(FileInfo source, FileInfo des)
        {
            StreamReader reader = null;
            StreamWriter writer = null;
            try
            {
                reader = new StreamReader(source.FullName);
                writer = new StreamWriter(des.FullName);
                Char[] buffer = new Char[1024];
                int length;
                while ((length = reader.Read(buffer,0,1024)) > 0)
                {
                    writer.Write(buffer, 0, length);
                }
            }
            finally
            {
                reader.Close();
                reader.Dispose();
                writer.Close();
                writer.Dispose();
            }
        }
    }
}
