using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        
        private static string dirPath = "D:\\test";
        private static string fileName = dirPath + "\\test.txt";
        static void Main(string[] args)
        {
            if(!Directory.Exists(dirPath)) Directory.CreateDirectory(dirPath);
            File.AppendAllText(fileName, "some text\r\n");
        }
    }
}
