using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipherunicon_A
{
    // класс данных ждя опрерации шифрования/дешифрования
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
