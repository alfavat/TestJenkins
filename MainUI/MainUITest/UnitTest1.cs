using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MainUITest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            var x = 10;
            // act
            // assert
            Assert.AreEqual(x, 10);
        }
        [TestMethod]
        public void TestMethod2()
        {
            // arrange
            var x = 11;
            // act
            // assert
            Assert.AreEqual(x, 10);
        }
    }
}
