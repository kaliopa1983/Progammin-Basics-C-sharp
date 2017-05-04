using System;


namespace _04.Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = Console.ReadLine();

           if (p == "banana"  || p == "apple" || p == "kiwi" || p == "cherry" || p == "lemon" || p == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (p == "tomato" || p == "cucumber" || p == "pepper" || p == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}