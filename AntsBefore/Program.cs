using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsBefore
{
    public class Program
    {
        static void Main(string[] args)
        {

            string AntStampede = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t";
            CountAnts(AntStampede);
            Console.WriteLine(CountAnts(AntStampede));
            Console.ReadLine();
        }

        public static int CountAnts(string carnage)
        {
            int intactAnt = carnage.Split(new string[] { "ant" }, StringSplitOptions.None).Length - 1;
            int heads = carnage.Split(new char[] { 'a' }).Length - 1;
            int bodies = carnage.Split(new char[] { 'b' }).Length - 1;
            int otherParts = carnage.Length - intactAnt * 3 - heads - bodies;

            int deadAntsFromHeads = Math.Max(heads - intactAnt, 0);

            int deadAntsFromBodyParts = Math.Min(Math.Max(otherParts - deadAntsFromHeads, 0), bodies);

            return deadAntsFromHeads + deadAntsFromBodyParts;


        }

        
    }
}
