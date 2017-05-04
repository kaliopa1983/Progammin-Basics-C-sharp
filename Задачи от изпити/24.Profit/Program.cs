using System;


namespace _24.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            var workingDayM = int.Parse(Console.ReadLine());
            var daylyProfit = double.Parse(Console.ReadLine());
            var fixing = double.Parse(Console.ReadLine());

            var mProfit = workingDayM * daylyProfit;
            var yProfit = (mProfit * 12) + (mProfit * 2.5);
            var tax = (yProfit * 0.25);
            var clearYprofitBG = (yProfit - tax) *fixing;
            var  profit= clearYprofitBG / 365;
            Console.WriteLine("{0:f2}",profit);
        }
    }
}
