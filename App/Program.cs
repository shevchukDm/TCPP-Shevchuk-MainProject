
using System;

namespace App
{
    internal class Program
    {

        private static bool isEven(int inputNumber)
        {
            return inputNumber % 2 == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(isEven(2));
            Console.WriteLine(isEven(3));
            Console.WriteLine(isEven(4));
            Console.WriteLine(isEven(5));
            Console.ReadKey();
        }
    }
}
