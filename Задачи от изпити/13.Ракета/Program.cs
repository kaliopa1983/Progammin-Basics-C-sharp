using System;


namespace _13.Ракета
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', ((3 * n - 2) / 2) - i) + "/" +
                    new string(' ', 0 + 2 * i) + "\\");
                Console.WriteLine(new string('.', ((3 * n - 2) / 2) - i));
            }

                Console.WriteLine(new string('.', n / 2) + new string('*',2*n)+ new string('.', n / 2));

            for (int i = 0; i < 2*n; i++)
            {
                Console.WriteLine(new string('.',n/2)+"|"+new string('\\',2*n-2)+'|'+new string('.',n/2));

            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine(new string ('.',n/2-i)+"/"+new string('*',2*n-2+2*i)+"\\"+ new string('.', n / 2 - i));
            }
            }
        }
    }

