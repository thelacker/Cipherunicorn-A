using System;
using System.Collections.Generic;
using System.Text;

namespace Cipherunicon_A{
	// Класс реализации алгоритма
	//class Algoritm : System.Security.Cryptography.SymmetricAlgorithm {
    class Algoritm
    {
        public List<DataForCrypting> dataList;  // список из данных для шифрования/дешифрования

        // функция добавление новых аргументов
        public void Add(string opKey, string firstFileKey, string firstFile, string secondFileKey, string outPath)
        {
            Args newArgs            =    new Args();                                                                    // создаем новый класс-обработчик команд
            newArgs                 =    newArgs.Instance(opKey, firstFileKey, firstFile, secondFileKey, outPath);      // вызываем конструктор и присваеваем полям класса значения командной строки
            DataForCrypting newData =    newArgs.ToDataForCrypting();                                                   // создаем новый элемент класса данных для шифрования/девфрования и добавляем туда данные из командной строки
            
            dataList.Add(newData);                                                                                      // записываем этот элемент в список данных
        }

        // функция оработки всех обработанных аргументов
        public void Process()
        {
            foreach (DataForCrypting data in dataList)          // для каждого элемента списка
            {
                if (data.optype == true)                        // либо шифрование
                {
                    Crypt(data.input, data.output);
                }
                if (data.optype == false)                       // либо дешифрование
                {
                    Decrypt(data.input, data.output);
                }                                               // в зависимости от обработаного ключа

            }
        }

        // функция шифрования
        public void Crypt(string input, string output) 
        {
            Console.WriteLine("Encrypted!");
        }

        // функция дешифрования
        public void Decrypt(string input, string output)
        {
            Console.WriteLine("Decrypted!");
        }

        // стандартный конструктор
        public Algoritm()
        {
            dataList = new List<DataForCrypting>();
        }

        //public GenerateIV(){}
        //public GenerateKey(){}
        //public CreateDecryptor(byte[], byte[])(){}
        //public CreateEncryptor(byte[], byte[])(){}
	}
} 