using Generics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericTest
{
    [TestClass]
    public class FindMaxTest
    {
        FindMax findMax = new FindMax();
        /// <summery>
        /// Test case 1.1
        /// <summery>
        [TestMethod]
        public void GivenMaxNumFirstPostion_WhenFindMaxNum_shouldReturnsMaxFirst()
        {
            int firstMax = findMax.MaximumIntegerNumber(22, 1, 3);
            Assert.AreEqual(22, firstMax);
     
        }
        /// <summery>
        /// Test case 1.2
        /// <summery>
        [TestMethod]
        public void GivenMaxNumSecondPosition_WhenFindNum_ShouldReturnsMaxSecond()
        {
            int seconMax = findMax.MaximumIntegerNumber(20, 50, 10);
            Assert.AreEqual(50, seconMax);
        }
        /// <summery>
        /// Test case 1.3
        /// <summery>
        [TestMethod]
        public void GivenMaxNumThirdPosition_WhenFindNum_ShouldReturnMaxThird()
        {
            int thirdMax = findMax.MaximumIntegerNumber(1, 2, 3);
            Assert.AreEqual(3,thirdMax);
        }
    }
}
