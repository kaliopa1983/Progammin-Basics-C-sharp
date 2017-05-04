using System;


namespace _04.Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 1; row <=n; row++)
            {
                Console.Write("$");
                for (int cow = 1; cow < row; cow++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }

        }
    }
}
