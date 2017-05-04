using System;


namespace _1000_days_after_Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            string DateString = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime result = DateTime.ParseExact(DateString, format, System.Globalization.CultureInfo.InvariantCulture);
            DateTime answer = result.AddDays(999);

            Console.WriteLine(answer.ToString(format));
        }
    }
    }

