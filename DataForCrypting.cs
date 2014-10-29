//csc /t:library /doc:DataForCrypting.xml DataForCrypting.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipherunicon_A
{
    /// <summary>
    /// Класс данных для операций шифрования/дешифрования
    /// </summary>
    class DataForCrypting
    {
        /// <summary>
        /// Путь к файлу ввода
        /// </summary>
        public string input;

        /// <summary>
        /// Путь к файлу вывода
        /// </summary>
        public string output; 
     
        /// <summary>
        /// Тип операции
        /// </summary>
        public bool   optype;
       

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public DataForCrypting() 
        {
            input   =   null;
            output  =   null;
            optype  =   false;
        }
    }
}
