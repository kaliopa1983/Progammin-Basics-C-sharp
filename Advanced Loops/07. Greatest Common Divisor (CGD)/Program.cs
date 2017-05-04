using System;


namespace _07.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            while (b!=0)
            {
                int temp = a;
                a = b;
                b = temp % b;
            }
            Console.WriteLine(a);
        }
    }
}
