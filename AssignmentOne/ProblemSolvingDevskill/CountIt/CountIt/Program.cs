using System;

namespace CountIt
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());

            while(testCases != 0)
            {
                string input = Console.ReadLine().ToLower();
                Console.WriteLine(input);
                testCases--;
            }
            Console.Read();
        }
    }
}
