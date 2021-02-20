using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            int distance = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            // calc

            double taxiPriceDay = distance * 0.79 + 0.70;
            double taxiPriceNight = distance * 0.90 + 0.70;

            double busPrice = distance * 0.09;

            double trainPrice = distance * 0.06;

            // conditions

            if (distance < 20 && timeOfDay == "day")
            {
                Console.WriteLine("{0:f2}", taxiPriceDay);
            }

            else if (distance < 20 && timeOfDay == "night")
            {
                Console.WriteLine("{0:f2}", taxiPriceNight);
            }

            else if (distance < 100 && busPrice < taxiPriceDay && busPrice < taxiPriceNight)
            {
                Console.WriteLine("{0:f2}", busPrice);
            }

            else if (trainPrice < busPrice && trainPrice < taxiPriceDay && trainPrice < taxiPriceNight)
            {
                Console.WriteLine("{0:f2}", trainPrice);
            }
        }
    }
}
