using System;


namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var adults = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            double priceTransport = 0.0;
            if (transport == "airplane")
            {
                priceTransport = (adults * 70) + (students * 50);
            }
          else   if (transport == "bus")
            {
                priceTransport = (adults * 32.50) + (students * 28.50);

            }
            else if (transport == "train")
            {
                priceTransport = (adults * 24.99) + (students * 14.99);
                if ((adults + students) >= 50)
                {
                    priceTransport = priceTransport / 2;

                }
            }
            
            else if (transport == "boat")
            {
                priceTransport = (adults * 42.99) + (students * 39.99);

            }


            var sum = (priceTransport * 2 + nights * 82.99) * 1.1;
               

                Console.WriteLine("{0:f2}", sum);
            }
        }
    }


