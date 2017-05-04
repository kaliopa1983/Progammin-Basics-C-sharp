using System;
namespace Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var allMoney = double.Parse(Console.ReadLine());
            var aFloor = double.Parse(Console.ReadLine());
            var bFloor = double.Parse(Console.ReadLine());
            var aTiles = double.Parse(Console.ReadLine());
            var haTiles = double.Parse(Console.ReadLine());
            var priceTiles = double.Parse(Console.ReadLine());
            var workPrice = double.Parse(Console.ReadLine());

            var areaFloor = aFloor * bFloor;
            var areaTiles = aTiles * haTiles / 2;
            var neededTiles = (Math.Ceiling(areaFloor / areaTiles)) + 5;
            var spendMoney = neededTiles * priceTiles + workPrice;
            if (allMoney>=spendMoney)
            {
                Console.WriteLine("{0:f2} lv left.",allMoney-spendMoney);
                
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.",spendMoney-allMoney);
            }
        }
    }
}
