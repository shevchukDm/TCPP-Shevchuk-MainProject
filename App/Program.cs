
using System;

namespace App
{
    class Program
    {

        static bool isEven(int inputNumber)
        {
            return inputNumber % 2 == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(isEven(2));
            Console.WriteLine(isEven(3));
            Console.ReadKey();
        }
    }
}
