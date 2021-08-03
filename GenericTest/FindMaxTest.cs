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
            double firstMax = findMax.MaximumFloatNumber(22.23, 12.2, 3.2);
            Assert.AreEqual(22.23, firstMax);
     
        }
        /// <summery>
        /// Test case 1.2
        /// <summery>
        [TestMethod]
        public void GivenMaxNumSecondPosition_WhenFindNum_ShouldReturnsMaxSecond()
        {
            double seconMax = findMax.MaximumFloatNumber(20.12, 50.32, 10.54);
            Assert.AreEqual(50.32, seconMax);
        }
        /// <summery>
        /// Test case 1.3
        /// <summery>
        [TestMethod]
        public void GivenMaxNumThirdPosition_WhenFindNum_ShouldReturnMaxThird()
        {
            double thirdMax = findMax.MaximumFloatNumber(11.3, 22.32, 35.34);
            Assert.AreEqual(35.34,thirdMax);
        }
    }
}
