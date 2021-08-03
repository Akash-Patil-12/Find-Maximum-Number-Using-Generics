using Generics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericTest
{
    [TestClass]
    public class FindMaxTest
    {
        /// <summery>
        /// Test case 1.1
        /// <summery>
        [TestMethod]
        public void GivenMaxStringFirstPostion_WhenFindMaxString_shouldReturnsMaxFirst()
        {
            FindMax<string> findMaxString = new FindMax<string>("Apple", "Peach", "Banana");
            string firstMax = findMaxString.MaximumValue();
            Assert.AreEqual("Peach", firstMax);
     
        }
        /// <summery>
        /// Test case 1.2
        /// <summery>
        [TestMethod]
        public void GivenMaxIntSecondPosition_WhenFindInteger_ShouldReturnsMaxSecond()
        {
            FindMax<int> findMaxInteger = new FindMax<int>(12, 33, 23);
            int seconMax = findMaxInteger.MaximumValue();
            Assert.AreEqual(33, seconMax);
        }
        /// <summery>
        /// Test case 1.3
        /// <summery>
        [TestMethod]
        public void GivenMaxDoubleThirdPosition_WhenFindDouble_ShouldReturnMaxThird()
        {
            FindMax<double> findMaxDouble = new FindMax<double>(23.23, 44.12, 70.34);
            double thirdMax = findMaxDouble.MaximumValue();
            Assert.AreEqual(70.34, thirdMax);
        }
    }
}
