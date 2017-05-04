using System;


namespace Celsius_to_Farenheit1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var gradCelsius = double.Parse(Console.ReadLine());
            var gradFarenheit = (gradCelsius * 1.8) + 32;
            Console.WriteLine( gradFarenheit);


        }
    }
}
