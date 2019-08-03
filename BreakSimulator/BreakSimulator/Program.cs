using System;

namespace BreakSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());

            while (testCases != 0)
            {
                string number = Console.ReadLine();
                testCases--;
                string[] inputs = number.Split(' ');
                double velocity = double.Parse(inputs[0]);
                double time = double.Parse(inputs[1]);
                double deceleration = (-velocity / time);

                Console.WriteLine(deceleration.ToString("0.00"));
            }
            Console.Read();
        }
    }
}
