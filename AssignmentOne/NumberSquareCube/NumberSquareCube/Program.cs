using System;

namespace NumberSquareCube
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int i;
            Console.WriteLine("number       square      cube");
            for ( i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i}             {i * i}             {i * i * i}");
            }
            Console.Read();
        }
    }
}
