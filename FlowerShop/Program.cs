using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 

            int magnolia = int.Parse(Console.ReadLine());
            int hyacinth = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double gift = double.Parse(Console.ReadLine());

            // variables

            double magnoliaPrice = 3.25;
            double hyacinthPrice = 4;
            double rosePrice = 3.50;
            double cactusPrice = 8;

            // calc

            double income = (magnolia * magnoliaPrice + hyacinth * hyacinthPrice + rose * rosePrice + cactus * cactusPrice) * 0.95;

            // conditions

            if (income >= gift)
            {
                Console.WriteLine($"She is left with {Math.Floor(income - gift)} leva.");
            }

            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(gift - income)} leva.");
            }


        }
    }
}
