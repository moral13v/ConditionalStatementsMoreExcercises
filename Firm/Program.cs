using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());

            // calc

            double totalHours = Math.Floor((days * 0.9) * 8) + (days * employees * 2);

            // Conditions

            if (hours > totalHours)
            {
                Console.WriteLine($"Not enough time!{Math.Abs(hours - totalHours)} hours needed.");
            }

            else
            {
                Console.WriteLine($"Yes!{Math.Abs(hours - totalHours)} hours left.");
            }


        }
    }
}
