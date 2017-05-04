using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches__to__Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            var inches = double.Parse(Console.ReadLine());
            var centemeters = inches * 2.54;
            Console.Write("Centemeters =");
            Console.WriteLine(centemeters);
        }
    }
}
