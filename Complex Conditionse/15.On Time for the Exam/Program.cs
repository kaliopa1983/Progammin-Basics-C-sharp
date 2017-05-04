using System;


namespace _15.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var hourExam = int.Parse(Console.ReadLine());
            var minExam = int.Parse(Console.ReadLine());
            var hourArrive = int.Parse(Console.ReadLine());
            var minArrive = int.Parse(Console.ReadLine());
            var timeExam = hourExam * 60 + minExam;
            var timeArrive = hourArrive * 60 + minArrive;

            if (timeArrive == timeExam)
            {
                Console.WriteLine("On time");
            }
            else if (timeExam - timeArrive <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", (timeExam - timeArrive) % 60);
            }

            else if (timeExam - timeArrive > 30 && timeExam - timeArrive < 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0} minutes before the start", (timeExam - timeArrive) % 60);
            }
            else if (timeExam - timeArrive > 30&& timeExam - timeArrive >=60)
            {
                Console.WriteLine("Early");
                if ((timeExam - timeArrive) % 60 >= 10)
                {
                    Console.WriteLine("{0}:{1} hours before the start",
                        (timeExam - timeArrive) / 60, (timeExam - timeArrive) % 60);
                }
                else
                {
                    Console.WriteLine("{0}:0{1} hours before the start",
                   (timeExam - timeArrive) / 60, (timeExam - timeArrive) % 60);
                }
            }
            
            else if( timeArrive>timeExam)
            {
                Console.WriteLine("Late");
                if(timeArrive - timeExam/ 60 < 60)
                {
                    Console.WriteLine("{0} minutes after the start",(timeArrive-timeExam )%60);
                }
                else
                {
                    Console.WriteLine("{0}:{1} hours after the start", (timeArrive-timeExam)/60,
                        (timeArrive-timeExam)%60);
                }
            }
            Console.WriteLine();

            }
        }
        
    }

