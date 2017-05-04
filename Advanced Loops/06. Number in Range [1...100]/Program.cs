using System;


namespace _06.Number_in_Range__1._._._100_
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            while (n<1 || n>100)
            {
                Console.WriteLine("Invalid num");
                n = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Number is {0}",n);
        }
    }
}
