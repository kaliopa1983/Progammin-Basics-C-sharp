using System;


namespace _01.Grape_and_Rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaField = double.Parse(Console.ReadLine());
            double kgGreap = double.Parse(Console.ReadLine());
            double brak = double.Parse(Console.ReadLine());

            var allGreaps = (areaField * kgGreap) - brak;
            var greapskgSell =  allGreaps * 0.55;
            var moneyfromGreaps = greapskgSell * 1.50;
            var greapsForrakia =  allGreaps*0.45;
            var litersRakia = greapsForrakia / 7.5;
            var moneyfromRakia = litersRakia * 9.8;

            Console.WriteLine("{0:f2}",moneyfromRakia);
            Console.WriteLine("{0:f2}",moneyfromGreaps);
        }
    }
}
