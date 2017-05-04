using System;


namespace _05___Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            //first row
                Console.WriteLine("+" +new string('~',n-2)+"+" + new string('.',2*n+1));
           // Console.WriteLine("|"+"\\"+new string ('~', n - 2)+"\\"+new string('.',n*2));
            // up side
            for (int i = 1; i <2*n+1; i++)
            {
                Console.Write("|" + new string('.', 0 + i));
                Console.Write("\\" + new string('~', n - 2) + "\\" );
                Console.WriteLine( new string('.',n*2-i));
            }
          //  Console.WriteLine("\\"+new string('.',n*2)+"|"+new string('~', n - 2)+"|");
            // down side
            for (int i = 1; i < 2*n+1; i++)
            {
                Console.Write(new string('.', 0 + i)) ;
                Console.Write("\\" + new string('.', 2 * n-i) + "|");
              Console.WriteLine( new string('~', n - 2)+"|");
                
            }
            
            // last row
            Console.WriteLine(new string ('.',2*n+1)+ "+"+ new string('~', n - 2)+ "+");
            }
        }
    }

