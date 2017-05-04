using System;


namespace _06.Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var controlNumber = int.Parse(Console.ReadLine());
              var sum = 0;
            var score = 0;
            var movesCnt = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {

                
                     
                        sum = i * 2 + j * 3 + sum;
                    score =  sum;
                        movesCnt  ++;
                    
                    
                    if (sum >= controlNumber)
                        break;
                }
                if (sum >= controlNumber)
                    break;

            }
            if (score >= controlNumber)
            {
                Console.WriteLine("{0} moves", movesCnt);
                Console.WriteLine("Score: {0} >= {1}", score, controlNumber);

            }
            else
            {
                Console.WriteLine("{0} moves", movesCnt);


            }

                }
                
               

            }
        }
    


