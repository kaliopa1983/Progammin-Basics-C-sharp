using System;


namespace Time__15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int min1 = int.Parse(Console.ReadLine());
            int min = (min1 % 60) + 15;
            string zero = "";

            if (min > 59)
            {
                hours += 1;
                min -= 60;
            }
            if (min < 10)
            {
                zero = "0";
            }
            Console.WriteLine("{0}:{1}{2}", hours % 24, zero, min % 60);
        }

    }
}       

            
              
           
            
    
                
        
    

