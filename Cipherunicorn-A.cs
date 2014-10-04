using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.SymmetricAlgorithm;

namespace Cipherunicon_A
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

namespace Console_Out
{
    class Errors
    {
        void WrongArguments()
        {
            Console.WriteLine("Wrong Arguments!");
        }
        void TrownException(Exception e)
        {
            Console.WriteLine(e);
        }
    }
}