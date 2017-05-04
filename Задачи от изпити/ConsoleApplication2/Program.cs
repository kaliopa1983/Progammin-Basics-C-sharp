using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var holidayCnt = int.Parse(Console.ReadLine());
            var worksdayCnt = 365 - holidayCnt;

            var realPlayTime = holidayCnt * 127 + worksdayCnt * 63;
            var maxPlayTime= 30000;
            

            if (realPlayTime > maxPlayTime)
            {
                var diff = realPlayTime - maxPlayTime;
                var hours = diff / 60;
                var min = diff % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play",hours,min);
            }
            else
            {
                var diff = maxPlayTime - realPlayTime;
                var hours = diff / 60;
                var min = diff % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",hours,min);
            }

        }
    }
}
