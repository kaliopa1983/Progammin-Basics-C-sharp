using System;


namespace _11.Odd__Even_Position
    {
        class Program
        {
            static void Main(string[] args)
            {
                var n = int.Parse(Console.ReadLine());
                var oddSum = 0.0;
                var oddMin = double.MaxValue;
                var oddMax = double.MinValue;
                var evenSum = 0.0;
                var evenMin = double.MaxValue;
                var evenMax = double.MinValue;

                for (int i = 1; i <= n; i++)
                {
                    var number = double.Parse(Console.ReadLine());
                    if (i % 2 == 0)
                    //chetna poziciq
                    {
                        evenSum = number + evenSum;
                        if (number < evenMin)
                        {
                            evenMin = number;
                        }
                         if (number > evenMax)
                        {
                            evenMax = number;
                        }
                    }
                    else //nechetna pozicia
                    {
                        oddSum = number + oddSum;
                        if (number < oddMin)
                        {
                            oddMin = number;
                        }
                         if (number > oddMax)
                        {
                            oddMax = number;
                        }
                    }
                }

                if (n == 1)
                {
                    Console.WriteLine("OddSum=" + oddSum);
                    Console.WriteLine("OddMin=" + oddMin);
                    Console.WriteLine("OddMax=" + oddMin);
                    Console.WriteLine("EvenSum=" + evenSum);
                    Console.WriteLine("EvenMin=No");
                    Console.WriteLine("EvenMax=No");
                }
                else if (n == 0)
                {
                    Console.WriteLine("OddSum=" + oddSum);
                    Console.WriteLine("OddMin=No");
                    Console.WriteLine("OddMax=No");
                    Console.WriteLine("EvenSum=" + evenSum);
                    Console.WriteLine("EvenMin=No");
                    Console.WriteLine("EvenMax=No");
                }
                else if (n == 2)
                {
                    Console.WriteLine("OddSum=" + oddSum);
                    Console.WriteLine("OddMin=" + oddMin);
                    Console.WriteLine("OddMax=" + oddMin);
                    Console.WriteLine("EvenSum=" + evenSum);
                    Console.WriteLine("EvenMin=" + evenMin);
                    Console.WriteLine("EvenMax=" + evenMin);
                }
                else if (n == 3)
                {
                    Console.WriteLine("OddSum=" + oddSum);
                    Console.WriteLine("OddMin=" + oddMin);
                    Console.WriteLine("OddMax=" + oddMax);
                    Console.WriteLine("EvenSum=" + evenSum);
                    Console.WriteLine("EvenMin=" + evenMin);
                    Console.WriteLine("EvenMax=" + evenMin);
                }
                else
                {
                    Console.WriteLine("OddSum=" + oddSum);
                    Console.WriteLine("OddMin=" + oddMin);
                    Console.WriteLine("OddMax=" + oddMax);
                    Console.WriteLine("EvenSum=" + evenSum);
                    Console.WriteLine("EvenMin=" + evenMin);
                    Console.WriteLine("EvenMax=" + evenMax);
                }
            }
        }
    }

