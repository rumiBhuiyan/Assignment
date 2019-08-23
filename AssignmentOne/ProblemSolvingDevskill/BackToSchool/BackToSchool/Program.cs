using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());

            int firstCoordinateOfCenter = 0;
            int secondCoordinateOfCenter = 0;
            double radius = 0;
            int firstCoordinateOfPoint = 0;
            int secondCoordinateOfPoint = 0;
            double distance = 0;


            for (int i = 1; i <= testCase; i++)
            {
                string userInput = Console.ReadLine();
                string[] inputs = userInput.Split(' ');

                firstCoordinateOfCenter = int.Parse(inputs[0]);
                secondCoordinateOfCenter = int.Parse(inputs[1]);
                radius = double.Parse(inputs[2]);
                firstCoordinateOfPoint = int.Parse(inputs[3]);
                secondCoordinateOfPoint = int.Parse(inputs[4]);

                distance = Math.Sqrt(Math.Pow((firstCoordinateOfCenter - firstCoordinateOfPoint),2) + Math.Pow((secondCoordinateOfCenter - secondCoordinateOfPoint),2));

                if (radius > distance)
                {
                    Console.WriteLine($"Case {i}: Inside");
                }
                else if (radius < distance)
                {
                    Console.WriteLine($"Case {i}: Outside");
                }
                else
                {
                    Console.WriteLine($"Case {i}: OnCircle");
                }
            }
            //Console.ReadLine();
        }
    }
}
