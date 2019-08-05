using System;

namespace NumberSeparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter the number");
            int inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the another number");
            int number = int.Parse(Console.ReadLine());
            int digit;
            while (inputNumber != 0)
            {
                digit = inputNumber / number;
                inputNumber = inputNumber % number;
                number = number / 10;
                Console.Write($"{digit}   ");
            }
            Console.ReadLine();
        }
    }
}
