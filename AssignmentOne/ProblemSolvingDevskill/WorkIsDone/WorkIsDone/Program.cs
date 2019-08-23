using System;

namespace WorkIsDone
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int totalHours = 0;
            int numberOfMember = 0;
            int memberHours = 0;
            string message = string.Empty;

            while ((input = Console.ReadLine()) != null && input != "")
            {
                string[] input_array = input.Split(' ');
                totalHours = Convert.ToInt16(input_array[0]);
                numberOfMember = Convert.ToInt16(input_array[1]);
                memberHours = 0;
                for(int i = 0; i < numberOfMember; i++)
                {
                    int hours = int.Parse(Console.ReadLine());
                    memberHours += hours;
                }

                double days = (double) totalHours / memberHours;
                days = Math.Ceiling(days);

                message = days == 1 ? "Project will finish within 1 day." : $"Project will finish within {days} days.";
                Console.WriteLine(message);
            }
        }
    }
}
