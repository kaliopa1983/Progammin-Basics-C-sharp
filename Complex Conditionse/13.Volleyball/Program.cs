using System;


namespace _13.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var weekendsSofia = 48 - h;
            double gameinSofia = weekendsSofia * (3.0 / 4);
            double gameinBornTown = h;
            double gameinPday = p * (2.0 / 3);
            double result = 0.00;

            if (year=="leap")
            {
                 result = ((gameinSofia + gameinBornTown + gameinPday) + 0.15*(gameinSofia + gameinBornTown + gameinPday));
            }
           else if( year=="normal")
            {
                result = gameinSofia + gameinBornTown + gameinPday;
            }

                     Console.WriteLine(Math.Truncate(result));
        }
    }
}
