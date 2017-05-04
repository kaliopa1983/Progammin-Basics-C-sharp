using System;


namespace _02.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var town = Console.ReadLine();
            var quantity = decimal.Parse(Console.ReadLine());
            var totalPrice = 0m;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    totalPrice = (quantity * 0.5m);
                }
                else if (product == "water")
                {

                    totalPrice = (quantity * 0.8m);
                }
                else if (product == "beer")
                {
                    totalPrice = (quantity * 1.2m);
                }
                else if (product == "sweets")
                {
                    totalPrice = (quantity * 1.45m);
                }
                else if (product == "peanuts")
                {
                    totalPrice = (quantity * 1.6m);
                }
            }
            if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    totalPrice = (quantity * 0.4m);
                }
                else if (product == "water")
                {

                    totalPrice = (quantity * 0.7m);
                }
                else if (product == "beer")
                {
                    totalPrice = (quantity * 1.15m);
                }
                else if (product == "sweets")
                {
                    totalPrice = (quantity * 1.3m);
                }
                else if (product == "peanuts")
                {
                    totalPrice = (quantity * 1.5m);
                }
            }

            if (town == "Varna")
            {
                if (product == "coffee")
                {
                    totalPrice = (quantity * 0.45m);
                }
                else if (product == "water")
                {

                    totalPrice = (quantity * 0.7m);
                }
                else if (product == "beer")
                {
                    totalPrice = (quantity * 1.1m);
                }
                else if (product == "sweets")
                {
                    totalPrice = (quantity * 1.35m);
                }
                else if (product == "peanuts")
                {
                    totalPrice = (quantity * 1.55m);
                }
            }
            Console.WriteLine(Math.Round(totalPrice,1));

        }
    }
}


   
    

