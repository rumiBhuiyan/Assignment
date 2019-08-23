using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            
            while(testCases != 0)
            {
                int input = int.Parse(Console.ReadLine());

                bool isPrime = true;

                if(input > 1 && (input % 2) != 0)
                {
                    for (int i = 2; i < input; i++)
                    {
                        if (input % i == 0)
                        {
                            isPrime = false;
                        }
                        if(isPrime == false)
                            break;
                    }
                    if (isPrime == true)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                        Console.WriteLine("No");

                }
                else if(input == 2)
                {
                    Console.WriteLine("Yes");
                }
                else
                    Console.WriteLine("No");
                testCases--;
            }
            Console.Read();
        }
    }
}
