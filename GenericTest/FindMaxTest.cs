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
            string firstMax = findMax.MaximumString("Peach","Apple","Banana");
            Assert.AreEqual("Peach", firstMax);
     
        }
        /// <summery>
        /// Test case 1.2
        /// <summery>
        [TestMethod]
        public void GivenMaxStringSecondPosition_WhenFindString_ShouldReturnsMaxSecond()
        {
            string seconMax = findMax.MaximumString("Apple", "Peach","Banana");
            Assert.AreEqual("Peach", seconMax);
        }
        /// <summery>
        /// Test case 1.3
        /// <summery>
        [TestMethod]
        public void GivenMaxStringThirdPosition_WhenFindString_ShouldReturnMaxThird()
        {
            string thirdMax = findMax.MaximumString("Apple","Banana","Peach");
            Assert.AreEqual("Peach",thirdMax);
        }
    }
}
