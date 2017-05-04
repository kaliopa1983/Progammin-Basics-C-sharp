using System;


namespace _13.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int init = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(init + " ");
                    init++;
                    if (init > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();

                if (init > n)
                {
                    break;
                }


            }
        }
    }
}
