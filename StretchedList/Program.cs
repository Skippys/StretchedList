using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StretchedList
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();

            while(true)
            {
                p.RunTest();
            }

        }

       public void RunTest()
        {

            Random random = new Random();

            int checkcounter = 0;
            const int noOfFrames = 30;

            int listSize = random.Next(0,100);
            int counter = 0;
            List<string> list = new List<string>();
            Boolean keepGoing = true;
            int previousEnd = 0;

            int seeIfCorrect = 0;

            for (int i = 0; i < listSize; i++)
            {
                list.Add(checkcounter.ToString());
                checkcounter++;
            }

            while (keepGoing)
            {
                Console.Write("Previous End: " + previousEnd + " : ");
                
                int start = previousEnd;

                int iterateSize;

                if (list.Count -start <= 0)
                {
                    iterateSize = 0;
                }
                else
                {
                    iterateSize = (list.Count - start) / (noOfFrames - counter);
                }

                int end = previousEnd + iterateSize;
                seeIfCorrect++;

                for (int i = start; i < end; i++)
                {
                    if (end >= list.Count)
                    {
                        if (i < list.Count)
                        {
                            for (int z = i; z < list.Count; z++)
                            {
                                Console.Write(list[z] + ",");
                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.Write(list[i] + ",");
                    }
                }

                Console.WriteLine(" one loop : Count" + list.Count);


                if (counter == random.Next(0, noOfFrames) || counter == random.Next(0, noOfFrames))
                {
                    Console.WriteLine("Adding");

                    for (int i = 0; i < random.Next(1,50); i++)
                    {
                        list.Add(checkcounter.ToString());
                        checkcounter++;
                    }
                }

                if (counter == random.Next(0, noOfFrames))
                {

                    Console.WriteLine("Subtracting");
   
                    for (int i = 0; i < random.Next(0,list.Count); i++)
                    {
                        int removeSpot = 0;

                        if (removeSpot < list.Count)
                        {
                            list.RemoveAt(removeSpot);
                            if (removeSpot < end) end -= 1;
                            if (end < 0) end = 0;
                        }
                        
                    }
                }

                previousEnd = end;
                counter++;

                if (counter >= noOfFrames) break;
            }

            Console.WriteLine(seeIfCorrect);
            Console.ReadLine();
        }
    }
}
