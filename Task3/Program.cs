using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs/Handmade.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
                int line = File.ReadAllLines(path).Length;
                Console.WriteLine("Количство строк = {0}", line);


                //string stringS = sr.ReadLine();
                string[] stringArray = sr.ReadToEnd().Split(new[] { ' ', ',', '.', ':', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                string resultString = "";
                int words = 0;
                foreach (string s in stringArray)
                {
                    resultString += s.Substring(0,1).ToUpper()+s.Substring(1);
                    words++;
                }

                Console.WriteLine("Результирующая строка: {0}", resultString);
                Console.WriteLine("Количество слов = {0}",words);
                Console.ReadKey();

            }
        }
    }
}
