using System;


namespace _12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = decimal.Parse(Console.ReadLine());
            var inCurrency = Console.ReadLine();
            var outCurrency = Console.ReadLine();
            //1 BGN = 1.79549 USD = 1.95583 EUR = 2.53405 GBP
            if (inCurrency == "USD")
            {
                num = num * 1.79549m;
            }
            else if (inCurrency == "EUR")
            {
                num = num * 1.95583m;
            }
            else if (inCurrency == "GBP")
            {
                num = num * 2.53405m;
            }
            if (outCurrency == "USD")
            {
                num = num / 1.79549m;
            }
            else if (outCurrency == "EUR")
            {
                num = num / 1.95583m;
            }
            else if (outCurrency == "GBP")
            {
                num = num / 2.53405m;
            }

            Console.WriteLine(Math.Round(num, 2)+  outCurrency);
        }
    }
}




