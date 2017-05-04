using System;


namespace _04.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {

                var broqGrupi = int.Parse(Console.ReadLine());
                var allPeople = 0;
                var carPeople = 0;
                var minibusPeople = 0;
                var smallbusPeople = 0;
                var bigbusPeople = 0;
                var trainPeople = 0;
            for (int i = 0; i < broqGrupi; i++)
            {
                var horavGrupa = int.Parse(Console.ReadLine());
                allPeople = allPeople + horavGrupa;


                if (horavGrupa <= 5)
                {
                    carPeople = carPeople + horavGrupa;
                }
                else if (horavGrupa <= 12)
                {
                    minibusPeople = minibusPeople + horavGrupa;
                }
                else if (horavGrupa <= 25)
                {
                    smallbusPeople = smallbusPeople + horavGrupa;
                }
                else if ( horavGrupa <= 40)
                {
                    bigbusPeople = bigbusPeople + horavGrupa;
                }
                else
                {
                    trainPeople = trainPeople + horavGrupa;
                }
            }
                double carProc=(double)carPeople / allPeople * 100;
                double minibusProc=(double)minibusPeople / allPeople * 100;
                double smallbusProc=(double)smallbusPeople / allPeople * 100;
                double bigbusProc=(double)bigbusPeople / allPeople * 100;
                double trainProc=(double)trainPeople / allPeople * 100;

                Console.WriteLine("{0:f2}%",carProc );
                Console.WriteLine("{0:f2}%",minibusProc);
                Console.WriteLine("{0:f2}%",smallbusProc);
                Console.WriteLine("{0:f2}%",bigbusProc);
                Console.WriteLine("{0:f2}%",trainProc);

            }

        }
    }



