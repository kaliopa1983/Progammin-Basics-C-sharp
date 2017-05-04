using System;


namespace _23Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var mounth = Console.ReadLine();
            var nightCnt = int.Parse(Console.ReadLine());

            var priceApartment = 0.0;
            var priceStudio = 0.0;

            if (mounth == "May" || mounth == "October")
            {
                   priceApartment = 65.0;
                    priceStudio = 50.0;

                if (nightCnt > 7)
                {
                     priceApartment = 65.0;
                    priceStudio = priceStudio - (50 * 0.05);
                }
              else   if (nightCnt > 14)
                {
                    priceStudio = priceStudio - (50.0 * 0.3);
                    priceApartment = priceApartment - (65.0 * 0.1);
                }
                
            
            }
            else if (mounth == "June" || mounth == "September")
            {
                priceApartment = 68.79;
                priceStudio = 75.20;
                if (nightCnt >14)
                {
                    priceStudio = priceStudio - (75.20 * 0.2);
                    priceApartment = priceApartment - (68.79 * 0.1);
                }
              

            }
            else if (mounth=="July" || mounth=="August")
            {
                    priceStudio = 76.00;
                    priceApartment = 77.00;

                if (nightCnt > 14)
                {
                    priceApartment = priceApartment - (priceApartment * 0.1);
                    priceStudio = 76.0;
                }
               
               
            }
            var price1 = priceApartment * nightCnt;
            var price2 = priceStudio * nightCnt;

            Console.WriteLine("Apartment: {0:f2} lv.",price1);
            Console.WriteLine("Studio: {0:f2} lv.",price2);
               
        }
    }
}
