using System;


namespace _12.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var projection = Console.ReadLine();
            var r = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var result = 0.00;
            
            
            if (projection == "Premiere")
            {
                result = r * c * 12.00;
            }
            else if (projection == "Normal")
               
            {
                result = r * c * 7.5;
            }
            else if (projection == "Discount")
            {

                result = r * c * 5.00;
            }

            Console.WriteLine("{0:f2}",result);
             
        }
    }
}
