using ClockArrowsAngle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestClockArrowsAngle
{
    [TestClass]
    public class CheckFormatTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int hours = Program.CheckFormat(7);
            Assert.AreEqual(7, hours);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int hours = Program.CheckFormat(14);
            Assert.AreEqual(2, hours);
        }
    }
}
