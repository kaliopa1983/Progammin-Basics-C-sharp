using System;
namespace _10.Зеленчукова_борса
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var allVegetables  = int.Parse(Console.ReadLine());
            var allFruit  = int.Parse(Console.ReadLine());

            var  bgProfit = n * allVegetables + m * allFruit;
            var euroProfit = bgProfit / 1.94;
            Console.WriteLine(euroProfit);
        }
    }
}
