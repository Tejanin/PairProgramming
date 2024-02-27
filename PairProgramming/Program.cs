using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramming
{
     public  class Program
     {
        public static  int antsCounter = 0;
        static void Main(string[] args)
        {

            CountAnts("...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t");
            
        }

      public static int  CountAnts(string Ants )
        {      
               bool head = false;
               bool body = false;
               bool tail = false;


            for (int i = 0; i < Ants.Length; i++)
            {
                // Confirm if the string is valid
                if (Ants[i] != 'a' && Ants[i] != 'n' && Ants[i] != 't' && Ants[i] != '.') break;
                // Skip all the dots
                if (Ants[i] == '.') continue;

                // If we find a living ant, we skip it
                if (Ants.Length > i + 2 && Ants[i] == 'a' && Ants[i + 1] == 'n' && Ants[i + 2] == 't')
                {
                    i += 2;
                    continue;
                }

                //Verify Every Part of the Ants
                switch (Ants[i])
                {
                    case 'a':
                        head = VerifyPart(head);
                        break;
                    case 'n':
                        body = VerifyPart(body);
                        break;
                    case 't':
                        tail = VerifyPart(tail);
                        break;

                }

                //In case that is a whole body of ants, add 1 to the counter
                if (head && body && tail)
                {
                    antsCounter++;

                    head = false;
                    body = false;
                    tail = false;
                }
               

            }

            //In case that a part of the ant is found, add 1 to the counter
            if (head || body || tail)
            {
                antsCounter++;
            }

            return antsCounter;
        }

        private static bool VerifyPart(bool part)
        {
            if (part)
            {
                antsCounter ++;
            }
            else
            {
                part = true;
            }

            return part;
        }

     }
}
