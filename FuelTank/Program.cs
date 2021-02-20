using System;

namespace FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            string fuel = Console.ReadLine();
            int fuelLevel = int.Parse(Console.ReadLine());
           
            // conditions

            if (fuelLevel >= 25 && fuel == "Diesel" )
            {
                Console.WriteLine($"You have enough {fuel.ToLower()}.");
            }

            else if (fuelLevel < 25 && fuel == "Diesel")
            {
                Console.WriteLine($"Fill your tank with {fuel.ToLower()}!");
            }

            else if (fuelLevel >= 25 && fuel == "Gasoline")
            {
                Console.WriteLine($"You have enough {fuel.ToLower()}.");
            }

            else if (fuelLevel < 25 && fuel == "Gasoline")
            {
                Console.WriteLine($"Fill your tank with {fuel.ToLower()}!");
            }

            else if (fuelLevel >= 25 && fuel == "Gas")
            {
                Console.WriteLine($"You have enough {fuel.ToLower()}.");
            }

            else if (fuelLevel < 25 && fuel == "Gas")
            {
                Console.WriteLine($"Fill your tank with {fuel.ToLower()}!");
            }

            else 
            {
                Console.WriteLine("Invalid fuel!");
            }



        }
    }
}
