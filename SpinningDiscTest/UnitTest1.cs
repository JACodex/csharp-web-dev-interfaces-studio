using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpinningDiscs;

namespace SpinningDiscTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CD lateralus = new CD("Lateralus is the third studio album by American rock band Tool.", false, 2001);
            Assert.AreEqual(2001, lateralus.YearReleased);
        }
    }
}