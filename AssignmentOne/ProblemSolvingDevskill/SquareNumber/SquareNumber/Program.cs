using System;

namespace SquareNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());

            for (int i = 1; i <= testCases; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                //Console.WriteLine(inputNumber);
                double givenNumber = Convert.ToDouble(inputNumber);
                //Console.WriteLine(givenNumber);
                double squareRoot = Math.Sqrt(givenNumber);
                //Console.WriteLine(squareRoot);
                double squareNumber = squareRoot * squareRoot;
                //Console.WriteLine(squareNumber);
   
                    if(squareNumber == givenNumber)
                    {
                        Console.WriteLine($"Case {i}: YES");
                    }
                    else
                    {
                        Console.WriteLine($"Case {i}: NO");
                    }
            }
            //Console.Read();
        }
    }
}
