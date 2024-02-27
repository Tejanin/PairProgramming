using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramming
{
     public  class Program
     {
        static void Main(string[] args)
        {

            CountAnts("..ant..ant.ant...ant.ant..ant.ant....ant..ant.ant.ant...ant..");
            
        }

      public static int  CountAnts(string Ants )
        {
            //Console.WriteLine("Insert the Ants Line:");
            //string AntsLine = Console.ReadLine();

            //Console.WriteLine("Insert the Ants Line after the Stampede:");
            //string AntsLine = Console.ReadLine();

            // O(2N)
            

            for (int i = 0; i < AntStampede.Length; i++)
            {
                if (AntStampede[i] == '.') continue;



            }


            int AliveBefore = Ants.Count(c => c == '.');
            int AliveAfter = AntStampede.Count(c => c == '.');

            int Deadants = AliveBefore - AliveAfter;
            Console.WriteLine(Deadants);
            Console.ReadLine();
            return 0;
        }

    }
}
