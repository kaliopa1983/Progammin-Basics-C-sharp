using System;


namespace _04.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            var monthsCnt = int.Parse(Console.ReadLine());
            var sumElecticity = 0.0;
            var waterBill = 20.00;
            var netBill = 15.00;
            for (int i = 1; i <=monthsCnt; i++)
            {
                var billElectricity = double.Parse(Console.ReadLine());
                sumElecticity = sumElecticity + billElectricity;

            }
            var sumWater = waterBill * monthsCnt;
            var sumNet = netBill * monthsCnt;
            var others = (sumElecticity + sumWater + sumNet) + 0.2 * (sumElecticity + sumWater + sumNet);
            var avareage = (sumWater + sumNet + sumElecticity + others) / monthsCnt;

            Console.WriteLine("Electricity: {0:f2} lv",sumElecticity);
            Console.WriteLine("Water: {0:f2} lv",sumWater);
            Console.WriteLine("Internet: {0:f2} lv",sumNet);
            Console.WriteLine("Other: {0:f2} lv",others);
            Console.WriteLine("Average: {0:f2} lv",avareage);

        }
    }
}
