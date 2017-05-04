using System;

namespace _10.Генериране_на_правоъгълници
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());

            int rows = (int)h * 100 / 120;
            int tables = (int)((w * 100) - 100) / 70;
            var workPlaces = (rows * tables) - 3;
            Console.WriteLine((workPlaces));

        }

            
        }
    }

