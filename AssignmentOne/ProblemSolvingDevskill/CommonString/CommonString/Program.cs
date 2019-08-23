using System;

namespace CommonString
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());

            while(testCases != 0)
            {
                string inputLine = Console.ReadLine();
                string[] inputArray = inputLine.Split(' ');
                string firstString = inputArray[0];
                string secondString = inputArray[1];

                if(firstString.Substring == secondString.Substring)
                {
                    Console.WriteLine();
                }
                testCases--;
            }
        }
    }
}
