using System;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
                var n = int.Parse(Console.ReadLine());

               for (int i = 0; i < n; i++)
            {
                Console.Write((new string('*', 1 + i)) + "\\");
                Console.Write(new string('-', (2 * n + 3) - 4 - 2 * i));
                Console.WriteLine("/" + (new string('*', 1 + i)));
            }

            
            for (int i = 0; i <n/3; i++)
            {
                Console.Write("|"+ new string ('*', ((2*n+3)-(4+n))/2+i));
                Console.Write("\\"+ new string('*',n-2*i));
                Console.WriteLine("/"+ new string('*', ((2 * n + 3) - (4 + n)) / 2 + i)+"|");
            }
            
            for (int i = 0; i < n; i++)
            {
                Console.Write((new string('-', 1 + i)) + "\\");
                Console.Write(new string('*', (2 * n + 3) - 4 - 2 * i));
                Console.WriteLine("/" + (new string('-', 1 + i)));
            }
            Console.WriteLine();





            }
        }
    }

