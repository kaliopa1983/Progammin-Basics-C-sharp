using System;


namespace _09.Vowels_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var sume = 0;
            for (int i = 0; i <= s.Length-1; i++)
            {
                if (s[i] == 'a')
                {
                    sume = sume + 1;
                }
                else if (s[i] == 'e')
                {
                    sume = sume + 2;
                }
                else if (s[i] == 'i')
                {
                    sume = sume + 3;
                }
                else if (s[i] == 'o') 
                {
                    sume = sume + 4;
                 }

                else if (s[i] == 'u')
                {
                    sume = sume + 5;
                }

            }
            Console.WriteLine(sume);
        }
    }
}
