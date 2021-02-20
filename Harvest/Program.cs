using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 
            // x = sqm ; y = kg. grapes per sqm; z = litres of wine

            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            // calc

            double harvest = x * y;
            double wineHarvest = harvest * 0.4;
            double wineLitres = wineHarvest / 2.5;

            double winePerPerson = (wineLitres - z) / workers;
            double wineExtra = wineLitres - z;
            double wineNeeded = z - wineLitres;

            // conditions

            if (wineLitres < z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineNeeded)} liters wine needed.");

            }

            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineLitres)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineExtra)} liters left -> {Math.Ceiling(winePerPerson)} liters per person.");

            }
        }
    }
}
