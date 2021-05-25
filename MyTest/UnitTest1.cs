using Microsoft.VisualStudio.TestTools.UnitTesting;
using medianArray;

namespace MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int [] a = new int[] {1, 2, 3};
            int [] b = new int[] {1, 5, 6};
            Assert.Equal(3.0, medianArray.Solution.FindMedianSortedArrays(a, b));
        }
    }
}
