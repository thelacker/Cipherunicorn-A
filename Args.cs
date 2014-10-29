//csc /t:library /doc:Args.xml Args.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Cipherunicon_A
{
    /// <summary>
    /// Класс аргументов командной строки
    /// </summary>
    class Args  
    {
        /// <summary>
        /// Закрытый ключ операции
        /// </summary>
        private string  _opKey;  
        
        /// <summary>
        /// Закрытый путь к входному файлу
        /// </summary>
        private string  _inPath;

        /// <summary>
        /// Закрытый путь к выходному файлу
        /// </summary>
        private string  _outPath;     
   
        /// <summary>
        /// Закрытый объект, являющийся синглтоном
        /// </summary>
        private Args    instance;        

        /// <summary>
        /// Ключ операции
        /// </summary>
        public string opKey     
        {
            get
            {
                if (_opKey != null)     // возвращаем при ненулевом значении
                    return _opKey;
                else
                    throw new Exception("operation key is null");       // выбрасываем ошибку в обратном случае
            }
        }      

        /// <summary>
        /// Путь к входному файлу
        /// </summary>
        public string inPath    
        {
            get
            {
                if (_inPath != null)    // возвращаем при ненулевом значении
                    return _inPath;
                else
                    throw new Exception("path to input file is null");  // выбрасываем ошибку в обратном случае
            }
        }      

        /// <summary>
        /// Путь к выходному файлу
        /// </summary>
        public string outPath   
        {
            get
            {
                if (_outPath != null)   // возвращаем при ненулевом значении
                    return _outPath;
                else
                    throw new Exception("path to output file is null"); // выбрасываем ошибку в обратном случае
            }
        }

        /// <summary>
        /// Обработчик аргументов
        /// </summary>
        /// <returns>
        /// Возвращает обработанные аргументы ввиде класа DataForCrypting
        /// </returns>
        public DataForCrypting ToDataForCrypting()  
        {
            DataForCrypting dfc = new DataForCrypting();          /// новый объект типа DataForCrypting

            if (opKey == "-e")
                dfc.optype  =   true;                             /// обрабатываем ключ операции шифрования
            else if (opKey == "-d")
                dfc.optype  =   false;                            /// обрабатываем ключ операции дешифрования
            else
                throw new Exception("wrong key for operation");   /// выбрасываем исключение в случае неверных аргументов

            if (File.Exists(inPath))                              /// если файл существует, его путь записывается в класс DataForCrypting
                dfc.input = inPath;
            else
                throw new Exception("no file was found");         /// в противном случае выбрасывается исключение

            if (File.Exists(outPath))                             /// если файл существует, его путь записывается в класс DataForCrypting
                dfc.output = outPath;
            else
            {
                File.Create(outPath);                             /// в противном случае он создается
                dfc.output = outPath;                             /// и записывается в значение выходного файла в классе DataForCrypting
            }

            return dfc;
        }

        /// <summary>
        /// Обработчик ключей
        /// </summary>
        /// <param name="fileKey">Ключ обработки перед файлом</param>
        /// <param name="file">Путь к файлу</param>
        private void keyCheck(string fileKey, string file)  
        {
            if (fileKey == "-in")
                _inPath     =   file;                       /// присваиваем путь к входному файлу
            else if (fileKey == "-out")
                _outPath    =   file;                       /// присваиваем путь к выходному файлу
            else
                throw new Exception("wrong key for file");  /// выбрасываем исключение в случае неверных аргументов
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="opKey">Ключ операции над файлами</param>
        /// <param name="firstFileKey">Ключ файлу</param>
        /// <param name="firstFile">Путь файлу</param>
        /// <param name="secondFileKey">Ключь у другому файлу</param>
        /// <param name="secondFile">Путь к другому файлу</param>
        private Args(string opKey, string firstFileKey, string firstFile, string secondFileKey, string secondFile)      
        {
            _opKey      =   opKey;                  /// присваиваем ключ операции

            keyCheck(firstFileKey, firstFile);      /// обрабатываем первый ключ
            keyCheck(secondFileKey, secondFile);    /// обрабатываем второй ключ
        }

        /// <summary>
        /// Функция, создающая синглтон, содержащий аргументы командной строки
        /// </summary>
        /// <param name="opKey">Ключ операции над файлами</param>
        /// <param name="firstFileKey">Ключ файлу</param>
        /// <param name="firstFile">Путь файлу</param>
        /// <param name="secondFileKey">Ключь у другому файлу</param>
        /// <param name="secondFile">Путь к другому файлу</param>
        /// <returns>
        /// Объект с аргументами командной строки.
        /// Возвращает новый объект при отсутствии другого,
        /// или уже существующий объект
        /// </returns>
        public Args Instance(string opKey, string firstFileKey, string firstFile, string secondFileKey, string secondFile) 
        {
            if (instance == null)                                                                       /// объект создается только если другого объекта не существует
            {
                instance = new Args(opKey, firstFileKey,  firstFile,  secondFileKey,  secondFile);      /// создание объекта в случае несуществования другого
            }
            return instance;                                                                            /// возвращаем или созданный объект или уже существуещий
        }

        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        public Args()
        {
        }
    }
}
