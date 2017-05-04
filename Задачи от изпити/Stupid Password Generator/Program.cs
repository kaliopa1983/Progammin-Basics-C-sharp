using System;

namespace Stupid_Password_Generator
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            for (var i = 1; i <= n; i++)
            {
                for (var j = 1; j <= n; j++)
                {
                    for (var k = 'a'; k < 'a' + l; k++)
                    {
                        for (var p = 'a'; p < 'a' + l; p++)
                        {
                            for (var m = Math.Max(i, j) + 1; m <= n; m++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", i, j, k, p, m);
                            }
                            
                        }
                    }
                }
            }
        }
    }
}




                    

        
                    
                
            
            
        
    


