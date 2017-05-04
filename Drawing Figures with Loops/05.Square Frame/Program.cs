using System;


namespace _05.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //top row
            Console.Write("+");
            for (int i = 0; i <n-2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
            //middle part
            for (int row = 0; row < n-2; row++)
            {
                Console.Write("|");
                for (int i = 0; i < n-2; i++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }
            //last row 
            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }

    }
}
