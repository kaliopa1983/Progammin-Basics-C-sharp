using System;


namespace _16.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1Cnt = 0;
            var p2Cnt = 0;
            var p3Cnt = 0;
            var p4Cnt = 0;
            var p5Cnt = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1Cnt++;
                }
                else if (num < 400)
                {
                    p2Cnt++;
                }
                else if (num < 600)
                {
                    p3Cnt++;
                }
                else if (num < 800)
                {
                    p4Cnt++;
                }
                else
                {
                    p5Cnt++;
                }
            }
                var procentP1 = (p1Cnt  * 100.0/ n);
                var procentP2 = (p2Cnt  * 100.0/ n);
                var procentP3 = (p3Cnt  * 100.0/ n);
                var procentP4 = (p4Cnt  * 100.0/ n);
                var procentP5 = (p5Cnt  * 100.0/ n);

                Console.WriteLine("{0:f2}%",procentP1);
                Console.WriteLine("{0:f2}%",procentP2);
                Console.WriteLine("{0:f2}%",procentP3);
                Console.WriteLine("{0:f2}%",procentP4);
                Console.WriteLine("{0:f2}%",procentP5);

            }
        }
    }

