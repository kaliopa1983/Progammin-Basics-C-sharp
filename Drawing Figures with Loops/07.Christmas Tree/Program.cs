using System;


namespace _07.Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string(' ',n)+" | ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ',n-1-i));
                Console.Write(new string('*',1+i));
                Console.Write(" | ");
                Console.WriteLine(new string('*',1+i));
            }
        }
    }
}
