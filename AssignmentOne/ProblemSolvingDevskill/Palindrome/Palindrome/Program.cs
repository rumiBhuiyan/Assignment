using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());

            //Method1(testCase);
            //Method2(testCase);
            Method3(testCase);

            //Console.ReadLine();
        }

        private static void Method3(int testCase)
        {
            for (int i = 0; i < testCase; i++)
            {
                string input = Console.ReadLine();
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                string reverString = new string(charArray);                
                Console.WriteLine(string.Compare(input.ToLower(), reverString.ToLower()) == 0 ? "Yes" : "No"); 
            }
        }

        private static void Method2(int testCase)
        {
            for (int i = 0; i < testCase; i++)
            {
                string input = Console.ReadLine();
                char[] arrayChar = input.ToCharArray();
                char[] reverse = new char[arrayChar.Length];
                Array.Copy(arrayChar, reverse, arrayChar.Length);
                Array.Reverse(reverse);
                bool isPalindrome = true;

                for(int j = 0; j < arrayChar.Length / 2 - 1; j++)
                {
                    if (Char.ToLower(arrayChar[j]) != Char.ToLower(reverse[j]))
                    {
                        isPalindrome = false;
                        break;
                    }                    
                }
                if(isPalindrome)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }            
        }

        static void Method1(int testCase)
        {
            for (int i = 0; i < testCase; i++)
            {
                string input = Console.ReadLine();
                char[] arrayChar = input.ToCharArray();

                int midPoint = arrayChar.Length / 2;
                bool isPalindrome = true;

                for (int j = 0, k = arrayChar.Length - 1; j < midPoint; j++, k--)
                {
                    if (Char.ToLower(arrayChar[j]) != Char.ToLower(arrayChar[k]))
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
        }
    }
}
