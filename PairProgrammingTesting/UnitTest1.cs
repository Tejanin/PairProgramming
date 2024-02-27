namespace PairProgrammingTesting
{
    [TestClass]
    public class UnitTest
    {

        [TestMethod]
        public void CountAliveAnts()
        {
            string Ants = "..ant..ant.ant...ant.ant..ant.ant....ant..ant.ant.ant...ant..";
           
            Assert.AreEqual(0, PairProgramming.Program.CountAnts(Ants));
           
        }
        [TestMethod]
        public void CountDeadAnts()
        {
            string AntStampede = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t";

            Assert.AreEqual(3, PairProgramming.Program.CountAnts(AntStampede));

        }

        [TestMethod]
        public void TestingInvalidStrings()
        {
            string AntStampede = "...@ant4..85.ant.123.nat7.an6t2.t2..ant...ant..ant..ant.anant..t";

            Assert.AreEqual(0, PairProgramming.Program.CountAnts(AntStampede));
        }

        [TestMethod]
        public void TestingAnotherValidCase()
        {
            string AntStampede = "ant..a...antant...an.t.ant..ant.t.ant.a.n.t..";

            Assert.AreEqual(4, PairProgramming.Program.CountAnts(AntStampede));
        }
    } 
}