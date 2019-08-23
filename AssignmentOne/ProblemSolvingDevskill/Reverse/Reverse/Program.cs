using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < testCases; i++)
            {
                string input = Console.ReadLine();
                char[] inputStr = input.ToCharArray();
                
                for(int j = inputStr.Length-1; j >= 0; j-- )
                {
                    Console.Write(inputStr[j]);
                }
                Console.WriteLine();
            }
            //Console.Read();
        }
    }
}
