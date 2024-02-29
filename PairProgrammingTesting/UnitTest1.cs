using System.Diagnostics;

namespace PairProgrammingTesting

{
    [TestClass]
    public class UnitTest
    {
      /*  [TestMethod]
        public void CountDeadAnts()
        {

            string AntStampede = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t";
            Assert.AreEqual(72, PairProgramming.Program.CountAnts(AntStampede));

        }*/

        [TestMethod]
        public void TestExecutionTime() {
            Stopwatch stopwatch1 = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();
            string AntStampede = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t";

            stopwatch1.Start();
            PairProgramming.Program.CountAnts(AntStampede);
            stopwatch1.Stop();

            var time1 = stopwatch1.Elapsed.TotalMilliseconds;

            stopwatch2.Start();
            AntsBefore.Program.CountAnts(AntStampede);
            stopwatch2.Stop();

            var time2 = stopwatch2.Elapsed.TotalMilliseconds;

            Assert.IsTrue(time2>time1);
        }
        /*
        [TestMethod]
        public void CountAliveAnts()
        {
            string Ants = "..ant..ant.ant...ant.ant..ant.ant....ant..ant.ant.ant...ant..";
           
            Assert.AreEqual(0, PairProgramming.Program.CountAnts(Ants));
           
        }
        

        [TestMethod]
        public void TestingInvalidStrings()
        {
            string AntStampede = "...@ant4..85.ant.123.nat7.an6t2.t2..ant...ant..ant..ant.anant..t";

            Assert.AreEqual(0, PairProgramming.Program.CountAnts(AntStampede));
        }

        [TestMethod]
        public void TestingValidStrings() {
           

            Assert.AreEqual(0,PairProgramming.Program.CountAnts("ant"));
        }*/

    } 
}