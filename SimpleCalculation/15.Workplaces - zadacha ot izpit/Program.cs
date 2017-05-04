using System;


namespace _15.Workplaces___zadacha_ot_izpit
{
    class Program
    {
        static void Main(string[] args)
        {

            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var broiRedove = Math.Round(((h * 100) / 120), 0);
            var bioraNared = Math.Round((((w * 100) - 100) / 70), 0);
            var workPlaces = (broiRedove * bioraNared) - 3;
                Console.WriteLine(workPlaces);
            
        }
    }
}
