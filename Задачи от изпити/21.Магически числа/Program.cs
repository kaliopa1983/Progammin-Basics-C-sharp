using System;

namespace _21.Магически_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
           
            
               

                for (int i1 = 0; i1 < 9; i1++)
                {
                    for (int j = 0; j <9; j++)
                    {
                        for (int k = 0; k <9; k++)
                        {
                            for (int l = 0; l <9; l++)
                            {
                                for (int m = 0; m <9; m++)
                                {
                                    for (int p = 0; p <9; p++)
                                    {
                                        if (i1 * j * k * l * m * p == n)
                                        {
                                            Console.Write("{0}{1}{2}{3}{4}{5} ", i1, j, k, l, m, p);



                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }


