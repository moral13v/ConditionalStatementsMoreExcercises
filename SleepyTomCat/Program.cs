using System;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 

            int hollidays = int.Parse(Console.ReadLine());

            // calc

            int workingDays = 365 - hollidays;
            int gameTime = (hollidays * 127) + (workingDays * 63);

            int H = (gameTime - 30000) / 60;
            int M = (gameTime - 30000) % 60;


            // conditions

            if (gameTime > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{H} hours and {M} minutes more for play");
            }

            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Abs(H)} hours and {Math.Abs(M)} minutes less for play");
            }
        }
    }
}
