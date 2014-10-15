using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


// TODO: Подумать над операциями над множеством файлов
namespace Cipherunicon_A
{
    // класс аргументов командной строки
    class Args  
    {
        private string  _opKey;          // закрытый ключ операции
        private string  _inPath;         // закрытый путь к входному файлу
        private string  _outPath;        // закрытый путь к выходному файлу
        private Args    instance;        // закрытый объект, являющийся синглтоном

        public string opKey     
        {
            get
            {
                if (_opKey != null)     // возвращаем при ненулевом значении
                    return _opKey;
                else
                    throw new Exception("operation key is null");       // выбрасываем ошибку в обратном случае
            }
        }      // ключ операции
        public string inPath    
        {
            get
            {
                if (_inPath != null)    // возвращаем при ненулевом значении
                    return _inPath;
                else
                    throw new Exception("path to input file is null");  // выбрасываем ошибку в обратном случае
            }
        }      // путь к входному файлу
        public string outPath   
        {
            get
            {
                if (_outPath != null)   // возвращаем при ненулевом значении
                    return _outPath;
                else
                    throw new Exception("path to output file is null"); // выбрасываем ошибку в обратном случае
            }
        }      // путь к выходному файлу

        // обработчик аргументов
        public DataForCrypting ToDataForCrypting()  
        {
            DataForCrypting dfc = new DataForCrypting();          // новый объект типа DataForCrypting

            if (opKey == "-e")
                dfc.optype  =   true;                             // обрабатываем ключ операции шифрования
            else if (opKey == "-d")
                dfc.optype  =   false;                            // обрабатываем ключ операции дешифрования
            else
                throw new Exception("wrong key for operation");   // выбрасываем исключение в случае неверных аргументов

            if (File.Exists(inPath))                              // если файл существует, его путь записывается в класс DataForCrypting
                dfc.input = inPath;
            else
                throw new Exception("no file was found");         // в противном случае выбрасывается исключение

            if (File.Exists(outPath))                             // если файл существует, его путь записывается в класс DataForCrypting
                dfc.output = outPath;
            else
            {
                File.Create(outPath);                             // в противном случае он создается
                dfc.output = outPath;                             // и записывается в значение выходного файла в классе DataForCrypting
            }

            return dfc;
        }

        // обработчик ключей
        private void keyCheck(string fileKey, string file)  
        {
            if (fileKey == "-in")
                _inPath     =   file;                       // присваиваем путь к входному файлу
            else if (fileKey == "-out")
                _outPath    =   file;                       // присваиваем путь к выходному файлу
            else
                throw new Exception("wrong key for file");  // выбрасываем исключение в случае неверных аргументов
        }

        // конструктор класса
        private Args(string opKey, string firstFileKey, string firstFile, string secondFileKey, string secondFile)      
        {
            _opKey      =   opKey;                  // присваиваем ключ операции

            keyCheck(firstFileKey, firstFile);      // обрабатываем первый ключ
            keyCheck(secondFileKey, secondFile);    // обрабатываем второй ключ
        }

        // функция, создающая синглтон
        public Args Instance(string opKey, string firstFileKey, string firstFile, string secondFileKey, string outPath) 
        {
            if (instance == null)                                                                 // объект создается только если другого объекта не существует
            {
                instance = new Args(opKey, firstFileKey,  firstFile,  secondFileKey,  outPath);   // создание объекта в случае несуществования другого
            }
            return instance;                                                                      // возвращаем или созданный объект или уже существуещий
        }
    }
}
