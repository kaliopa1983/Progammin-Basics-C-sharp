using System;


namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var max = int.MinValue; 
            var sumNumber = 0;
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
               
                if (num > max)
                {
                    max = num;

                }
                 sumNumber=(sumNumber +num) ;
                sum = sumNumber - max;
            }
               
                if (max == sum)
                {
                   Console.WriteLine("Yes");
                    Console.WriteLine("Sum =" + max);
                }
               else 
                {
                   Console.WriteLine("No");
                   Console.WriteLine("Diff=" + Math.Abs((max) - (sum)));
                }
            {

                }
            }
        }
    }







