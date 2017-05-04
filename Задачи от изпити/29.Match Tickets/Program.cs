using System;


namespace _29.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var allmoney = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var peopleinGrupe = int.Parse(Console.ReadLine());
            var ticketPrice = 0.0;
            var leftMoney = 0.0;
            
            if(peopleinGrupe<=4)
            {
               leftMoney = allmoney - allmoney * 0.75;
            }
            else if(peopleinGrupe<=9)
            {
                leftMoney = allmoney - allmoney * 0.6;
            }
            else if(peopleinGrupe<=24)
            {
                leftMoney = allmoney - allmoney * 0.5;
            }
            else if(peopleinGrupe<=49)
            {
                leftMoney = allmoney - allmoney * 0.4;
            }
            else
            {
               leftMoney = allmoney - allmoney * 0.25;
            }
            if(category == "VIP")
            {
                ticketPrice = 499.99 * peopleinGrupe;
            }
            else if(category == "Normal")
            {
                ticketPrice = 249.99 * peopleinGrupe;
            }   
             if(leftMoney> ticketPrice)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.",(leftMoney-ticketPrice));
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.",(ticketPrice-leftMoney));
            }


             


        }
    }
}
