using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dul.Tests.Mathematics
{
    [TestClass]
    public class DulMathTest
    {
        [TestMethod]
        public void AbsTest()
        {
          
            var expected = 1234;

          
            var actual = Dul.Math.Abs(-1234);

          
            Assert.AreEqual(expected, actual);
        }
    }
}