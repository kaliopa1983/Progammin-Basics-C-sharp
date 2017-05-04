using System;


namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfPairs = int.Parse(Console.ReadLine());
            int lastPairValue = 0;
            int maxdiff = int.MinValue;

            for (int i = 0; i < numberOfPairs; i++)
            {
                int firstElement = int.Parse(Console.ReadLine());
                int secondElement = int.Parse(Console.ReadLine());
                int pairValue = firstElement + secondElement;
                 
                if(i>0)
                {
                    int diff = Math.Abs(pairValue - lastPairValue);
                    if(diff>maxdiff)
                    {
                        maxdiff = diff;
                    }
                }
              lastPairValue = pairValue;

            }
            if(maxdiff==0)
            {
                Console.WriteLine("Yes, value=" + lastPairValue);
            }
            else if (maxdiff==int.MinValue)
            {
                Console.WriteLine("Yes, value=" + lastPairValue);
            }
            else
            {
                Console.WriteLine("No, maxdiff=" + maxdiff);
            }

                    

                    









                    



                    
        }
    }
}
