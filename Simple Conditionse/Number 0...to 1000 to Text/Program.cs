using System;


namespace Number_0._._.to_1000_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberSingles = number % 10;
            int numberTens = number / 10 % 10;

            string singleDigit = " ";
            string tenseDigit = " ";
            if (number == 0)
            {
                Console.WriteLine("zero");
                return;
            }
            if (number == 10)
            {
                Console.WriteLine("ten");
                return;
            }
            if (number == 11)
            {
                Console.WriteLine("eleven");
                return;
            }
            if (number == 12)
            {
                Console.WriteLine("twelve");
                return;
            }
            if (number == 13)
            {
                Console.WriteLine("thirteen");
                return;
            }
            if (number == 14)
            {
                Console.WriteLine("fourteen");
                return;
            }
            if (number == 15)
            {
                Console.WriteLine("fifteen");
                return;
            }
            if (number == 16)
            {
                Console.WriteLine("sixteen");
                return;
            }
            if (number == 17)
            {
                Console.WriteLine("seventeen");
                return;
            }
            if (number == 18)
            {
                Console.WriteLine("eighteen");
                return;
            }
            if (number == 19)
            {
                Console.WriteLine("nineteen");
                return;
            }
            if (number == 100)
            {
                Console.WriteLine("one hundred");
                return;
            }
            if( (number < 1)|| (number>100))
            {
                Console.WriteLine("invalid number");
                return;
            }
            else if (numberTens == 2)
            {
                tenseDigit ="twenty";
            }
            else if (numberTens == 3)
            {
                tenseDigit ="thirty";
            }
            else if (numberTens == 4)
            {
                tenseDigit ="fourty";
            }
            else if (numberTens == 5)
            {
                tenseDigit ="fifty";
            }
            else if (numberTens == 6)
            {
                tenseDigit ="sixty";
            }
            else if (numberTens == 7)
            {
                tenseDigit ="seventy";
            }
            else if (numberTens == 8)
            {
                tenseDigit ="eighty";
            }
            else if (numberTens == 9)
            {
                tenseDigit ="ninety";
            }

            if (numberSingles == 1)
            {
                singleDigit = "one";
            }
            else if (numberSingles == 2)
            {
                singleDigit = "two";
            }
            else if (numberSingles == 3)
            {
                singleDigit = "three";
            }
            else if (numberSingles == 4)
            {
                singleDigit = "four";
            }
            else if (numberSingles == 5)
            {
                singleDigit = "five";
            }
            else if (numberSingles == 6)
            {
                singleDigit = "six";
            }
            else if (numberSingles == 7)
            {
                singleDigit = "seven";
            }
            else if (numberSingles == 8)
            {
                singleDigit = "eight";
            }
            else if (numberSingles == 9)
            {
                singleDigit = "nine";
            }
            if (numberTens != 0)
            {
                Console.WriteLine(tenseDigit + " " + singleDigit);
            }
            else
            {
                Console.WriteLine(singleDigit);
            }
          
        }

    }
  }


    

