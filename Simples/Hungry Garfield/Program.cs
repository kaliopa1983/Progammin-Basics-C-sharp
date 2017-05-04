using System;
namespace Hungry_Garfield
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var rateExchange = decimal.Parse(Console.ReadLine());
            var pizzaPrice = decimal.Parse(Console.ReadLine());
            var lasagnaPrice = decimal.Parse(Console.ReadLine());
            var sandwichPrice = decimal.Parse(Console.ReadLine());
            var pizzaQuantity = uint.Parse(Console.ReadLine());
            var lasagnaQuantity = uint.Parse(Console.ReadLine());
            var sandwichQuantity = uint.Parse(Console.ReadLine());

            decimal spendMoney = ((lasagnaPrice / rateExchange) * lasagnaQuantity) +
                ((pizzaPrice / rateExchange) * pizzaQuantity) +
                ((sandwichPrice / rateExchange) * sandwichQuantity);
            if (money>=spendMoney)
            {
             Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.",
                 money-spendMoney);
            }
            else
            {
             Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.",
                         spendMoney-money);
            }
                      
        }
    }
}
