using System;

namespace _02.Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            var allMoney = double.Parse(Console.ReadLine());
            var areaHouse = double.Parse(Console.ReadLine());
            var windowsCnt = int.Parse(Console.ReadLine());
            var areaStyrofoamPocket = double.Parse(Console.ReadLine());
            var pricePoketStyrofoam = double.Parse(Console.ReadLine());

            var neededStyrofoam1 = areaHouse - (windowsCnt * 2.4);
            var needenStyrofoam2 = neededStyrofoam1 + neededStyrofoam1 * 0.1;
            var finalyneededStyrofoam = Math.Ceiling(needenStyrofoam2 / areaStyrofoamPocket);
                 
                
               
            var styrofoamMoney = finalyneededStyrofoam * pricePoketStyrofoam;

            if(allMoney>styrofoamMoney)
            {
                Console.WriteLine("Spent: {0:f2}",styrofoamMoney);
                Console.WriteLine("Left: {0:f2}",(allMoney-styrofoamMoney));
              
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}",(styrofoamMoney-allMoney));
                
            }

        }
    }
}
