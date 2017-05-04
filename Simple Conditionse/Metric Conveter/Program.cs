
   using System;


namespace Metric_Conveter
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var from = Console.ReadLine().ToLower();
            var to = Console.ReadLine().ToLower();
            double meters = 0;
            double result = 0;

            if (from == "mm")
            {
                meters = number / 1000.0;
            }
            else if (from == "cm")
            {
                meters = number / 100.0;
            }
            else if (from == "mi")
            {
                meters = number * 1609.344;
            }
            else if (from == "in")
            {
                meters = number / 39.3700787;
            }
            else if (from == "km")
            {
                meters = number *1000;
            }
            else if (from == "ft")
            {
                meters = number / 3.2808399;
            }
            else if (from == "yd")
            {
                meters= number / 1.0936133;
            }
            if (to == "mm")
            {
               result= meters  *1000.0;
            }
            else if (to == "cm")
            {
                result= meters *100.0;
            }
            else if (to == "mi")
            {
               result= meters /1609.344;
            }
            else if (to == "in")
            {
               result= meters  * 39.3700787;
            }
            else if (to == "km")
            {
               result= meters * 0.001 ;
            }
            else if (to == "ft")
            {
               result= meters  * 3.2808399;
            }
            else if (to == "yd")
            {
               result= meters  * 1.0936133;
            }
            Console.WriteLine(result + " " + to);
        }
    }
    }


   

   

    

