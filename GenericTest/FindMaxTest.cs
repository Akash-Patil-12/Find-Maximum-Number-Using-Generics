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
        public void GivenMaxStringPostion_WhenFindMaxString_shouldReturnsMax()
        {
            string[] stringArray = { "Apple", "Peach", "Banana" };
            FindMax<string> findMaxString = new FindMax<string>(stringArray);
            string stringMax = findMaxString.MaximumValue();
            Assert.AreEqual("Peach", stringMax);
     
        }
        /// <summery>
        /// Test case 1.2
        /// <summery>
        [TestMethod]
        public void GivenMaxIntPosition_WhenFindInteger_ShouldReturnsMax()
        {
            int[] intArray = { 20, 30, 50 };
            FindMax<int> findMaxInteger = new FindMax<int>(intArray);
            int intMax = findMaxInteger.MaximumValue();
            Assert.AreEqual(50, intMax);
        }
        /// <summery>
        /// Test case 1.3
        /// <summery>
        [TestMethod]
        public void GivenMaxDoublePosition_WhenFindDouble_ShouldReturnMax()
        {
            double[] doubleArray = { 30.12, 40.23, 50.12 };
            FindMax<double> findMaxDouble = new FindMax<double>(doubleArray);
            double DoubleMax = findMaxDouble.MaximumValue();
            Assert.AreEqual(50.12, DoubleMax);
        }
    }
}
