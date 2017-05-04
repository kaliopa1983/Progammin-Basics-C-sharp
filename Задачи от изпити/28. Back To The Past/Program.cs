using System;


namespace _28.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            var heritAgeMoney = double.Parse(Console.ReadLine());
            var yearStopedLive = int.Parse(Console.ReadLine());

           

            var age = 18;
            for (int i = 1800; i <= yearStopedLive; i++)
            {

                if (i % 2 == 0)
                {
                    heritAgeMoney = (heritAgeMoney - 12000);

                }
                else
                {
                    heritAgeMoney = heritAgeMoney - (12000 + (age * 50));
                }
                age++;
            }

                if (heritAgeMoney < 0 )
                {
                     Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(heritAgeMoney));
                }
                else 
                {
                    Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.",
                 heritAgeMoney);
                }
               
                   
                }


            }
        }
    





