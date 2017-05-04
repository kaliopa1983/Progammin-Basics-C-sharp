using System;


namespace _26.Cifri
{
    class Program
    {
        static void Main(string[] args)
        {
            var n= int.Parse(Console.ReadLine());
            var copyn = n;
            var digit3 = copyn % 10;
            copyn = copyn / 10;
            var digit2 = copyn %10;

            copyn = copyn / 10;
            var digit1 = copyn;
            
            

            for (int row = 1; row <=digit1+digit2; row++)
            {
                for (int cow = 1; cow <= digit1+digit3; cow++)
                {
                   
                     if (n%5==0)
                    {
                        n = n - digit1;
                        Console.Write("{0} ",n);
                    }
                     else if(n%3==0)
                    { 
                       n =n - digit2;
                        Console.Write("{0} ",n);
                    }
                    
                    else
                    {
                        n = n + digit3;
                        Console.Write("{0} ",n);
                    }
                }

            }

            Console.WriteLine();



        }
    }
}
