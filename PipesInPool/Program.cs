using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            // calc

            double waterV = (P1 + P2) * H;

            // conditions

            if (waterV > V)
            {
                Console.WriteLine($"For {H:f2} hours the pool overflows with {(waterV - V):f2} liters.");

            }

            else
            {
                Console.WriteLine($"The pool is {(waterV / V * 100):f2}% full. Pipe 1: {((P1 * H) / waterV * 100):f2}%. Pipe 2: {((P2 * H) / waterV * 100):f2}%.");

            }
        }
    }
}
