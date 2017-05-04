using System;
namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var allFood = int.Parse(Console.ReadLine());
            var dogFood = double.Parse(Console.ReadLine());
            var catFood = double.Parse(Console.ReadLine());
            var turtleFood = double.Parse(Console.ReadLine());

            var eatFood = days * (dogFood + catFood + (turtleFood / 1000));

            if (allFood > eatFood)
            {
                var leftFood = allFood - eatFood;
                Console.WriteLine(Math.Floor(leftFood)+ " kilos of food left.");
            }
            else
            {
                var needFood = eatFood - allFood;
                Console.WriteLine(Math.Ceiling(needFood)+ " more kilos of food are needed.");
            }
        }
    }
}
