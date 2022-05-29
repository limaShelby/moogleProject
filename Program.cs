using System;
using System.IO;

namespace Moogle_Project
{
    class Program
    {
        static void Main()
        {
            string[] myFilesDirectory = Directory.GetFiles("./Data");

            MyFile file1 = new MyFile(myFilesDirectory[0]);

            Console.WriteLine(file1.GetTF_IDF("fox"));
        }
    }
}