using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanglaWash
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            int firstInningBd = 0;
            int firstInningPak = 0;
            int secondInningBd = 0;
            int secondInningPak = 0;
            int firstScoresBd = 0;
            int secondScoresBd = 0;
            int firstScoresPak = 0;
            int secondScoresPak = 0;
            int thirdScoresBd = 0;
            int fourthScoresBd = 0;
            int thirdScoresPak = 0;
            int fourthScoresPak = 0;

            for (int i = 0; i < testCase; i++)
            {
                string inputOne = Console.ReadLine();
                string inputTwo = Console.ReadLine();
                string[] firstMatch = inputOne.Split(' ');
                string[] secondMatch = inputTwo.Split(' ');

                firstScoresBd = int.Parse(firstMatch[0]);
                secondScoresBd = int.Parse(firstMatch[1]);
                firstScoresPak = int.Parse(firstMatch[2]);
                secondScoresPak = int.Parse(firstMatch[3]);

                thirdScoresBd = int.Parse(secondMatch[0]);
                fourthScoresBd = int.Parse(secondMatch[1]);
                thirdScoresPak = int.Parse(secondMatch[2]);
                fourthScoresPak = int.Parse(secondMatch[3]);

                firstInningBd = firstScoresBd + secondScoresBd ;
                firstInningPak = firstScoresPak + secondScoresPak;

                secondInningBd = thirdScoresBd + fourthScoresBd;
                secondInningPak = thirdScoresPak + fourthScoresPak;

                if (firstInningBd > firstInningPak && secondInningBd > secondInningPak)
                    Console.WriteLine("Banglawash");
                    
                else                
                    Console.WriteLine("Miss");

            }
            //Console.Read();
        }
    }
}
