using System;


namespace _11.Drow_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var underLine = n - 4;
            if (n%2!=0)
            {
                underLine = n - 3;
            }

            Console.Write("/"+new string ('^',n/2)+"\\");
            Console.Write(new string ('_',underLine));
            Console.WriteLine("/" + new string('^', n / 2) + "\\");
            for (int i = 0; i <n-3; i++)
            {
                Console.Write("|");
                Console.Write(new string (' ',(2*n)-2));
                Console.WriteLine("|");

            }
            Console.Write("|");
            Console.Write(new string(' ',n/2+1)+ new string('_',underLine)+ new string(' ', n / 2+1));
            Console.WriteLine("|");

            Console.Write("\\"+ new string('_',n/2)+"/");
            Console.Write(new string(' ',underLine));
            Console.WriteLine("\\" + new string('_', n / 2) + "/");


        }
    }
}
