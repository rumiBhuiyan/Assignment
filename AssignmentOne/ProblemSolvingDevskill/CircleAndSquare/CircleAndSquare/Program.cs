using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAndSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            double radius = 0;
            double side = 0;
            double diameter = 0;
            double diagonal = 0;

            for(int i = 0; i < testCases; i++)
            {
                string input = Console.ReadLine();
                string[] userInput = input.Split(' ');
                radius = double.Parse(userInput[0]);
                side = double.Parse(userInput[1]);

                diagonal = Math.Sqrt(2 * Math.Pow(side, 2));
                diagonal = Math.Floor(diagonal * 100) / 100;

                diameter = 2 * radius;
                diameter = Math.Floor(diameter * 100) / 100;

                string a = diagonal.ToString("F");
                string b = diameter.ToString("F");

                diagonal = Convert.ToDouble(a);
                diameter = Convert.ToDouble(b);

                //diagonal = Math.Round(diagonal, 2);
                //diameter = Math.Round(diameter, 2);

                //bool result = string.Equals(a, b);
                if (diagonal == diameter)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
            //Console.Read();
        }
    }
}
