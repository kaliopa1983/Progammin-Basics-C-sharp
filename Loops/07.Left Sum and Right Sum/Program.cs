using System;


namespace _07.Left_Sum_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;
            //leftSum
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                leftSum = leftSum + num;
            }
            //rightSum
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                rightSum = rightSum + num;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes,sum=" + leftSum);
            }
            else 
            {
                Console.WriteLine("No,diff=" + Math.Abs(leftSum - rightSum));
            }
        }
    }
}
