using System;
namespace _11.Поправка_на_плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var l = double.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var o = int.Parse(Console.ReadLine());

            int playArea = n * n;
            var tillArea = w * l;
            int pejka = m * o;

            var tillCnt = (playArea-pejka) / tillArea;
            
            
            Console.WriteLine(tillCnt);
            Console.WriteLine(tillCnt*0.2);


        }
    }
}
