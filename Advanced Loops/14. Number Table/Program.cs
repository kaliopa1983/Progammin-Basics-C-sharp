using System;

namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row= 1; row <= n; row++)
            {
               
                for (int col = 1; col <= n; col++)
                {
                    var num = row + col - 1;
                    if (num > n) num = 2 * n - num;
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
