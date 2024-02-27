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
            // O(2N)
            string Ants = "..ant..ant.ant...ant.ant..ant.ant....ant..ant.ant.ant...ant..";
            string AntStampede = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t";

            int AliveBefore = Ants.Count(c => c == '.');
            int AliveAfter = AntStampede.Count(c => c == '.');

            int Deadants = AliveBefore - AliveAfter;
            Console.WriteLine(Deadants);
            Console.ReadLine();
            
        }

      public static int  CountAnts(string Ants )
        {
            return 0;
        }

    }
}
