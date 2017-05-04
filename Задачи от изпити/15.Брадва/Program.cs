using System;


namespace _15.Брадва
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-', 3 * n) + "*");
                Console.Write(new string('-',0+i)+ "*");
                Console.WriteLine( new string ('-' , 2*(n-1)-i) ); 

            }
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('*',3*n+1));
                Console.Write(new string('-',n-1));
                Console.WriteLine("*"+new string('-',n-1));

            }
            for (int i = 0; i < n/2-1; i++)
            {   
                
                Console.Write(new string('-',n*3-i)+"*");
                Console.Write(new string('-',n-1+2*i)+"*");
                Console.WriteLine(new string('-',n-1-i));
                

            }
            Console.Write(new string('-',3*n-n/2+1)+new string('*',5*n-((3*n-n/2+1)+((n+1)/2))));
            Console.WriteLine(new string('-',(n+1)/2));
            
        }
    }
}
