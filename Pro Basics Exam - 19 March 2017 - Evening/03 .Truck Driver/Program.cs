using System;


namespace _03.Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var kmMonthly = double.Parse(Console.ReadLine());
            var sum = 0.0;

            if (kmMonthly <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    sum = sum + 0.75;
                }
                else if (season == "Summer")
                {
                    sum = sum + 0.90;
                }
                else if (season == "Winter")
                {
                    sum = sum + 1.05;
                }
            }
            else if(kmMonthly<=10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    sum = sum + 0.95;
                }
                else if (season == "Summer")
                {
                    sum = sum + 1.10;
                }
                else if (season == "Winter")
                {
                    sum = sum + 1.25;
                }
            }
            else if(kmMonthly<=20000)
            {
                if (season == "Spring"|| season=="Autumn" || season=="Summer" || season=="Winter")
                {
                    sum = sum + 1.45;
                }

            }
            var salarywithTax = 4 * kmMonthly * sum;
            var salary = salarywithTax - salarywithTax * 0.1;

            Console.WriteLine("{0:f2}",salary);
        }
    }
}
