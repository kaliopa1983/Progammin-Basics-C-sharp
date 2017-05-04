using System;


namespace _32.WorkHours
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var dayNeeded = int.Parse(Console.ReadLine());
            var prodaction = int.Parse(Console.ReadLine());

            var workingDays = dayNeeded - dayNeeded * 0.1;
            var workingHours = Math.Floor(workingDays * 12 * prodaction / 100);

            if (workingHours >= hoursNeeded)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(workingHours - hoursNeeded);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine(workingHours - hoursNeeded);
            }


        }
    }
}


