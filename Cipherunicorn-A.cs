using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

    // класс 
    class DataForCrypting
    {
        public string input;        // путь к файлу ввода
        public string output;       // путь к файлу вывода
        public bool   optype;       // тип операции

        // конструктор класса
        public DataForCrypting() 
        {
            input   =   null;
            output  =   null;
            optype  =   false;
        }
    }
}