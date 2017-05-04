using System;


namespace _30.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var xfieldArea = int.Parse(Console.ReadLine());
            var yGreap = double.Parse(Console.ReadLine());
            var zneededWine = int.Parse(Console.ReadLine());
            var workersCnt = int.Parse(Console.ReadLine());

            var allGreap = xfieldArea * yGreap;
            var z1producedWine = (allGreap * 0.4) / 2.5;

            if(z1producedWine>=zneededWine)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",
                    Math.Floor(z1producedWine));
                Console.WriteLine("{0} liters left -> {1} liters per person.",
                    Math.Ceiling(z1producedWine-zneededWine),Math.Ceiling
                    ((z1producedWine-zneededWine)/workersCnt)
                    ); 
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",Math.Floor(zneededWine-z1producedWine));
            }



        }
    }
}
