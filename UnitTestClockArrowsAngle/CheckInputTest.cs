using ClockArrowsAngle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestClockArrowsAngle
{
    [TestClass]
    public class CheckInputTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool inputValid = Program.CheckInput(4, 22);
            Assert.AreEqual(true, inputValid);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool inputValid = Program.CheckInput(25, 33);
            Assert.AreEqual(false, inputValid);
        }

        [TestMethod]
        public void TestMethod3()
        {
            bool inputValid = Program.CheckInput(20, 68);
            Assert.AreEqual(false, inputValid);
        }
    }
}
