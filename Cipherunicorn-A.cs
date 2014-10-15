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

    //TODO: дописать комментарии
    // класс аргументов командной строки
    class Args
    {
        private string _opKey;          // ключ операции
        private string _fileKey;        // ключ файла
        private string _inPath;         // путь к входному файлу
        private string _outPath;        // путь к выходному файлу

        public string opKey
        {
            get
            {
                return _opKey;
            }
        }          //
        public string fileKey
        {
            get
            {
                return _fileKey;
            }
        }        //
        public string inPath
        {
            get
            {
                return _inPath;
            }
        }         //
        public string outPath
        {
            get
            {
                return _outPath;
            }
        }        //

        // конструктор класса
        private Args(string op, string file, string inf, string outf){
            _opKey      =   op;
            _fileKey    =   file;
            _inPath     =   inf;
            _outPath    =   outf;
        }

        private Args instance;
        public Args Instance(string op, string file, string inf, string outf)
        {
            if (instance == null)
            {
                instance = new Args(op,file,inf,outf);
            }
            return instance;
        }
     }
}