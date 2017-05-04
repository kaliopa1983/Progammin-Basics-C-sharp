using System;


namespace _33.Razstoqnie
{
    class Program
    {
        static void Main(string[] args)
        {
            var V1 = int.Parse(Console.ReadLine());
            var t1 =  int.Parse(Console.ReadLine());
            var t2 = int.Parse(Console.ReadLine());
            var t3 = int.Parse(Console.ReadLine());

            var V2 = V1 + V1 * 0.1;
            var V3 = (V2 - V2 * 0.05);
            var S1 = V1 * t1 / 60.00;
            var S2 = V2 * t2 / 60.00;
            var S3 =  V3* t3 / 60.00;
            var S = S1 + S2 + S3;
            Console.WriteLine("{0:f2}",S);

        }
    }
}
