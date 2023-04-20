using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dul.Tests
{
    [TestClass]
    public class CreatorTest
    {
        [TestMethod]
        public void GetNameTest()
        {
           
            const string expected = "RedPlus";

           
            var actual = Creator.GetName();

           
            Assert.AreEqual(expected, actual);
        }
    }
}

namespace Dul
{
    class CreatorOther
    {
        public static string GetName() => "RedPlus";
    }
    namespace Tests
    {
        [TestClass]
        public class CreatorTestOther
        {
            [TestMethod]
            public void GetNameTest()
            {
                
                const string expected = "RedPlus";

                
                var actual = CreatorOther.GetName();

                
                Assert.AreEqual(expected, actual);
            }
        }
    }
}