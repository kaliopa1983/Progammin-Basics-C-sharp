using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


            
namespace _03.Truck_Driver
    {
        class Program
        {
            static void Main(string[] args)
            {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("+" + new string('~', n - 2) + "+" + new string('.', (2 * n )));
            Console.WriteLine("|" + "\\" + new string('~', n - 2) + "\\" + new string('.', (2 * n)-1));
            for (int i = 1; i <= (2 * n)-1; i++)
            {
                Console.WriteLine("|" + new string('.', +i) + "\\" + new string('~', n - 2) + "\\" + new string('.', (2 * n - 2-i)));
            }
            Console.WriteLine("\\" + new string('.', n * 2) + "|" + new string('~', n - 2) + "|");
            for (int i = 1; i <= n * 2; i++)
            {

            }
        }
        }
    }



