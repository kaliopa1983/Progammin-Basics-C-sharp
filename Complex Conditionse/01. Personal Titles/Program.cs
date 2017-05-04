using System;


namespace _01.Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();

            if (age<16)
            {
                if (gender=="f")
                {
                    Console.WriteLine("Miss");
                }
                if ( gender =="m")
                {
                    Console.WriteLine("Master");
                }
            } 
            else
            {
                if ( gender=="f")
                {
                    Console.WriteLine("Ms.");
                }
                if ( gender=="m")
                {
                    Console.WriteLine("Mr.");
                }
            }
        }
    }
}
