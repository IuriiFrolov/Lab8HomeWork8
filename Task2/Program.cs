using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Log2.txt"; //Создаю файл
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            using (StreamWriter sw = new StreamWriter(path)) //Записываю 10 случайных чисел
            {
                int[] array = new int[10];
                Random random = new Random();

                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(0, 10);
                    sw.WriteLine("{0}", array[i]);
                }
            }
            using (StreamReader sr = new StreamReader(path)) // Читаю файл
            {
                int[] array = new int[10];
                int sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    array[i] = Convert.ToInt32(sr.ReadLine());
                    sum += array[i];
                }
                Console.WriteLine(sr.ReadToEnd());
                Console.WriteLine("Сумма чисел в файле = {0}",sum);
            }
            Console.ReadKey();
        }
    }
}
