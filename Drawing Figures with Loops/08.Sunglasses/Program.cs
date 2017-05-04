using System;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //first part
            Console.WriteLine(new string('*',2*n)+new string (' ',n)+ new string ('*',2*n));
            //middle part
            char specialSymbol = ' ';
            for (int i = 0; i < n-2; i++)
            {   if(i==((n-1)/2-1))
                {
                    specialSymbol = '|';
                }
                Console.Write("*"+ new string('/',2*n-2)+ "*");
                Console.Write(new string (specialSymbol,n));
                Console.WriteLine("*" + new string('/', 2 * n - 2) + "*");
                specialSymbol = ' ';

            }

            // last part 
            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
            
        }
    }
}
