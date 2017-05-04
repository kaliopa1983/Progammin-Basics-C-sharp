using System;


namespace _18.Umnata_Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            var age= int.Parse(Console.ReadLine());
            var priceWashm = double.Parse(Console.ReadLine());
            var pricesToys = int.Parse(Console.ReadLine());

            var money = 10;
            var moneytoys = 0;
            var allmoney = 0;


            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    allmoney = allmoney + money;
                    allmoney = allmoney - 1;
                     money = money + 10;

                }
                else
                {
                    moneytoys = moneytoys + pricesToys;
                    
                }
            }
                
               
              double safemoney = (double)( moneytoys + allmoney);
               
                if (safemoney >= priceWashm)
                {
                    Console.WriteLine("Yes! {0:f2}", (safemoney - priceWashm));
                }
                else
                {
                    Console.WriteLine("No! {0:f2}", (priceWashm - safemoney));
                }
            }

        }
    }

