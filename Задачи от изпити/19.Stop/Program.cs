using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('.',n+1)+new string('_',2*n+1)+ new string('.', n + 1));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.',n-i)+"//"+new string('_',2*n-1+2*i)+"\\\\"+ new string('.', n - i));
            }
            Console.WriteLine();
        }
    }
}
