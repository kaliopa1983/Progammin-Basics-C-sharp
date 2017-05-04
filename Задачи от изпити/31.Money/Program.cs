using System;


namespace _31.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcounCnt = int.Parse(Console.ReadLine());
            var chinesjoanCnt = double.Parse(Console.ReadLine());
            var comission = double.Parse(Console.ReadLine());

            var euroBit = (bitcounCnt * 1168) / 1.95;
            var euroCh = (chinesjoanCnt * 0.15 * 1.76) / 1.95;
            var allEuro = euroBit + euroCh;
            var euro = allEuro - (allEuro * comission/100);
            Console.WriteLine(euro);
    }
    }
}
