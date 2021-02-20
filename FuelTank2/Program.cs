using System;

namespace FuelTank2
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            string fuel = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            double fuelBill = 0;

            // variables

            double gasolinePrice = 2.22;
            double gasPrice = 0.93;
            double dieselprice = 2.33;

            if (card == "Yes")
            {
                gasolinePrice = gasolinePrice - 0.18;
                gasPrice = gasPrice - 0.08;
                dieselprice = dieselprice - 0.12;
            }



            if (fuel == "Gasoline")
            {
                fuelBill = quantity * gasolinePrice;
            }

            if (fuel == "Gas")
            {
                fuelBill = quantity * gasPrice;
            }

            if (fuel == "Diesel")
            {
                fuelBill = quantity * dieselprice;
            }


            if (quantity >= 20 && quantity <= 25)
            {
                fuelBill = fuelBill * 0.92;
            }

            else if (quantity > 25)
            {
                fuelBill = fuelBill * 0.90;
            }

            Console.WriteLine($"{fuelBill:f2} lv.");
        }
    }
}
