using System;


namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
             var n = int.Parse(Console.ReadLine());
            int starsCnt = 2;
            
            //pokriv
            if(n%2==1)
            {
                Console.WriteLine(new string('-',n/2)+ "*"+ new string('-',n/2));
                starsCnt++;
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('-',n/2-1-i));
                Console.Write(new string('*',starsCnt+2*i));
                Console.WriteLine(new string('-', n / 2 - 1 - i));

            }
            // dolna chast
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("|"+ new string('*',n-2)+ "|");
            }
        }
    }
}
