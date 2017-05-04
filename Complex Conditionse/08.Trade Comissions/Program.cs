using System;


namespace _08.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var s = double.Parse(Console.ReadLine());
            double comission = -1;

            if (town == "sofia")
            {
                if (s >= 0 && s <= 500) comission = 0.05;
                else if (s > 500 && s <= 1000) comission = 0.07;
                else if (s > 1000 && s <= 10000) comission = 0.08;
                else if (s > 10000) comission = 0.12;
            }
            if (town == "varna")
            {
                if (s >= 0 && s <= 500) comission = 0.045;
                else if (s > 500 && s <= 1000) comission = 0.075;
                else if (s > 1000 && s <= 10000) comission = 0.1;
                else if (s > 10000) comission = 0.13;
            }
            if (town == "plovdiv")
            {
                if (s >= 0 && s <= 500) comission = 0.055;
                else if (s > 500 && s <= 1000) comission = 0.08;
                else if (s > 1000 && s <= 10000) comission = 0.12;
                else if (s > 10000) comission = 0.145;
            }
            if (comission <=0)
            {
                Console.WriteLine("error");
            }
            else
            {
               Console.WriteLine(Math.Round((comission * s), 2));
            }

        }
    }
}

