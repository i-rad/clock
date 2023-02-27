using ClockArrowsAngle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestClockArrowsAngle
{
    [TestClass]
    public class CalculateAngleTest
    {        
        [TestMethod]
        public void TestMethod1()
        {
            double angle = Program.CalculateAngle(0, 0);
            Assert.AreEqual(0, angle);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double angle = Program.CalculateAngle(4, 0);
            Assert.AreEqual(120, angle);
        }

        [TestMethod]
        public void TestMethod3()
        {
            double angle = Program.CalculateAngle(8, 15);
            Assert.AreEqual(157.5, angle);
        }
    }
}
