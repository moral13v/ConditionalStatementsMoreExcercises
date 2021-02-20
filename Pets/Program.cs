using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDay = double.Parse(Console.ReadLine());

            // calc

            double foodNeeded = days * (dogFoodPerDay + catFoodPerDay + (turtleFoodPerDay / 1000));

            // conditions

            if (food >= foodNeeded)
            {
                Console.WriteLine($"{Math.Floor(food - foodNeeded)} kilos of food left.");
            }

            else
            {
                Console.WriteLine($"{Math.Ceiling(foodNeeded - food)} more kilos of food are needed.");
            }

        }
    }
}
