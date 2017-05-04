using System;


namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddsume = 0;
            var evensume = 0;

            for (int i = 0; i < n; i++)
            {
                var element = int.Parse(Console.ReadLine());
                if (i % 2==0)
                {
                    evensume = evensume + element;
                }
                else 
                {
                    oddsume = oddsume + element;

                }
            }
             if (oddsume==evensume)
            {
                Console.WriteLine("Yes sum = " + oddsume);
            }
             else
            {
                Console.WriteLine("No diff = " + Math.Abs(oddsume-evensume));
            }
        }
    }
}
