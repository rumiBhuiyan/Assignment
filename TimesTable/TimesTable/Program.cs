using System;

namespace TimesTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the number of your disered timestable");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }
            Console.ReadLine();
        }
    }
}
