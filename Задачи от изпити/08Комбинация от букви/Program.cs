using System;

namespace _08Комбинация_от_букви
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstletter = char.Parse(Console.ReadLine());
            char lastletter = char.Parse(Console.ReadLine());
            char forbiddenletter = char.Parse(Console.ReadLine());
            var cnt = 0;
            for (int i = firstletter; i <= lastletter; i++)
            {
                for (int j = firstletter; j <= lastletter; j++)
                {
                    for (int k = firstletter; k < lastletter; k++)
                    {
                        if ((k != forbiddenletter) && (j != forbiddenletter) && (i != forbiddenletter))
                        {
                            Console.Write($"{(char)i}{(char)j}{(char)k} " );
                            cnt++;
                        }
                        
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
