using System;


namespace Squere_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a =");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.Write("Squere =");
            Console.WriteLine(area);
                
        }
    }
}
