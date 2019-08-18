using System;

namespace NumberSeparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter the number");
            string input = Console.ReadLine();
            int inputNumber = int.Parse(input);
            double divider_const = 10.0;
            int number_of_spaces = 5;
            //Console.WriteLine("Please enter the another number");
            int number = Convert.ToInt32(Math.Pow(divider_const, Convert.ToDouble(input.Length - 1)));
            int digit;
            while (inputNumber != 0)
            {
                digit = inputNumber / number;
                inputNumber = inputNumber % number;
                number = number / 10;
                //Console.Write($"{digit}   ");
                Console.Write(String.Format("{0," + (-number_of_spaces) + "}", digit));
                
            }
            Console.ReadLine();
        }
    }
}
