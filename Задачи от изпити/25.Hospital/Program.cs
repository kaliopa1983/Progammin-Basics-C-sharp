using System;

namespace _25.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var workingPeriod = int.Parse(Console.ReadLine());
            var doctorsCnt = 7;
            var treatedPatients = 0;
            var untreatedPatiens = 0;
          
                          
            for (int day = 1; day <= workingPeriod; day++)
            {
                var patientCnt = int.Parse(Console.ReadLine());
                if (day%3==0&& untreatedPatiens > treatedPatients)
                {
                  doctorsCnt++;
                }
                if (patientCnt > doctorsCnt)
                {
                    treatedPatients = doctorsCnt+treatedPatients;
                  
                    untreatedPatiens = (patientCnt - doctorsCnt)+untreatedPatiens;
                    
                }
                else
                {
                    treatedPatients = patientCnt+treatedPatients;
                }
                  
                }
            
            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatiens);
        }
    }
}

    

