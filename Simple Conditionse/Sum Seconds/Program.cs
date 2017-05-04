using System;


namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());
            var sec = sec1 + sec2 + sec3;
            int min = 0;
            if (sec < 60)// 0 minutes
            {

            }
            else if (sec < 120)// 1 minute
            {
                min += 1; sec -= 60;

            }
            else if (sec < 180)// 2 minutes
            {
                min += 2; sec -= 120;
            }
            if (sec < 10)
            {
                Console.WriteLine("{0}:0{1}", min, sec);
            }
            else
            {
                Console.WriteLine("{0}:{1}", min, sec);
            }
        }
    }
}   

