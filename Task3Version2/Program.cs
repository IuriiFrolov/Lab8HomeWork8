using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3Version2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs/Handmade.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                int line = File.ReadAllLines(path).Length;
                Console.WriteLine("Количство строк = {0}", line);
                string resultstring = "";
                int words = 0;
                for (int i = 0; i < line; i++)
                {
                    #region Считает слова и символы со строки текста
                    //Считает слова и символы со строки чистого текста
                    string startString = sr.ReadLine();
                    string[] stringArray = startString.Split(new[] { ' ', ',', '.', ':', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    
                    foreach (string s in stringArray)
                    {
                        resultstring += s.Substring(0);
                        words++;
                    }
                    #endregion
                }
                Console.WriteLine("Количество слов ={0}", words);
                Console.WriteLine("Количество букв ={0}", resultstring.Length);
            }

            Console.ReadKey();

        }
    }
}
