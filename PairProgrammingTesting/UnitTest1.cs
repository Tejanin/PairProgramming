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
    } 
}