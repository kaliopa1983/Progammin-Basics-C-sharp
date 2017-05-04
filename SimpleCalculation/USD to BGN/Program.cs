using System;


namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var USD = decimal.Parse(Console.ReadLine());
            var BGN = USD * 1.79549M;
            Console.WriteLine( Math.Round( BGN, 2)+ " BGN  ");

        }
    }
}
