using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {// Задача №1
         // Для удобства проверки Вы можете указать относительный путь path = "Logs1"

            string path = "C:/Users/Фролов Юрий/source/repos/Lab8HomeWork8/Lab8HomeWork8/bin/Debug/Logs1";
            string[] arrayDirectory = Directory.GetDirectories(path);
            foreach (string d in arrayDirectory)
            {
                Console.WriteLine("Директория :{0}", d);
                DirectoryInfo directory = new DirectoryInfo(d);
                if (directory.Exists)
                {
                    string[] arrayFiles = Directory.GetFiles(path);
                    foreach (string f in arrayFiles)
                    {
                        Console.WriteLine("Файл: {0}", f);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
