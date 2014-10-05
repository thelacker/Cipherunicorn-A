using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.SymmetricAlgorithm;

namespace Cipherunicon_A
{
	// класс программы
    class Program 
    {
    	// функция main
        static void Main(string[] args) 
        {
        }
    }
}

namespace Console_Out
{
	// класс возможных ошибок
    class Errors
    {
    	// ошибка при вводе аргументов
        void WrongArguments()
        {
            Console.WriteLine("Wrong Arguments!");
        }

        // ошибка исключением
        void TrownException(Exception e)
        {
            Console.WriteLine(e);
        }
    }
}