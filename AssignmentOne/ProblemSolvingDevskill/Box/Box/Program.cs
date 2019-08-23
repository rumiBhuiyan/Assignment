using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            double length = 0;
            double width = 0;
            double height = 0;
            double diagonal = 0;

            for(int i = 0; i < testCase; i++  )
            {
                string inputs = Console.ReadLine();
                string[] sides = inputs.Split(' ');
                length = double.Parse(sides[0]);
                width = double.Parse(sides[1]);
                height = double.Parse(sides[2]);

                //diagonal = Math.Sqrt((length*length)+(width*width)+(height * height));
                diagonal = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2) + Math.Pow(height, 2));

                Console.WriteLine(diagonal.ToString("F"));
            }
            //Console.Read();
        }
    }
}
