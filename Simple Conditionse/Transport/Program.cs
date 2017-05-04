using System;
namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string part = Console.ReadLine();

            var taxiDay = (0.70 + (n * 0.79));
            var taxiNight= (0.70 + (n * 0.90));
            var bus = (n * 0.09);
            var train= (n * 0.06);
            
           
            if (n < 20)
            {
                if(part=="day")
                {
                    Console.WriteLine(taxiDay);
                }
                else if (part =="night")
                {
                    Console.WriteLine(taxiNight);
                }
            }
           else if (n >= 20 && n < 100)
            {
                Console.WriteLine(bus);                                 
            }
           else if (n >= 100)
            {
                Console.WriteLine(train);         
            }
            {
                {

                }

            }
        }
    }
}


