using System;

namespace CircleSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());

            while(testCases != 0)
            {
                string input = Console.ReadLine();

                string[] inputArray = input.Split(' ');
                double radius = double.Parse(inputArray[0]);
                double side = double.Parse(inputArray[1]);

                //if(radius > 0.00 && side <=100.00)
                //{
                /*decimal diameter = decimal.Round(radius * 2.00m, 2, MidpointRounding.AwayFromZero);
                //diameter = double.Parse(string.Format("{0:0.00}", diameter));
                diameter = Math.Truncate(100 * diameter) / 100;
                decimal diagonal = (decimal)Math.Sqrt(2) * side;
                //diagonal = double.Parse(string.Format("{0:0.00}", diagonal));
                diagonal = Math.Truncate(100 * diagonal) / 100;*/

                double diameter = (double)radius * Math.Sqrt(2);
                diameter = double.Parse(string.Format("{0:0.00}",diameter));


                //double diameter = Math.Round(Math.Sqrt(2) * radius, 2);

                if (diameter == side)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
                //}
                
                testCases--;
            }
            //Console.Read();
        }
    }
}
