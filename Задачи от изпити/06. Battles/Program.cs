using System;


namespace _06.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemonsCnt1 = int.Parse(Console.ReadLine());
            var pokemonsCnt2 = int.Parse(Console.ReadLine());
            var maxBattles = int.Parse(Console.ReadLine());
            var fights = 0;

            for (int i = 1; i <= pokemonsCnt1; i++)
            {
                for (int j = 1; j <= pokemonsCnt2; j++)
                {

                    if (fights >= maxBattles)
                    {
                        break;
                    }
                    Console.Write("({0} <-> {1}) ", i, j);
                    fights++;


                }
            }
        }
    }
}


