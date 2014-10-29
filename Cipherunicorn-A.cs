//csc /t:library /doc:Cipherunicorn-A.xml Cipherunicorn-A.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cipherunicon_A
{
    /// <summary>
    /// Класс программы
    /// </summary>
    class Program
    {
        /// <summary>
        /// Функция main
        /// </summary>
        /// <param name="args">Аргументы командной строки</param>
        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 2)
                {
                    Console.WriteLine("No commands!");
                }
                else if (args[1] == "help")
                {
                    Console.WriteLine("Help");
                }
                else
                {
                    Algoritm alg = new Algoritm();
                    for (int i = 0; i < args.Length; i += 5)
                    {
                        alg.Add(args[i], args[i + 1], args[i + 2], args[i + 3], args[i + 4]);
                    }
                    alg.Process();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}