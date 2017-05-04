using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            if (str == "square")
            {
                double a = double.Parse(Console.ReadLine());

                double area = a * a;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (str == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = a * b;
                
                Console.WriteLine(Math.Round(area,3));
            }
            else if (str == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double area = Math.PI * r * r;
                Console.WriteLine( Math.Round(area,3));
            }
            else if (str =="triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                double area = (a * ha) / 2;
                Console.WriteLine( Math.Round(area,3));
            }
           
        }
    }
}
