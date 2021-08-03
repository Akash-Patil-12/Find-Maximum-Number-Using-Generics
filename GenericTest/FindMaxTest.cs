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
        public void GivenMaxStringFirstPostion_WhenFindMaxString_shouldReturnsMaxFirst()
        {
            string firstMax = findMax.MaximumValue("Peach","Apple","Banana");
            Assert.AreEqual("Peach", firstMax);
     
        }
        /// <summery>
        /// Test case 1.2
        /// <summery>
        [TestMethod]
        public void GivenMaxStringSecondPosition_WhenFindString_ShouldReturnsMaxSecond()
        {
            int seconMax = findMax.MaximumValue(12,33,23);
            Assert.AreEqual(33, seconMax);
        }
        /// <summery>
        /// Test case 1.3
        /// <summery>
        [TestMethod]
        public void GivenMaxStringThirdPosition_WhenFindString_ShouldReturnMaxThird()
        {
            double thirdMax = findMax.MaximumValue(23.23,44.12,70.34);
            Assert.AreEqual(70.34,thirdMax);
        }
    }
}
