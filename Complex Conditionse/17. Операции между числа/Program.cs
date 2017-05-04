using System;


namespace _17.Операции_между_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            double result = 0.0;
            if (oper == "+")
            {
                result = n1 + n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine(n1 + " + " + n2 + " = " + result + " - even");
                }
                else
                {
                    Console.WriteLine(n1 + " + " + n2 + " = " + result + " - odd");
                }
            }
            else if (oper == "-")
            {
                result = Math.Abs(n1 - n2);
                if (result % 2 == 0)
                {
                    Console.WriteLine(n1 + " - " + n2 + " = " + result + " - even");
                }
                else
                {
                    Console.WriteLine(n1 + " - " + n2 + " = " + result + " - odd");
                }
            }
            else if (oper == "*")
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine(n1 + " * " + n2 + " = " + result + " - even");
                }
                else
                {
                    Console.WriteLine(n1 + " * " + n2 + " = " + result + " - odd");
                }
            }
            else if (oper == "/")
            {
                if (n2==0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                   
                }
                else
                {
                    result = (double)n1 / n2;
                    Console.WriteLine(n1 + " / " + n2 + " = " + Math.Round(result,2));
                }
            }
            else if (oper == "%")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);

                }
                else
                {
                    Console.WriteLine(n1 + " % " + n2 + " = " + n1 % n2);
                }

            }
           
        }

        }
    }

