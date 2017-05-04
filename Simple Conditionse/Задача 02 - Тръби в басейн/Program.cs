using System;
namespace Задача_02___Тръби_в_басейн
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = int.Parse(Console.ReadLine());
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());



            double water = p1 * h + p2 * h;
            var procentp1 = (p1 * h / water) * 100;
            var procentp2 = (p2 * h / water) * 100;
            var allprocent = (water / v) * 100;




            if (water <= v)
            {

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                  Math.Truncate(allprocent), Math.Truncate(procentp1), Math.Truncate(procentp2));
            }
            else
            {

                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, water- v);
            }
        }
    }
}


