using System;


namespace _10.Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (n < 2)
            {
                Console.WriteLine("Not prime");
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }


                }
                if (isPrime)
                {
                    Console.WriteLine("Prime");
                }

                else
                {
                    Console.WriteLine("Not prime");
                }
            }
        }
    }
}

