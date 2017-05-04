using System;

namespace _16.Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            var allMoney = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            double spendMoney;
           
            if (allMoney <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                
                if (season == "summer")
                {
                    spendMoney =allMoney * 0.3;
                    Console.WriteLine("Camp - {0:f2}", spendMoney);   
                }
                else 
                {
                    spendMoney =allMoney * 0.7;
                    Console.WriteLine("Hotel - {0:f2}", spendMoney); 

                }
            }
            else if (allMoney <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans "); 
                if (season == "summer")
                {
                    spendMoney =allMoney * 0.4;
                    Console.WriteLine("Camp - {0:f2}", spendMoney);
                }
                else 
                {
                    spendMoney =allMoney * 0.8;
                    Console.WriteLine("Hotel - {0:f2}", spendMoney);
                }
            }
            else
            {
                    Console.WriteLine( "Somewhere in Europe");
                    spendMoney =allMoney * 0.9;
                    Console.WriteLine("Hotel - {0:f2}", spendMoney);
             }
            }
            
            
            }
        }
    

