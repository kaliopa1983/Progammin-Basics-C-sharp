using System;


namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var mackerelPrice = double.Parse(Console.ReadLine());
            var spratPrice = double.Parse(Console.ReadLine());
            var bonitoKg = double.Parse(Console.ReadLine());
            var scadKg = double.Parse(Console.ReadLine());
            var clamsKg = int.Parse(Console.ReadLine());
            var clamsPrice = 7.50;

            var bonitoPrice = mackerelPrice + (mackerelPrice * 0.60);
            var sumBonito = bonitoKg * bonitoPrice;

            var scadPrice = spratPrice + (spratPrice * 0.80);
            var sumScad = scadKg * scadPrice;

            var sumClams = clamsKg * clamsPrice;

            var bill = sumBonito + sumScad + sumClams;

            Console.WriteLine("{0:f2}", bill); 

        }
    }
}
